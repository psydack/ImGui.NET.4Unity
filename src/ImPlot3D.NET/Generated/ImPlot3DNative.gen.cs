using System;
using System.Numerics;
using System.Runtime.InteropServices;
using ImGuiNET;

namespace ImPlot3DNET
{
    public static unsafe partial class ImPlot3DNative
    {
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DColormap ImPlot3D_AddColormap_Vec4Ptr(byte* name, Vector4* cols, int size, byte qual);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DColormap ImPlot3D_AddColormap_U32Ptr(byte* name, uint* cols, int size, byte qual);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot3D_BeginPlot(byte* title_id, Vector2 size, ImPlot3DFlags flags);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ImPlot3D_CreateContext();
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_DestroyContext(IntPtr ctx);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_EndPlot();
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4 ImPlot3D_GetColormapColor(int idx, ImPlot3DColormap cmap);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot3D_GetColormapCount();
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DColormap ImPlot3D_GetColormapIndex(byte* name);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImPlot3D_GetColormapName(ImPlot3DColormap cmap);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImPlot3D_GetColormapSize(ImPlot3DColormap cmap);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ImPlot3D_GetCurrentContext();
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* ImPlot3D_GetPlotDrawList();
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2 ImPlot3D_GetPlotRectPos();
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2 ImPlot3D_GetPlotRectSize();
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DStyle* ImPlot3D_GetStyle();
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImPlot3D_GetStyleColorU32(ImPlot3DCol idx);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4 ImPlot3D_GetStyleColorVec4(ImPlot3DCol idx);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4 ImPlot3D_NextColormapColor();
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DMarker ImPlot3D_NextMarker();
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DPoint ImPlot3D_PixelsToPlotPlane_Vec2(Vector2 pix, ImPlane3D plane, byte mask);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DPoint ImPlot3D_PixelsToPlotPlane_double(double x, double y, ImPlane3D plane, byte mask);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DRay ImPlot3D_PixelsToPlotRay_Vec2(Vector2 pix);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DRay ImPlot3D_PixelsToPlotRay_double(double x, double y);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotDummy(byte* label_id, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotImage_Vec2(byte* label_id, ImTextureRef tex_ref, ImPlot3DPoint center, ImPlot3DPoint axis_u, ImPlot3DPoint axis_v, Vector2 uv0, Vector2 uv1, Vector4 tint_col, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotImage_Plot3DPoint(byte* label_id, ImTextureRef tex_ref, ImPlot3DPoint p0, ImPlot3DPoint p1, ImPlot3DPoint p2, ImPlot3DPoint p3, Vector2 uv0, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector4 tint_col, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotLine_FloatPtr(byte* label_id, float* xs, float* ys, float* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotLine_doublePtr(byte* label_id, double* xs, double* ys, double* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotLine_S8Ptr(byte* label_id, sbyte* xs, sbyte* ys, sbyte* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotLine_U8Ptr(byte* label_id, byte* xs, byte* ys, byte* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotLine_S16Ptr(byte* label_id, short* xs, short* ys, short* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotLine_U16Ptr(byte* label_id, ushort* xs, ushort* ys, ushort* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotLine_S32Ptr(byte* label_id, int* xs, int* ys, int* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotLine_U32Ptr(byte* label_id, uint* xs, uint* ys, uint* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotLine_S64Ptr(byte* label_id, long* xs, long* ys, long* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotLine_U64Ptr(byte* label_id, ulong* xs, ulong* ys, ulong* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotMesh_FloatPtr(byte* label_id, float* vtx_xs, float* vtx_ys, float* vtx_zs, uint* idxs, int vtx_count, int idx_count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotMesh_doublePtr(byte* label_id, double* vtx_xs, double* vtx_ys, double* vtx_zs, uint* idxs, int vtx_count, int idx_count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotMesh_S8Ptr(byte* label_id, sbyte* vtx_xs, sbyte* vtx_ys, sbyte* vtx_zs, uint* idxs, int vtx_count, int idx_count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotMesh_U8Ptr(byte* label_id, byte* vtx_xs, byte* vtx_ys, byte* vtx_zs, uint* idxs, int vtx_count, int idx_count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotMesh_S16Ptr(byte* label_id, short* vtx_xs, short* vtx_ys, short* vtx_zs, uint* idxs, int vtx_count, int idx_count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotMesh_U16Ptr(byte* label_id, ushort* vtx_xs, ushort* vtx_ys, ushort* vtx_zs, uint* idxs, int vtx_count, int idx_count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotMesh_S32Ptr(byte* label_id, int* vtx_xs, int* vtx_ys, int* vtx_zs, uint* idxs, int vtx_count, int idx_count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotMesh_U32Ptr(byte* label_id, uint* vtx_xs, uint* vtx_ys, uint* vtx_zs, uint* idxs, int vtx_count, int idx_count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotMesh_S64Ptr(byte* label_id, long* vtx_xs, long* vtx_ys, long* vtx_zs, uint* idxs, int vtx_count, int idx_count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotMesh_U64Ptr(byte* label_id, ulong* vtx_xs, ulong* vtx_ys, ulong* vtx_zs, uint* idxs, int vtx_count, int idx_count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotQuad_FloatPtr(byte* label_id, float* xs, float* ys, float* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotQuad_doublePtr(byte* label_id, double* xs, double* ys, double* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotQuad_S8Ptr(byte* label_id, sbyte* xs, sbyte* ys, sbyte* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotQuad_U8Ptr(byte* label_id, byte* xs, byte* ys, byte* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotQuad_S16Ptr(byte* label_id, short* xs, short* ys, short* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotQuad_U16Ptr(byte* label_id, ushort* xs, ushort* ys, ushort* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotQuad_S32Ptr(byte* label_id, int* xs, int* ys, int* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotQuad_U32Ptr(byte* label_id, uint* xs, uint* ys, uint* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotQuad_S64Ptr(byte* label_id, long* xs, long* ys, long* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotQuad_U64Ptr(byte* label_id, ulong* xs, ulong* ys, ulong* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotScatter_FloatPtr(byte* label_id, float* xs, float* ys, float* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotScatter_doublePtr(byte* label_id, double* xs, double* ys, double* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotScatter_S8Ptr(byte* label_id, sbyte* xs, sbyte* ys, sbyte* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotScatter_U8Ptr(byte* label_id, byte* xs, byte* ys, byte* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotScatter_S16Ptr(byte* label_id, short* xs, short* ys, short* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotScatter_U16Ptr(byte* label_id, ushort* xs, ushort* ys, ushort* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotScatter_S32Ptr(byte* label_id, int* xs, int* ys, int* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotScatter_U32Ptr(byte* label_id, uint* xs, uint* ys, uint* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotScatter_S64Ptr(byte* label_id, long* xs, long* ys, long* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotScatter_U64Ptr(byte* label_id, ulong* xs, ulong* ys, ulong* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotSurface_FloatPtr(byte* label_id, float* xs, float* ys, float* zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotSurface_doublePtr(byte* label_id, double* xs, double* ys, double* zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotSurface_S8Ptr(byte* label_id, sbyte* xs, sbyte* ys, sbyte* zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotSurface_U8Ptr(byte* label_id, byte* xs, byte* ys, byte* zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotSurface_S16Ptr(byte* label_id, short* xs, short* ys, short* zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotSurface_U16Ptr(byte* label_id, ushort* xs, ushort* ys, ushort* zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotSurface_S32Ptr(byte* label_id, int* xs, int* ys, int* zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotSurface_U32Ptr(byte* label_id, uint* xs, uint* ys, uint* zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotSurface_S64Ptr(byte* label_id, long* xs, long* ys, long* zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotSurface_U64Ptr(byte* label_id, ulong* xs, ulong* ys, ulong* zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotText(byte* text, double x, double y, double z, double angle, Vector2 pix_offset);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2 ImPlot3D_PlotToPixels_Plot3DPoint(ImPlot3DPoint point);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2 ImPlot3D_PlotToPixels_double(double x, double y, double z);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotTriangle_FloatPtr(byte* label_id, float* xs, float* ys, float* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotTriangle_doublePtr(byte* label_id, double* xs, double* ys, double* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotTriangle_S8Ptr(byte* label_id, sbyte* xs, sbyte* ys, sbyte* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotTriangle_U8Ptr(byte* label_id, byte* xs, byte* ys, byte* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotTriangle_S16Ptr(byte* label_id, short* xs, short* ys, short* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotTriangle_U16Ptr(byte* label_id, ushort* xs, ushort* ys, ushort* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotTriangle_S32Ptr(byte* label_id, int* xs, int* ys, int* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotTriangle_U32Ptr(byte* label_id, uint* xs, uint* ys, uint* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotTriangle_S64Ptr(byte* label_id, long* xs, long* ys, long* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PlotTriangle_U64Ptr(byte* label_id, ulong* xs, ulong* ys, ulong* zs, int count, ImPlot3DSpec spec);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PopColormap(int count);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PopStyleColor(int count);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PopStyleVar(int count);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PushColormap_Plot3DColormap(ImPlot3DColormap cmap);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PushColormap_Str(byte* name);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PushStyleColor_U32(ImPlot3DCol idx, uint col);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PushStyleColor_Vec4(ImPlot3DCol idx, Vector4 col);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PushStyleVar_Float(ImPlot3DStyleVar idx, float val);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PushStyleVar_Int(ImPlot3DStyleVar idx, int val);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_PushStyleVar_Vec2(ImPlot3DStyleVar idx, Vector2 val);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4 ImPlot3D_SampleColormap(float t, ImPlot3DColormap cmap);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_SetCurrentContext(IntPtr ctx);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_SetStyle(ImPlot3DStyle style);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_SetupAxes(byte* x_label, byte* y_label, byte* z_label, ImPlot3DAxisFlags x_flags, ImPlot3DAxisFlags y_flags, ImPlot3DAxisFlags z_flags);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_SetupAxesLimits(double x_min, double x_max, double y_min, double y_max, double z_min, double z_max, ImPlot3DCond cond);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_SetupAxis(ImAxis3D axis, byte* label, ImPlot3DAxisFlags flags);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_SetupAxisFormat(ImAxis3D axis, IntPtr formatter, void* data);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_SetupAxisLimits(ImAxis3D axis, double v_min, double v_max, ImPlot3DCond cond);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_SetupAxisLimitsConstraints(ImAxis3D axis, double v_min, double v_max);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_SetupAxisScale_Plot3DScale(ImAxis3D axis, ImPlot3DScale scale);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_SetupAxisScale_Plot3DTransform(ImAxis3D axis, IntPtr forward, IntPtr inverse, void* data);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_SetupAxisTicks_doublePtr(ImAxis3D axis, double* values, int n_ticks, byte** labels, byte keep_default);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_SetupAxisTicks_double(ImAxis3D axis, double v_min, double v_max, int n_ticks, byte** labels, byte keep_default);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_SetupAxisZoomConstraints(ImAxis3D axis, double zoom_min, double zoom_max);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_SetupBoxInitialRotation_double(double elevation, double azimuth);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_SetupBoxInitialRotation_Plot3DQuat(ImPlot3DQuat rotation);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_SetupBoxRotation_double(double elevation, double azimuth, byte animate, ImPlot3DCond cond);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_SetupBoxRotation_Plot3DQuat(ImPlot3DQuat rotation, byte animate, ImPlot3DCond cond);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_SetupBoxScale(double x, double y, double z);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_SetupLegend(ImPlot3DLocation location, ImPlot3DLegendFlags flags);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_ShowAboutWindow(byte* p_open);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_ShowAllDemos();
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot3D_ShowColormapSelector(byte* label);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_ShowDemoWindow(byte* p_open);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_ShowMetricsWindow(byte* p_popen);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_ShowStyleEditor(ImPlot3DStyle* @ref);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot3D_ShowStyleSelector(byte* label);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_StyleColorsAuto(ImPlot3DStyle* dst);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_StyleColorsClassic(ImPlot3DStyle* dst);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_StyleColorsDark(ImPlot3DStyle* dst);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_StyleColorsLight(ImPlot3DStyle* dst);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot3DBox_ClipLineSegment(ImPlot3DBox* self, ImPlot3DPoint p0, ImPlot3DPoint p1, ImPlot3DPoint* p0_clipped, ImPlot3DPoint* p1_clipped);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot3DBox_Contains(ImPlot3DBox* self, ImPlot3DPoint point);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3DBox_destroy(ImPlot3DBox* self);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3DBox_Expand(ImPlot3DBox* self, ImPlot3DPoint point);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DBox* ImPlot3DBox_ImPlot3DBox_Nil();
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DBox* ImPlot3DBox_ImPlot3DBox_Plot3DPoint(ImPlot3DPoint min, ImPlot3DPoint max);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DPoint ImPlot3DPoint_Cross(ImPlot3DPoint* self, ImPlot3DPoint rhs);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3DPoint_destroy(ImPlot3DPoint* self);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot3DPoint_Dot(ImPlot3DPoint* self, ImPlot3DPoint rhs);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DPoint* ImPlot3DPoint_ImPlot3DPoint_Nil();
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DPoint* ImPlot3DPoint_ImPlot3DPoint_double(double _x, double _y, double _z);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot3DPoint_IsNaN(ImPlot3DPoint* self);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot3DPoint_Length(ImPlot3DPoint* self);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot3DPoint_LengthSquared(ImPlot3DPoint* self);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3DPoint_Normalize(ImPlot3DPoint* self);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DPoint ImPlot3DPoint_Normalized(ImPlot3DPoint* self);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DQuat ImPlot3DQuat_Conjugate(ImPlot3DQuat* self);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3DQuat_destroy(ImPlot3DQuat* self);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot3DQuat_Dot(ImPlot3DQuat* self, ImPlot3DQuat rhs);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DQuat ImPlot3DQuat_FromElAz(double elevation, double azimuth);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DQuat ImPlot3DQuat_FromTwoVectors(ImPlot3DPoint v0, ImPlot3DPoint v1);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DQuat* ImPlot3DQuat_ImPlot3DQuat_Nil();
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DQuat* ImPlot3DQuat_ImPlot3DQuat_doubledouble(double _x, double _y, double _z, double _w);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DQuat* ImPlot3DQuat_ImPlot3DQuat_doublePlot3DPoint(double _angle, ImPlot3DPoint _axis);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DQuat ImPlot3DQuat_Inverse(ImPlot3DQuat* self);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot3DQuat_Length(ImPlot3DQuat* self);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DQuat* ImPlot3DQuat_Normalize(ImPlot3DQuat* self);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DQuat ImPlot3DQuat_Normalized(ImPlot3DQuat* self);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DQuat ImPlot3DQuat_Slerp(ImPlot3DQuat q1, ImPlot3DQuat q2, double t);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImPlot3DRange_Contains(ImPlot3DRange* self, double value);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3DRange_destroy(ImPlot3DRange* self);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3DRange_Expand(ImPlot3DRange* self, double value);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DRange* ImPlot3DRange_ImPlot3DRange_Nil();
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DRange* ImPlot3DRange_ImPlot3DRange_double(double min, double max);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern double ImPlot3DRange_Size(ImPlot3DRange* self);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3DSpec_destroy(ImPlot3DSpec* self);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DSpec* ImPlot3DSpec_ImPlot3DSpec();
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3DSpec_SetProp_Float(ImPlot3DSpec* self, ImPlot3DProp prop, float v);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3DSpec_SetProp_double(ImPlot3DSpec* self, ImPlot3DProp prop, double v);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3DSpec_SetProp_S8(ImPlot3DSpec* self, ImPlot3DProp prop, sbyte v);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3DSpec_SetProp_U8(ImPlot3DSpec* self, ImPlot3DProp prop, byte v);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3DSpec_SetProp_S16(ImPlot3DSpec* self, ImPlot3DProp prop, short v);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3DSpec_SetProp_U16(ImPlot3DSpec* self, ImPlot3DProp prop, ushort v);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3DSpec_SetProp_S32(ImPlot3DSpec* self, ImPlot3DProp prop, int v);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3DSpec_SetProp_U32(ImPlot3DSpec* self, ImPlot3DProp prop, uint v);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3DSpec_SetProp_S64(ImPlot3DSpec* self, ImPlot3DProp prop, long v);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3DSpec_SetProp_U64(ImPlot3DSpec* self, ImPlot3DProp prop, ulong v);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3DSpec_SetProp_U32Ptr(ImPlot3DSpec* self, ImPlot3DProp prop, uint* v);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3DSpec_SetProp_FloatPtr(ImPlot3DSpec* self, ImPlot3DProp prop, float* v);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3DSpec_SetProp_Vec4(ImPlot3DSpec* self, ImPlot3DProp prop, Vector4 v);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3DStyle_destroy(ImPlot3DStyle* self);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4 ImPlot3DStyle_GetColor(ImPlot3DStyle* self, ImPlot3DCol idx);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DStyle* ImPlot3DStyle_ImPlot3DStyle_Nil();
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImPlot3DStyle* ImPlot3DStyle_ImPlot3DStyle_Plot3DStyle(ImPlot3DStyle other);
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3DStyle_SetColor(ImPlot3DStyle* self, ImPlot3DCol idx, Vector4 col);
    }
}
