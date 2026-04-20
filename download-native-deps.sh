#!/usr/bin/env bash
set -euo pipefail

REPOSITORY="${REPOSITORY:-https://github.com/psydack/ImGui.NET-nativebuild}"
TAG="${1:-}"

SCRIPT_ROOT=$( cd -- "$( dirname -- "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )

if [ -n "$TAG" ]; then
    DOWNLOAD_BASE="$REPOSITORY/releases/download/$TAG"
    echo "Downloading native binaries from GitHub Release tag '$TAG'..."
else
    DOWNLOAD_BASE="$REPOSITORY/releases/latest/download"
    echo "Downloading native binaries from the latest GitHub Release..."
fi

LIBS=(
    "cimgui"
    "cimplot"
    "cimplot3d"
    "cimnodes"
    "cimnodes_r"
    "cimguizmo"
    "cimguizmo_quat"
    "cimCTE"
)

PLATFORM_SOURCES=(
    "win-x86"
    "win-x64"
    "win-arm64"
    "linux-x64"
    "macos-universal"
)

PLATFORM_DIRS=(
    "win-x86"
    "win-x64"
    "win-arm64"
    "linux-x64"
    "osx"
)

PLATFORM_EXTENSIONS=(
    "dll"
    "dll"
    "dll"
    "so"
    "dylib"
)

TEMP_ROOT=$(mktemp -d)
trap 'rm -rf "$TEMP_ROOT"' EXIT

copy_if_exists() {
    local source=$1
    local destination=$2

    if [ -f "$source" ]; then
        mkdir -p "$(dirname "$destination")"
        cp "$source" "$destination"
        return 0
    fi

    return 1
}

get_extracted_library_root() {
    local extract_root=$1
    local lib=$2
    local expected_root="$extract_root/$lib"

    if [ -d "$expected_root" ]; then
        echo "$expected_root"
        return
    fi

    local first_directory
    first_directory=$(find "$extract_root" -mindepth 1 -maxdepth 1 -type d | head -n 1)
    if [ -n "$first_directory" ]; then
        echo "$first_directory"
        return
    fi

    echo "$extract_root"
}

for lib in "${LIBS[@]}"; do
    archive_path="$TEMP_ROOT/$lib.zip"
    extract_path="$TEMP_ROOT/$lib"
    lib_deps_path="$SCRIPT_ROOT/deps/$lib"
    definition_path="$SCRIPT_ROOT/src/CodeGenerator/definitions/$lib"

    echo "- downloading $lib.zip"
    curl -fL "$DOWNLOAD_BASE/$lib.zip" -o "$archive_path"

    rm -rf "$lib_deps_path"
    mkdir -p "$extract_path"
    unzip -q "$archive_path" -d "$extract_path"

    lib_root=$(get_extracted_library_root "$extract_path" "$lib")

    for index in "${!PLATFORM_SOURCES[@]}"; do
        source_file="$lib_root/$lib.${PLATFORM_SOURCES[$index]}.${PLATFORM_EXTENSIONS[$index]}"
        destination_file="$lib_deps_path/${PLATFORM_DIRS[$index]}/$lib.${PLATFORM_EXTENSIONS[$index]}"

        if copy_if_exists "$source_file" "$destination_file"; then
            echo "  copied ${PLATFORM_DIRS[$index]}/$lib.${PLATFORM_EXTENSIONS[$index]}"
        fi
    done

    for json_name in "definitions.json" "structs_and_enums.json" "variants.json"; do
        json_source="$lib_root/$json_name"
        json_destination="$definition_path/$json_name"

        if copy_if_exists "$json_source" "$json_destination"; then
            echo "  copied definitions/$lib/$json_name"
        fi
    done
done

echo "Native dependency download complete."
