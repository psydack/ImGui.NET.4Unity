# ImGui.NET.4Unity

ImGui.NET.4Unity is a maintained ImGui.NET fork focused on Unity integration scenarios.

It provides .NET bindings for:
- [Dear ImGui](https://github.com/ocornut/imgui) via [cimgui](https://github.com/cimgui/cimgui)
- ImPlot (`cimplot`)
- ImNodes (`cimnodes`)
- ImGuizmo (`cimguizmo`)
- Additional native variants used by this fork (`cimplot3d`, `cimnodes_r`, `cimguizmo_quat`, `cimCTE`)

## Project goal

This repository is used to keep native/runtime bindings updated and then propagate those updates to:
- https://github.com/psydack/uimgui/

In short: this is the update workspace used to bring newer ImGui ecosystem native libs and generated bindings into `psydack/uimgui`.

## How the repo works

Most of the API surface is generated from native definition JSON files.

- Native binaries are stored under `deps/<lib>/<rid>/`
- Native API JSON definitions are stored under `src/CodeGenerator/definitions/<lib>/`
- Generated C# bindings are emitted into each project `Generated/` folder

Projects in `src/`:
- `ImGui.NET`
- `ImPlot.NET`
- `ImNodes.NET`
- `ImGuizmo.NET`
- `CodeGenerator`
- Sample programs

## Update native dependencies

PowerShell:

```powershell
./download-native-deps.ps1
./download-native-deps.ps1 -tag <release-tag>
```

Bash:

```bash
./download-native-deps.sh
./download-native-deps.sh <release-tag>
```

By default, scripts download from:
- `https://github.com/psydack/ImGui.NET-nativebuild`

They refresh:
- Native binaries in `deps/`
- `definitions.json`, `structs_and_enums.json`, and `variants.json` in `src/CodeGenerator/definitions/`

## Regenerate bindings

Build and run the generator after updating native dependencies:

```bash
dotnet restore src
dotnet build src

# ImGui
bin/Release/CodeGenerator/net8.0/CodeGenerator.exe "src/ImGui.NET/Generated"

# ImPlot
bin/Release/CodeGenerator/net8.0/CodeGenerator.exe "src/ImPlot.NET/Generated" cimplot

# ImNodes
bin/Release/CodeGenerator/net8.0/CodeGenerator.exe "src/ImNodes.NET/Generated" cimnodes

# ImGuizmo
bin/Release/CodeGenerator/net8.0/CodeGenerator.exe "src/ImGuizmo.NET/Generated" cimguizmo

# ImPlot3D
bin/Release/CodeGenerator/net8.0/CodeGenerator.exe "src/ImPlot3D.NET/Generated" cimplot3d

# ImNodesR
bin/Release/CodeGenerator/net8.0/CodeGenerator.exe "src/ImNodesR.NET/Generated" cimnodes_r

# ImGuizmoQuat
bin/Release/CodeGenerator/net8.0/CodeGenerator.exe "src/ImGuizmoQuat.NET/Generated" cimguizmo_quat

# CimCTE
bin/Release/CodeGenerator/net8.0/CodeGenerator.exe "src/CimCTE.NET/Generated" cimCTE
```

## FreeType and custom_assert examples

### FreeType font loader (C#)

```csharp
ImGuiIOPtr io = ImGui.GetIO();
IntPtr freeTypeLoader = ImGui.GetFontLoader();
if (freeTypeLoader != IntPtr.Zero)
{
    io.Fonts.SetFontLoader(freeTypeLoader);
    io.Fonts.FontLoaderFlags = (uint)ImGuiFreeTypeLoaderFlags.LightHinting;
}
```

### custom_assert behavior (C# runtime toggle)

```csharp
ImGuiIOPtr io = ImGui.GetIO();
io.ConfigErrorRecoveryEnableAssert = true;
```

With native builds compiled with `custom_assert`, assertion failures are routed by the native assert hook.

### custom_assert hook (native build side)

```cpp
// Example at native build integration layer:
// #define IM_ASSERT(_EXPR) CustomAssert((_EXPR), #_EXPR, __FILE__, __LINE__)
```

## Build

```bash
dotnet restore src
dotnet build src
```

`ImGui.NET` currently targets:
- `netstandard2.0`
- `net6.0`
- `net8.0`

## Notes

- `Generated/*.gen.cs` files are generated artifacts and should not be edited manually.
- Manual wrapper behavior should be changed in `*.Manual.cs` files.

## Release 1.92.7v2

- Updated native deps/definitions from `psydack/ImGui.NET-nativebuild` tag `1.92.7`.
- Regenerated bindings for ImGui, ImPlot, ImPlot3D, ImNodes, ImNodesR, ImGuizmo, ImGuizmoQuat and CimCTE.
- Added FreeType and `custom_assert` usage examples to sample/docs.
- Native dependency refresh check executed on 2026-04-21 with no additional binary/definition diffs.
