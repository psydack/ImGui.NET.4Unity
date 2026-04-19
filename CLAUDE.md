# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Build Commands

```bash
# Restore dependencies
dotnet restore src

# Build all projects (Debug)
dotnet build src

# Build in Release mode
dotnet build -c Release --no-restore src

# Build NuGet package
dotnet pack src/ImGui.NET -c Release --no-restore --no-build

# Run code generator (regenerates all Generated/*.gen.cs files)
bin/Release/CodeGenerator/net8.0/CodeGenerator.exe "src/ImGui.NET/Generated"
# For other libraries: pass library name as second arg (cimplot, cimnodes, cimguizmo)
bin/Release/CodeGenerator/net8.0/CodeGenerator.exe "src/ImPlot.NET/Generated" cimplot
```

## Architecture

This repo is a .NET wrapper for [Dear ImGui](https://github.com/ocornut/imgui) via [cimgui](https://github.com/cimgui/cimgui) (a C API layer over the C++ library). It also wraps ImPlot, ImNodes, and ImGuizmo under the same pattern.

### Code Generation Pipeline

The majority of the C# API is **generated**, not hand-written:

1. **`deps/cimgui/`** — prebuilt native binaries (`cimgui.dll`, `libcimgui.so`, `libcimgui.dylib`) for win-x86/x64/arm64, linux-x64, osx.
2. **`src/CodeGenerator/definitions/cimgui/`** — `definitions.json` and `structs_and_enums.json` from the native build, describing the full C API surface. Equivalent JSON files exist for cimplot, cimnodes, cimguizmo.
3. **`src/CodeGenerator/`** — reads those JSON files and emits C# into the `Generated/` folders of each wrapper project.
4. **`src/ImGui.NET/Generated/*.gen.cs`** — the output; do not edit by hand.

When upgrading to a new imgui version, run `download-native-deps.sh <tag>` (or `download-native-deps.ps1`) to fetch new native binaries and updated definition JSON, then re-run the CodeGenerator.

### Project Structure

| Project | Description |
|---|---|
| `src/ImGui.NET` | Main wrapper (`ImGuiNET` namespace). Targets netstandard2.0 / net6.0 / net8.0. |
| `src/ImPlot.NET` | ImPlot wrapper (`ImPlotNET`). References ImGui.NET internals. |
| `src/ImNodes.NET` | ImNodes wrapper (`imnodesNET`). References ImGui.NET internals. |
| `src/ImGuizmo.NET` | ImGuizmo wrapper (`ImGuizmoNET`). References ImGui.NET internals. |
| `src/CodeGenerator` | Code generation tool. |
| `src/ImGui.NET.SampleProgram` | Sample using Veldrid for rendering. |
| `src/TestDotNetStandardLib` | Basic smoke-test project. |

### Manual vs Generated Code

Each wrapper project has two layers:
- **`*.gen.cs`** in `Generated/` — auto-generated P/Invoke structs, enums, and method wrappers. Never edit.
- **`*.Manual.cs`** and other non-generated files — hand-written safe wrappers, delegate types, and utilities. Edit these for behavior changes.

Key manual files in `src/ImGui.NET/`:
- `ImGui.Manual.cs` / `ImGui.Manual.ReadOnlySpan.cs` — safe managed API overloads
- `ImGuiNative.Manual.cs` — manual P/Invoke declarations not in the generator
- `Util.cs` — UTF-8 string marshaling helpers used throughout generated code

## C# Conventions

Follow `CsharpConventions.md` for all hand-written C# code, with `.editorconfig` as the machine-readable formatting/style source. In short:

- Use PascalCase for namespaces, types, methods, properties, constants, delegates, and public fields.
- Use camelCase for parameters and local variables.
- Prefix private instance fields with `_camelCase`.
- Use C# predefined type aliases (`int`, `string`, `bool`, etc.) for declarations; use framework type names only for static member access when it improves clarity.
- Prefer `var` for non-primitive local declarations when the assigned expression makes the type obvious; use explicit aliases for primitives.
- Use vertically aligned braces, four-space indentation, no tabs, and no identifier underscores except private fields.
- Avoid Hungarian notation, screaming caps, avoidable abbreviations, and names that differ only by casing.
- Prefer named arguments when they improve call-site clarity, especially for literals or ambiguous boolean/numeric arguments.

Generated files (`Generated/*.gen.cs`) are formatted consistently, but their public type/member names and enum values are owned by the native definition JSON and the code generator. Do not hand-rename generated API surface to satisfy naming rules; update the generator only when a generated-style change is intentional and repeatable.

### Native Library Loading

Native binaries are bundled in the NuGet package under `runtimes/<rid>/native/`. The `.targets` file at `src/ImGui.NET/build/net40/ImGui.NET.targets` handles copying them to output on build.

### Unsafe Code

The entire wrapper uses `AllowUnsafeBlocks`. String marshaling to native code converts .NET strings to UTF-8 byte pointers using stack allocation (up to `Util.StackAllocationSizeLimit = 2048` bytes) or heap allocation for larger strings.
