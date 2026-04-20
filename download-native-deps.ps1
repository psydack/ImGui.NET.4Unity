param (
    [Parameter(Mandatory=$false)][string]$tag,
    [Parameter(Mandatory=$false)][string]$repository = "https://github.com/psydack/ImGui.NET-nativebuild"
)

$ErrorActionPreference = "Stop"

if ($tag) {
    $downloadBase = "$repository/releases/download/$tag"
    Write-Host "Downloading native binaries from GitHub Release tag '$tag'..."
} else {
    $downloadBase = "$repository/releases/latest/download"
    Write-Host "Downloading native binaries from the latest GitHub Release..."
}

$libs = @(
    "cimgui",
    "cimplot",
    "cimplot3d",
    "cimnodes",
    "cimnodes_r",
    "cimguizmo",
    "cimguizmo_quat",
    "cimCTE"
)

$platforms = @(
    @{ Source = "win-x86";          Directory = "win-x86";    Extension = "dll" },
    @{ Source = "win-x64";          Directory = "win-x64";    Extension = "dll" },
    @{ Source = "win-arm64";        Directory = "win-arm64";  Extension = "dll" },
    @{ Source = "linux-x64";        Directory = "linux-x64";  Extension = "so" },
    @{ Source = "macos-universal";  Directory = "osx";        Extension = "dylib" }
)

$definitionsRoot = Join-Path $PSScriptRoot "src\CodeGenerator\definitions"
$depsRoot = Join-Path $PSScriptRoot "deps"
$tempRoot = Join-Path ([System.IO.Path]::GetTempPath()) ("imgui-net-nativebuild-" + [System.Guid]::NewGuid().ToString("N"))

function Copy-IfExists {
    param (
        [Parameter(Mandatory=$true)][string]$Source,
        [Parameter(Mandatory=$true)][string]$Destination
    )

    if (Test-Path -LiteralPath $Source) {
        New-Item -ItemType Directory -Force -Path (Split-Path -Parent $Destination) | Out-Null
        Copy-Item -LiteralPath $Source -Destination $Destination -Force
        return $true
    }

    return $false
}

function Get-ExtractedLibraryRoot {
    param (
        [Parameter(Mandatory=$true)][string]$ExtractRoot,
        [Parameter(Mandatory=$true)][string]$LibraryName
    )

    $expectedRoot = Join-Path $ExtractRoot $LibraryName
    if (Test-Path -LiteralPath $expectedRoot) {
        return $expectedRoot
    }

    $firstDirectory = Get-ChildItem -LiteralPath $ExtractRoot -Directory | Select-Object -First 1
    if ($firstDirectory) {
        return $firstDirectory.FullName
    }

    return $ExtractRoot
}

try {
    New-Item -ItemType Directory -Force -Path $tempRoot | Out-Null

    foreach ($lib in $libs) {
        $archivePath = Join-Path $tempRoot "$lib.zip"
        $extractPath = Join-Path $tempRoot $lib
        $libDepsPath = Join-Path $depsRoot $lib
        $definitionPath = Join-Path $definitionsRoot $lib

        Write-Host "- downloading $lib.zip"
        Invoke-WebRequest -Uri "$downloadBase/$lib.zip" -OutFile $archivePath

        if (Test-Path -LiteralPath $libDepsPath) {
            Remove-Item -LiteralPath $libDepsPath -Force -Recurse
        }

        New-Item -ItemType Directory -Force -Path $extractPath | Out-Null
        Expand-Archive -LiteralPath $archivePath -DestinationPath $extractPath -Force

        $libRoot = Get-ExtractedLibraryRoot -ExtractRoot $extractPath -LibraryName $lib

        foreach ($platform in $platforms) {
            $sourceFile = Join-Path $libRoot "$lib.$($platform.Source).$($platform.Extension)"
            $destinationFile = Join-Path (Join-Path $libDepsPath $platform.Directory) "$lib.$($platform.Extension)"

            if (Copy-IfExists -Source $sourceFile -Destination $destinationFile) {
                Write-Host "  copied $($platform.Directory)/$lib.$($platform.Extension)"
            }
        }

        foreach ($jsonName in @("definitions.json", "structs_and_enums.json", "variants.json")) {
            $jsonSource = Join-Path $libRoot $jsonName
            $jsonDestination = Join-Path $definitionPath $jsonName

            if (Copy-IfExists -Source $jsonSource -Destination $jsonDestination) {
                Write-Host "  copied definitions/$lib/$jsonName"
            }
        }
    }
} finally {
    if (Test-Path -LiteralPath $tempRoot) {
        Remove-Item -LiteralPath $tempRoot -Force -Recurse
    }
}

Write-Host "Native dependency download complete."
