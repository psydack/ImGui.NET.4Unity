using System.Collections.Generic;

namespace CodeGenerator
{
    public class TypeInfo
    {
        public static readonly Dictionary<string, string> WellKnownTypes = new Dictionary<string, string>()
        {
            { "bool", "byte" },
            { "unsigned char", "byte" },
            { "signed char", "sbyte" },
            { "char", "byte" },
            { "ImWchar", "ushort" },
            { "ImFileHandle", "IntPtr" },
            { "ImU8", "byte" },
            { "ImS8", "sbyte" },
            { "ImU16", "ushort" },
            { "ImS16", "short" },
            { "ImU32", "uint" },
            { "ImS32", "int" },
            { "ImU64", "ulong" },
            { "ImS64", "long" },
            { "unsigned short", "ushort" },
            { "unsigned int", "uint" },
            { "uint32_t", "uint" },
            { "ImVec2", "Vector2" },
            { "ImVec2_Simple", "Vector2" },
            { "ImVec3", "Vector3" },
            { "ImVec4", "Vector4" },
            { "vec3", "Vector3" },
            { "vec4", "Vector4" },
            { "quat", "Vector4" },
            { "vgButtons", "int" },
            { "vgModifiers", "int" },
            { "ImWchar16", "ushort" }, //char is not blittable
            { "ImVec4_Simple", "Vector4" },
            { "ImColor_Simple", "ImColor" },
            { "ImTextureID", "IntPtr" },
            { "ImGuiID", "uint" },
            { "ImDrawIdx", "ushort" },
            { "ImDrawListSharedData", "IntPtr" },
            { "ImDrawListSharedData*", "IntPtr" },
            { "ImDrawCallback", "IntPtr" },
            { "size_t", "uint" },
            { "ImGuiContext*", "IntPtr" },
            { "ImGuiWindow", "IntPtr" },
            { "ImGuiWindow*", "IntPtr" },
            { "ImPlotContext*", "IntPtr" },
            { "ImPlot3DContext", "IntPtr" },
            { "ImPlot3DContext*", "IntPtr" },
            { "ImNodesContext", "IntPtr" },
            { "ImNodesContext*", "IntPtr" },
            { "ImNodesEditorContext", "IntPtr" },
            { "ImNodesEditorContext*", "IntPtr" },
            { "EditorContext*", "IntPtr" },
            { "Context*", "IntPtr" },
            { "_CanvasStateImpl*", "IntPtr" },
            { "ImGuiMemAllocFunc", "IntPtr" },
            { "ImGuiMemFreeFunc", "IntPtr" },
            { "ImFontBuilderIO", "IntPtr" },
            { "float[2]", "Vector2*" },
            { "float[3]", "Vector3*" },
            { "float[4]", "Vector4*" },
            { "int[2]", "int*" },
            { "int[3]", "int*" },
            { "int[4]", "int*" },
            { "float&", "float*" },
            { "ImVec2[2]", "Vector2*" },
            { "char* []", "byte**" },
            { "unsigned char[256]", "byte*"},
            { "ImPlotFormatter", "IntPtr" },
            { "ImPlotGetter", "IntPtr" },
            { "ImPlotTransform", "IntPtr" },
            { "ImPlotPoint_c", "ImPlotPoint" },
            { "ImPlotRect_c", "ImPlotRect" },
            { "ImPlotPoint_getter", "IntPtr" },
            { "ImPlot3DPoint_c", "ImPlot3DPoint" },
            { "ImPlot3DQuat_c", "ImPlot3DQuat" },
            { "ImPlot3DFormatter", "IntPtr" },
            { "ImPlot3DTransform", "IntPtr" },
            { "ImNodesMiniMapNodeHoveringCallback", "IntPtr" },
            { "ImNodesMiniMapNodeHoveringCallbackUserData", "IntPtr" },
            { "std::string_view::const_iterator", "IntPtr" },
            { "std::string_view::_iterator", "IntPtr" },
            { "std::string_view", "IntPtr" },
            { "std::string", "IntPtr" },
            { "const_iterator", "IntPtr" },
            { "_iterator", "IntPtr" },
            { "const std::string_view", "IntPtr" },
            { "std::function_std_string_std_string_view_", "IntPtr" },
            { "std::function_void_const_std_stringamp_identifier_", "IntPtr" },
            { "std::function_void__std_stringamp_identifier_", "IntPtr" },
            { "std::function_void_int_line__voidPtr_data_", "IntPtr" },
            { "std::function_void__", "IntPtr" },
            { "std::function_voidPtr_int_line_", "IntPtr" },
            { "std::function_void_Decoratoramp_decorator_", "IntPtr" },
            { "std::function_void_int_line_", "IntPtr" },
            { "std::function_void_int_line__int_column_", "IntPtr" },
            { "std::function<void(std::vector_void_std_vector_Change* )>", "IntPtr" },
            { "const std::vector_std_string", "IntPtr" },
            { "std::vector_std_string", "IntPtr" },
            { "std::vector_std_string*", "IntPtr" },
            { "Language_opq", "IntPtr" },
            { "Palette_opq", "IntPtr" },
            { "CursorPosition_c", "CursorPosition" },
            { "CursorSelection_c", "CursorSelection" },
            { "struct { ImVec4 NodeBodyBg; ImVec4 NodeBodyBgHovered; ImVec4 NodeBodyBgActive; ImVec4 NodeBorder; ImVec4 NodeTitleBarBg; ImVec4 NodeTitleBarBgHovered; ImVec4 NodeTitleBarBgActive; }", "StyleVarsColors" },
            { "ImGuiKeyChord", "ImGuiKey" },
            { "ImGuiSelectionUserData", "long" },
            // By-value struct return types added in cimgui 1.92.7.
            { "ImVec2_c", "Vector2" },
            { "ImVec4_c", "Vector4" },
            { "ImColor_c", "ImColor" },
            { "ImTextureRef_c", "ImTextureRef" },
            // Handle/ID type used by font atlas rect management.
            { "ImFontAtlasRectId", "uint" },
            // Internal types exposed via public ImFontAtlas API are opaque.
            { "ImFontAtlasBuilder", "IntPtr" },
            { "ImFontAtlasBuilder*", "IntPtr" },
            { "ImFontLoader", "IntPtr" },
            { "ImFontLoader*", "IntPtr" },
            { "const ImFontLoader", "IntPtr" },
            { "const ImFontLoader*", "IntPtr" },
            // Internal enum now referenced from public ImFont API.
            { "ImDrawTextFlags", "int" },
            // Identity mapping prevents spurious Ptr wrapper generation.
            { "ImGuiFreeTypeLoaderFlags", "ImGuiFreeTypeLoaderFlags" },
        };
        
