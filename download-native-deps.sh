#!/usr/bin/env bash

if [ $# -eq 0 ]; then
    echo "Missing first argument. Please provide the tag to download."
    exit 1
fi

TAG=$1

SCRIPT_ROOT=$( cd -- "$( dirname -- "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )

echo "Script is located in: $SCRIPT_ROOT"
echo "Using Tag: $TAG"

echo -n "Downloading windows x86 cimgui: "
curl -sfLo "$SCRIPT_ROOT/deps/cimgui/win-x86/cimgui.dll" "https://github.com/psydack/imgui.net-nativebuild/releases/download/$TAG/cimgui.win-x86.dll"
echo ""

echo -n "Downloading windows x64 cimgui: "
curl -sfLo "$SCRIPT_ROOT/deps/cimgui/win-x64/cimgui.dll" "https://github.com/psydack/imgui.net-nativebuild/releases/download/$TAG/cimgui.win-x64.dll"
echo ""

echo -n "Downloading windows arm64 cimgui: "
curl -sfLo "$SCRIPT_ROOT/deps/cimgui/win-arm64/cimgui.dll" "https://github.com/psydack/imgui.net-nativebuild/releases/download/$TAG/cimgui.win-arm64.dll"
echo ""

echo -n "Downloading linux x64 cimgui: "
curl -sfLo "$SCRIPT_ROOT/deps/cimgui/linux-x64/cimgui.so" "https://github.com/psydack/imgui.net-nativebuild/releases/download/$TAG/cimgui.so"
echo ""

echo -n "Downloading osx universal (x86_64 and arm64) cimgui: "
curl -sfLo "$SCRIPT_ROOT/deps/cimgui/osx/cimgui.dylib" "https://github.com/psydack/imgui.net-nativebuild/releases/download/$TAG/cimgui.dylib"
echo ""

echo -n "Downloading definitions json file: "
curl -sfLo "$SCRIPT_ROOT/src/CodeGenerator/definitions/cimgui/definitions.json" "https://github.com/psydack/imgui.net-nativebuild/releases/download/$TAG/definitions.json"
echo ""

echo -n "Downloading structs and enums json file: "
curl -sfLo "$SCRIPT_ROOT/src/CodeGenerator/definitions/cimgui/structs_and_enums.json" "https://github.com/psydack/imgui.net-nativebuild/releases/download/$TAG/structs_and_enums.json"
echo ""

# Optional extras — errors are ignored
mkdir -p "$SCRIPT_ROOT/deps/cimplot/win-x64" "$SCRIPT_ROOT/deps/cimplot/linux-x64" "$SCRIPT_ROOT/deps/cimplot/osx"
mkdir -p "$SCRIPT_ROOT/deps/cimnodes/win-x64" "$SCRIPT_ROOT/deps/cimnodes/linux-x64" "$SCRIPT_ROOT/deps/cimnodes/osx"
mkdir -p "$SCRIPT_ROOT/deps/cimguizmo/win-x64" "$SCRIPT_ROOT/deps/cimguizmo/linux-x64" "$SCRIPT_ROOT/deps/cimguizmo/osx"

echo -n "Downloading windows x64 cimplot (optional): "
curl -sfLo "$SCRIPT_ROOT/deps/cimplot/win-x64/cimplot.dll" "https://github.com/psydack/imgui.net-nativebuild/releases/download/$TAG/cimplot.win-x64.dll" || true
echo ""

echo -n "Downloading linux x64 cimplot (optional): "
curl -sfLo "$SCRIPT_ROOT/deps/cimplot/linux-x64/cimplot.so" "https://github.com/psydack/imgui.net-nativebuild/releases/download/$TAG/cimplot.so" || true
echo ""

echo -n "Downloading osx cimplot (optional): "
curl -sfLo "$SCRIPT_ROOT/deps/cimplot/osx/cimplot.dylib" "https://github.com/psydack/imgui.net-nativebuild/releases/download/$TAG/cimplot.dylib" || true
echo ""

echo -n "Downloading windows x64 cimnodes (optional): "
curl -sfLo "$SCRIPT_ROOT/deps/cimnodes/win-x64/cimnodes.dll" "https://github.com/psydack/imgui.net-nativebuild/releases/download/$TAG/cimnodes.win-x64.dll" || true
echo ""

echo -n "Downloading linux x64 cimnodes (optional): "
curl -sfLo "$SCRIPT_ROOT/deps/cimnodes/linux-x64/cimnodes.so" "https://github.com/psydack/imgui.net-nativebuild/releases/download/$TAG/cimnodes.so" || true
echo ""

echo -n "Downloading osx cimnodes (optional): "
curl -sfLo "$SCRIPT_ROOT/deps/cimnodes/osx/cimnodes.dylib" "https://github.com/psydack/imgui.net-nativebuild/releases/download/$TAG/cimnodes.dylib" || true
echo ""

echo -n "Downloading windows x64 cimguizmo (optional): "
curl -sfLo "$SCRIPT_ROOT/deps/cimguizmo/win-x64/cimguizmo.dll" "https://github.com/psydack/imgui.net-nativebuild/releases/download/$TAG/cimguizmo.win-x64.dll" || true
echo ""

echo -n "Downloading linux x64 cimguizmo (optional): "
curl -sfLo "$SCRIPT_ROOT/deps/cimguizmo/linux-x64/cimguizmo.so" "https://github.com/psydack/imgui.net-nativebuild/releases/download/$TAG/cimguizmo.so" || true
echo ""

echo -n "Downloading osx cimguizmo (optional): "
curl -sfLo "$SCRIPT_ROOT/deps/cimguizmo/osx/cimguizmo.dylib" "https://github.com/psydack/imgui.net-nativebuild/releases/download/$TAG/cimguizmo.dylib" || true
echo ""