        public static readonly List<string> WellKnownEnums = new List<string>()
        {
            "ImGuiMouseButton"
        };

        public static readonly Dictionary<string, string> AlternateEnumPrefixes = new Dictionary<string, string>()
        {
            { "ImGuiKey", "ImGuiMod" },
        };

        public static readonly Dictionary<string, string> AlternateEnumPrefixSubstitutions = new Dictionary<string, string>()
        {
            { "ImGuiMod_", "Mod" },
        };

        public static readonly Dictionary<string, string> WellKnownFieldReplacements = new Dictionary<string, string>()
        {
            { "bool", "bool" }, // Force bool to remain as bool in type-safe wrappers.
        };

        public static readonly HashSet<string> CustomDefinedTypes = new HashSet<string>()
        {
            "ImVector",
            "ImVec2",
            "ImVec4",
            "ImGuiStoragePair",
        };

        public static readonly Dictionary<string, string> WellKnownDefaultValues = new Dictionary<string, string>()
        {
            { "((void *)0)", "null" },
            { "((void*)0)", "null" },
            { "NULL", "null"},
            { "nullptr", "null"},
            { "ImVec2(0,0)", "new Vector2()" },
            { "ImVec2()", "new Vector2()" },
            { "ImVec2(0.0f,0.0f)", "new Vector2()" },
            { "ImVec2(-FLT_MIN,0)", "new Vector2(-float.MinValue, 0.0f)" },
            { "ImVec2(-1,0)", "new Vector2(-1, 0)" },
            { "ImVec2(1,0)", "new Vector2(1, 0)" },
            { "ImVec2(1,1)", "new Vector2(1, 1)" },
            { "ImVec2(0,1)", "new Vector2(0, 1)" },
            { "ImVec4(0,0,0,0)", "new Vector4()" },
            { "ImVec4(1,1,1,1)", "new Vector4(1, 1, 1, 1)" },
            { "ImVec4(0,0,0,-1)", "new Vector4(0, 0, 0, -1)" },
            { "ImPlotPoint(0,0)", "new ImPlotPoint { x = 0, y = 0 }" },
            { "ImPlotPoint(1,1)", "new ImPlotPoint { x = 1, y = 1 }" },
            { "ImPlotSpec()", "new ImPlotSpec()" },
            { "ImPlot3DSpec()", "new ImPlot3DSpec()" },
            { "IMPLOT_AUTO_COL", "new Vector4(0, 0, 0, -1)" },
            { "ImDrawCornerFlags_All", "ImDrawCornerFlags.All" },
            { "ImPlotFlags_None", "ImPlotFlags.None"},
            { "ImPlotAxisFlags_None", "ImPlotAxisFlags.None"},
            { "ImPlotAxisFlags_NoGridLines", "ImPlotAxisFlags.NoGridLines"},
            { "ImGuiCond_Once", "ImGuiCond.Once"},
            { "ImPlotOrientation_Vertical", "ImPlotOrientation.Vertical"},
            { "PinShape_CircleFilled", "PinShape.CircleFilled"},
            { "ImNodesPinShape_CircleFilled", "ImNodesPinShape.CircleFilled"},
            { "ImNodesMiniMapLocation_TopLeft", "ImNodesMiniMapLocation.TopLeft"},
            { "ImGuiPopupFlags_None", "ImGuiPopupFlags.None"},
            { "ImGuiNavHighlightFlags_TypeDefault", "ImGuiNavHighlightFlags.TypeDefault"},
            { "ImGuiKeyModFlags_Ctrl", "ImGuiKeyModFlags.Ctrl"},
            { "ImPlotYAxis_1", "ImPlotYAxis._1"},
            { "FLT_MAX", "float.MaxValue" },
            { "(((ImU32)(255)<<24)|((ImU32)(255)<<16)|((ImU32)(255)<<8)|((ImU32)(255)<<0))", "0xFFFFFFFF" },
            { "sizeof(ImU8)", "sizeof(byte)"},
            { "sizeof(ImS8)", "sizeof(sbyte)"},
            { "sizeof(ImU16)", "sizeof(ushort)"},
            { "sizeof(ImS16)", "sizeof(short)"},
            { "sizeof(ImU32)", "sizeof(uint)"},
            { "sizeof(ImS32)", "sizeof(int)"},
            { "sizeof(ImU64)", "sizeof(ulong)"},
            { "sizeof(ImS64)", "sizeof(long)"},
            { "ImPlotBin_Sturges", "(int)ImPlotBin.Sturges" },
            { "ImPlotRect()", "new ImPlotRect()" },
            { "ImPlotCond_Once", "ImPlotCond.Once" },
            { "ImPlot3DCond_Once", "ImPlot3DCond.Once" },
            { "ImPlotRange()", "new ImPlotRange()" },
            { "(ImGui::GetFrameHeightWithSpacing()* 4 -(ImGui::GetStyle().ItemSpacing.y* 2))", "ImGui.GetFrameHeightWithSpacing() * 4 - (ImGui.GetStyle().ItemSpacing.Y * 2)" },
            { "imguiGizmo::mode3Axes|imguiGizmo::cubeAtOrigin", "257" },
            { "imguiGizmo::modeDirection", "2" },
            { "imguiGizmo::modeDual|imguiGizmo::cubeAtOrigin", "264" },
            { "planeThickness", "0.04f" },
            
        };

        public static readonly Dictionary<string, string> IdentifierReplacements = new Dictionary<string, string>()
        {
            { "in", "@in" },
            { "out", "@out" },
            { "ref", "@ref" },
            { "base", "@base" },
            { "string", "@string" },
            { "params", "@params" },
        };

        public static readonly HashSet<string> LegalFixedTypes = new HashSet<string>()
        {
            "byte",
            "sbyte",
            "char",
            "ushort",
            "short",
            "uint",
            "int",
            "ulong",
            "long",
            "float",
            "double",
        };

        public static readonly HashSet<string> SkippedFunctions = new HashSet<string>()
        {
            "igInputText",
            "igInputTextMultiline",
            "igInputTextWithHint"
        };
    }
}
