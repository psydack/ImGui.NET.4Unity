using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using ImGuiNET;

namespace ImPlot3DNET
{
    public static unsafe partial class ImPlot3D
    {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static ImPlot3DColormap AddColormap(ReadOnlySpan<char> name, ref Vector4 cols, int size)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte qual = 1;
            fixed (Vector4* native_cols = &cols)
            {
                ImPlot3DColormap ret = ImPlot3DNative.ImPlot3D_AddColormap_Vec4Ptr(native_name, native_cols, size, qual);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_name);
                }
                return ret;
            }
        }
#endif
        public static ImPlot3DColormap AddColormap(string name, ref Vector4 cols, int size)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte qual = 1;
            fixed (Vector4* native_cols = &cols)
            {
                ImPlot3DColormap ret = ImPlot3DNative.ImPlot3D_AddColormap_Vec4Ptr(native_name, native_cols, size, qual);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_name);
                }
                return ret;
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static ImPlot3DColormap AddColormap(ReadOnlySpan<char> name, ref Vector4 cols, int size, bool qual)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte native_qual = qual ? (byte)1 : (byte)0;
            fixed (Vector4* native_cols = &cols)
            {
                ImPlot3DColormap ret = ImPlot3DNative.ImPlot3D_AddColormap_Vec4Ptr(native_name, native_cols, size, native_qual);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_name);
                }
                return ret;
            }
        }
#endif
        public static ImPlot3DColormap AddColormap(string name, ref Vector4 cols, int size, bool qual)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte native_qual = qual ? (byte)1 : (byte)0;
            fixed (Vector4* native_cols = &cols)
            {
                ImPlot3DColormap ret = ImPlot3DNative.ImPlot3D_AddColormap_Vec4Ptr(native_name, native_cols, size, native_qual);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_name);
                }
                return ret;
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static ImPlot3DColormap AddColormap(ReadOnlySpan<char> name, ref uint cols, int size)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte qual = 1;
            fixed (uint* native_cols = &cols)
            {
                ImPlot3DColormap ret = ImPlot3DNative.ImPlot3D_AddColormap_U32Ptr(native_name, native_cols, size, qual);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_name);
                }
                return ret;
            }
        }
#endif
        public static ImPlot3DColormap AddColormap(string name, ref uint cols, int size)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte qual = 1;
            fixed (uint* native_cols = &cols)
            {
                ImPlot3DColormap ret = ImPlot3DNative.ImPlot3D_AddColormap_U32Ptr(native_name, native_cols, size, qual);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_name);
                }
                return ret;
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static ImPlot3DColormap AddColormap(ReadOnlySpan<char> name, ref uint cols, int size, bool qual)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte native_qual = qual ? (byte)1 : (byte)0;
            fixed (uint* native_cols = &cols)
            {
                ImPlot3DColormap ret = ImPlot3DNative.ImPlot3D_AddColormap_U32Ptr(native_name, native_cols, size, native_qual);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_name);
                }
                return ret;
            }
        }
#endif
        public static ImPlot3DColormap AddColormap(string name, ref uint cols, int size, bool qual)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            byte native_qual = qual ? (byte)1 : (byte)0;
            fixed (uint* native_cols = &cols)
            {
                ImPlot3DColormap ret = ImPlot3DNative.ImPlot3D_AddColormap_U32Ptr(native_name, native_cols, size, native_qual);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_name);
                }
                return ret;
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool BeginPlot(ReadOnlySpan<char> title_id)
        {
            byte* native_title_id;
            int title_id_byteCount = 0;
            if (title_id != null)
            {
                title_id_byteCount = Encoding.UTF8.GetByteCount(title_id);
                if (title_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_title_id = Util.Allocate(title_id_byteCount + 1);
                }
                else
                {
                    byte* native_title_id_stackBytes = stackalloc byte[title_id_byteCount + 1];
                    native_title_id = native_title_id_stackBytes;
                }
                int native_title_id_offset = Util.GetUtf8(title_id, native_title_id, title_id_byteCount);
                native_title_id[native_title_id_offset] = 0;
            }
            else { native_title_id = null; }
            Vector2 size = new Vector2(-1, 0);
            ImPlot3DFlags flags = (ImPlot3DFlags)0;
            byte ret = ImPlot3DNative.ImPlot3D_BeginPlot(native_title_id, size, flags);
            if (title_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_title_id);
            }
            return ret != 0;
        }
#endif
        public static bool BeginPlot(string title_id)
        {
            byte* native_title_id;
            int title_id_byteCount = 0;
            if (title_id != null)
            {
                title_id_byteCount = Encoding.UTF8.GetByteCount(title_id);
                if (title_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_title_id = Util.Allocate(title_id_byteCount + 1);
                }
                else
                {
                    byte* native_title_id_stackBytes = stackalloc byte[title_id_byteCount + 1];
                    native_title_id = native_title_id_stackBytes;
                }
                int native_title_id_offset = Util.GetUtf8(title_id, native_title_id, title_id_byteCount);
                native_title_id[native_title_id_offset] = 0;
            }
            else { native_title_id = null; }
            Vector2 size = new Vector2(-1, 0);
            ImPlot3DFlags flags = (ImPlot3DFlags)0;
            byte ret = ImPlot3DNative.ImPlot3D_BeginPlot(native_title_id, size, flags);
            if (title_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_title_id);
            }
            return ret != 0;
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool BeginPlot(ReadOnlySpan<char> title_id, Vector2 size)
        {
            byte* native_title_id;
            int title_id_byteCount = 0;
            if (title_id != null)
            {
                title_id_byteCount = Encoding.UTF8.GetByteCount(title_id);
                if (title_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_title_id = Util.Allocate(title_id_byteCount + 1);
                }
                else
                {
                    byte* native_title_id_stackBytes = stackalloc byte[title_id_byteCount + 1];
                    native_title_id = native_title_id_stackBytes;
                }
                int native_title_id_offset = Util.GetUtf8(title_id, native_title_id, title_id_byteCount);
                native_title_id[native_title_id_offset] = 0;
            }
            else { native_title_id = null; }
            ImPlot3DFlags flags = (ImPlot3DFlags)0;
            byte ret = ImPlot3DNative.ImPlot3D_BeginPlot(native_title_id, size, flags);
            if (title_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_title_id);
            }
            return ret != 0;
        }
#endif
        public static bool BeginPlot(string title_id, Vector2 size)
        {
            byte* native_title_id;
            int title_id_byteCount = 0;
            if (title_id != null)
            {
                title_id_byteCount = Encoding.UTF8.GetByteCount(title_id);
                if (title_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_title_id = Util.Allocate(title_id_byteCount + 1);
                }
                else
                {
                    byte* native_title_id_stackBytes = stackalloc byte[title_id_byteCount + 1];
                    native_title_id = native_title_id_stackBytes;
                }
                int native_title_id_offset = Util.GetUtf8(title_id, native_title_id, title_id_byteCount);
                native_title_id[native_title_id_offset] = 0;
            }
            else { native_title_id = null; }
            ImPlot3DFlags flags = (ImPlot3DFlags)0;
            byte ret = ImPlot3DNative.ImPlot3D_BeginPlot(native_title_id, size, flags);
            if (title_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_title_id);
            }
            return ret != 0;
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool BeginPlot(ReadOnlySpan<char> title_id, Vector2 size, ImPlot3DFlags flags)
        {
            byte* native_title_id;
            int title_id_byteCount = 0;
            if (title_id != null)
            {
                title_id_byteCount = Encoding.UTF8.GetByteCount(title_id);
                if (title_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_title_id = Util.Allocate(title_id_byteCount + 1);
                }
                else
                {
                    byte* native_title_id_stackBytes = stackalloc byte[title_id_byteCount + 1];
                    native_title_id = native_title_id_stackBytes;
                }
                int native_title_id_offset = Util.GetUtf8(title_id, native_title_id, title_id_byteCount);
                native_title_id[native_title_id_offset] = 0;
            }
            else { native_title_id = null; }
            byte ret = ImPlot3DNative.ImPlot3D_BeginPlot(native_title_id, size, flags);
            if (title_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_title_id);
            }
            return ret != 0;
        }
#endif
        public static bool BeginPlot(string title_id, Vector2 size, ImPlot3DFlags flags)
        {
            byte* native_title_id;
            int title_id_byteCount = 0;
            if (title_id != null)
            {
                title_id_byteCount = Encoding.UTF8.GetByteCount(title_id);
                if (title_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_title_id = Util.Allocate(title_id_byteCount + 1);
                }
                else
                {
                    byte* native_title_id_stackBytes = stackalloc byte[title_id_byteCount + 1];
                    native_title_id = native_title_id_stackBytes;
                }
                int native_title_id_offset = Util.GetUtf8(title_id, native_title_id, title_id_byteCount);
                native_title_id[native_title_id_offset] = 0;
            }
            else { native_title_id = null; }
            byte ret = ImPlot3DNative.ImPlot3D_BeginPlot(native_title_id, size, flags);
            if (title_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_title_id);
            }
            return ret != 0;
        }
        public static IntPtr CreateContext()
        {
            IntPtr ret = ImPlot3DNative.ImPlot3D_CreateContext();
            return ret;
        }
        public static void DestroyContext()
        {
            IntPtr ctx = IntPtr.Zero;
            ImPlot3DNative.ImPlot3D_DestroyContext(ctx);
        }
        public static void DestroyContext(IntPtr ctx)
        {
            ImPlot3DNative.ImPlot3D_DestroyContext(ctx);
        }
        public static void EndPlot()
        {
            ImPlot3DNative.ImPlot3D_EndPlot();
        }
        public static Vector4 GetColormapColor(int idx)
        {
            ImPlot3DColormap cmap = (ImPlot3DColormap)(-1);
            Vector4 ret = ImPlot3DNative.ImPlot3D_GetColormapColor(idx, cmap);
            return ret;
        }
        public static Vector4 GetColormapColor(int idx, ImPlot3DColormap cmap)
        {
            Vector4 ret = ImPlot3DNative.ImPlot3D_GetColormapColor(idx, cmap);
            return ret;
        }
        public static int GetColormapCount()
        {
            int ret = ImPlot3DNative.ImPlot3D_GetColormapCount();
            return ret;
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static ImPlot3DColormap GetColormapIndex(ReadOnlySpan<char> name)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            ImPlot3DColormap ret = ImPlot3DNative.ImPlot3D_GetColormapIndex(native_name);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            return ret;
        }
#endif
        public static ImPlot3DColormap GetColormapIndex(string name)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            ImPlot3DColormap ret = ImPlot3DNative.ImPlot3D_GetColormapIndex(native_name);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
            return ret;
        }
        public static string GetColormapName(ImPlot3DColormap cmap)
        {
            byte* ret = ImPlot3DNative.ImPlot3D_GetColormapName(cmap);
            return Util.StringFromPtr(ret);
        }
        public static int GetColormapSize()
        {
            ImPlot3DColormap cmap = (ImPlot3DColormap)(-1);
            int ret = ImPlot3DNative.ImPlot3D_GetColormapSize(cmap);
            return ret;
        }
        public static int GetColormapSize(ImPlot3DColormap cmap)
        {
            int ret = ImPlot3DNative.ImPlot3D_GetColormapSize(cmap);
            return ret;
        }
        public static IntPtr GetCurrentContext()
        {
            IntPtr ret = ImPlot3DNative.ImPlot3D_GetCurrentContext();
            return ret;
        }
        public static ImDrawListPtr GetPlotDrawList()
        {
            ImDrawList* ret = ImPlot3DNative.ImPlot3D_GetPlotDrawList();
            return new ImDrawListPtr(ret);
        }
        public static Vector2 GetPlotRectPos()
        {
            Vector2 ret = ImPlot3DNative.ImPlot3D_GetPlotRectPos();
            return ret;
        }
        public static Vector2 GetPlotRectSize()
        {
            Vector2 ret = ImPlot3DNative.ImPlot3D_GetPlotRectSize();
            return ret;
        }
        public static ImPlot3DStylePtr GetStyle()
        {
            ImPlot3DStyle* ret = ImPlot3DNative.ImPlot3D_GetStyle();
            return new ImPlot3DStylePtr(ret);
        }
        public static uint GetStyleColorU32(ImPlot3DCol idx)
        {
            uint ret = ImPlot3DNative.ImPlot3D_GetStyleColorU32(idx);
            return ret;
        }
        public static Vector4 GetStyleColorVec4(ImPlot3DCol idx)
        {
            Vector4 ret = ImPlot3DNative.ImPlot3D_GetStyleColorVec4(idx);
            return ret;
        }
        public static Vector4 NextColormapColor()
        {
            Vector4 ret = ImPlot3DNative.ImPlot3D_NextColormapColor();
            return ret;
        }
        public static ImPlot3DMarker NextMarker()
        {
            ImPlot3DMarker ret = ImPlot3DNative.ImPlot3D_NextMarker();
            return ret;
        }
        public static ImPlot3DPoint PixelsToPlotPlane(Vector2 pix, ImPlane3D plane)
        {
            byte mask = 1;
            ImPlot3DPoint ret = ImPlot3DNative.ImPlot3D_PixelsToPlotPlane_Vec2(pix, plane, mask);
            return ret;
        }
        public static ImPlot3DPoint PixelsToPlotPlane(Vector2 pix, ImPlane3D plane, bool mask)
        {
            byte native_mask = mask ? (byte)1 : (byte)0;
            ImPlot3DPoint ret = ImPlot3DNative.ImPlot3D_PixelsToPlotPlane_Vec2(pix, plane, native_mask);
            return ret;
        }
        public static ImPlot3DPoint PixelsToPlotPlane(double x, double y, ImPlane3D plane)
        {
            byte mask = 1;
            ImPlot3DPoint ret = ImPlot3DNative.ImPlot3D_PixelsToPlotPlane_double(x, y, plane, mask);
            return ret;
        }
        public static ImPlot3DPoint PixelsToPlotPlane(double x, double y, ImPlane3D plane, bool mask)
        {
            byte native_mask = mask ? (byte)1 : (byte)0;
            ImPlot3DPoint ret = ImPlot3DNative.ImPlot3D_PixelsToPlotPlane_double(x, y, plane, native_mask);
            return ret;
        }
        public static ImPlot3DRay PixelsToPlotRay(Vector2 pix)
        {
            ImPlot3DRay ret = ImPlot3DNative.ImPlot3D_PixelsToPlotRay_Vec2(pix);
            return ret;
        }
        public static ImPlot3DRay PixelsToPlotRay(double x, double y)
        {
            ImPlot3DRay ret = ImPlot3DNative.ImPlot3D_PixelsToPlotRay_double(x, y);
            return ret;
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotDummy(ReadOnlySpan<char> label_id)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            ImPlot3DNative.ImPlot3D_PlotDummy(native_label_id, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#endif
        public static void PlotDummy(string label_id)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            ImPlot3DNative.ImPlot3D_PlotDummy(native_label_id, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotDummy(ReadOnlySpan<char> label_id, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DNative.ImPlot3D_PlotDummy(native_label_id, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#endif
        public static void PlotDummy(string label_id, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DNative.ImPlot3D_PlotDummy(native_label_id, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotImage(ReadOnlySpan<char> label_id, ImTextureRef tex_ref, ImPlot3DPoint center, ImPlot3DPoint axis_u, ImPlot3DPoint axis_v)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            Vector2 uv0 = new Vector2();
            Vector2 uv1 = new Vector2(1, 1);
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            ImPlot3DSpec spec = new ImPlot3DSpec();
            ImPlot3DNative.ImPlot3D_PlotImage_Vec2(native_label_id, tex_ref, center, axis_u, axis_v, uv0, uv1, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#endif
        public static void PlotImage(string label_id, ImTextureRef tex_ref, ImPlot3DPoint center, ImPlot3DPoint axis_u, ImPlot3DPoint axis_v)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            Vector2 uv0 = new Vector2();
            Vector2 uv1 = new Vector2(1, 1);
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            ImPlot3DSpec spec = new ImPlot3DSpec();
            ImPlot3DNative.ImPlot3D_PlotImage_Vec2(native_label_id, tex_ref, center, axis_u, axis_v, uv0, uv1, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotImage(ReadOnlySpan<char> label_id, ImTextureRef tex_ref, ImPlot3DPoint center, ImPlot3DPoint axis_u, ImPlot3DPoint axis_v, Vector2 uv0)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            Vector2 uv1 = new Vector2(1, 1);
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            ImPlot3DSpec spec = new ImPlot3DSpec();
            ImPlot3DNative.ImPlot3D_PlotImage_Vec2(native_label_id, tex_ref, center, axis_u, axis_v, uv0, uv1, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#endif
        public static void PlotImage(string label_id, ImTextureRef tex_ref, ImPlot3DPoint center, ImPlot3DPoint axis_u, ImPlot3DPoint axis_v, Vector2 uv0)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            Vector2 uv1 = new Vector2(1, 1);
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            ImPlot3DSpec spec = new ImPlot3DSpec();
            ImPlot3DNative.ImPlot3D_PlotImage_Vec2(native_label_id, tex_ref, center, axis_u, axis_v, uv0, uv1, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotImage(ReadOnlySpan<char> label_id, ImTextureRef tex_ref, ImPlot3DPoint center, ImPlot3DPoint axis_u, ImPlot3DPoint axis_v, Vector2 uv0, Vector2 uv1)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            ImPlot3DSpec spec = new ImPlot3DSpec();
            ImPlot3DNative.ImPlot3D_PlotImage_Vec2(native_label_id, tex_ref, center, axis_u, axis_v, uv0, uv1, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#endif
        public static void PlotImage(string label_id, ImTextureRef tex_ref, ImPlot3DPoint center, ImPlot3DPoint axis_u, ImPlot3DPoint axis_v, Vector2 uv0, Vector2 uv1)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            ImPlot3DSpec spec = new ImPlot3DSpec();
            ImPlot3DNative.ImPlot3D_PlotImage_Vec2(native_label_id, tex_ref, center, axis_u, axis_v, uv0, uv1, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotImage(ReadOnlySpan<char> label_id, ImTextureRef tex_ref, ImPlot3DPoint center, ImPlot3DPoint axis_u, ImPlot3DPoint axis_v, Vector2 uv0, Vector2 uv1, Vector4 tint_col)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            ImPlot3DNative.ImPlot3D_PlotImage_Vec2(native_label_id, tex_ref, center, axis_u, axis_v, uv0, uv1, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#endif
        public static void PlotImage(string label_id, ImTextureRef tex_ref, ImPlot3DPoint center, ImPlot3DPoint axis_u, ImPlot3DPoint axis_v, Vector2 uv0, Vector2 uv1, Vector4 tint_col)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            ImPlot3DNative.ImPlot3D_PlotImage_Vec2(native_label_id, tex_ref, center, axis_u, axis_v, uv0, uv1, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotImage(ReadOnlySpan<char> label_id, ImTextureRef tex_ref, ImPlot3DPoint center, ImPlot3DPoint axis_u, ImPlot3DPoint axis_v, Vector2 uv0, Vector2 uv1, Vector4 tint_col, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DNative.ImPlot3D_PlotImage_Vec2(native_label_id, tex_ref, center, axis_u, axis_v, uv0, uv1, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#endif
        public static void PlotImage(string label_id, ImTextureRef tex_ref, ImPlot3DPoint center, ImPlot3DPoint axis_u, ImPlot3DPoint axis_v, Vector2 uv0, Vector2 uv1, Vector4 tint_col, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DNative.ImPlot3D_PlotImage_Vec2(native_label_id, tex_ref, center, axis_u, axis_v, uv0, uv1, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotImage(ReadOnlySpan<char> label_id, ImTextureRef tex_ref, ImPlot3DPoint p0, ImPlot3DPoint p1, ImPlot3DPoint p2, ImPlot3DPoint p3)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            Vector2 uv0 = new Vector2();
            Vector2 uv1 = new Vector2(1, 0);
            Vector2 uv2 = new Vector2(1, 1);
            Vector2 uv3 = new Vector2(0, 1);
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            ImPlot3DSpec spec = new ImPlot3DSpec();
            ImPlot3DNative.ImPlot3D_PlotImage_Plot3DPoint(native_label_id, tex_ref, p0, p1, p2, p3, uv0, uv1, uv2, uv3, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#endif
        public static void PlotImage(string label_id, ImTextureRef tex_ref, ImPlot3DPoint p0, ImPlot3DPoint p1, ImPlot3DPoint p2, ImPlot3DPoint p3)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            Vector2 uv0 = new Vector2();
            Vector2 uv1 = new Vector2(1, 0);
            Vector2 uv2 = new Vector2(1, 1);
            Vector2 uv3 = new Vector2(0, 1);
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            ImPlot3DSpec spec = new ImPlot3DSpec();
            ImPlot3DNative.ImPlot3D_PlotImage_Plot3DPoint(native_label_id, tex_ref, p0, p1, p2, p3, uv0, uv1, uv2, uv3, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotImage(ReadOnlySpan<char> label_id, ImTextureRef tex_ref, ImPlot3DPoint p0, ImPlot3DPoint p1, ImPlot3DPoint p2, ImPlot3DPoint p3, Vector2 uv0)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            Vector2 uv1 = new Vector2(1, 0);
            Vector2 uv2 = new Vector2(1, 1);
            Vector2 uv3 = new Vector2(0, 1);
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            ImPlot3DSpec spec = new ImPlot3DSpec();
            ImPlot3DNative.ImPlot3D_PlotImage_Plot3DPoint(native_label_id, tex_ref, p0, p1, p2, p3, uv0, uv1, uv2, uv3, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#endif
        public static void PlotImage(string label_id, ImTextureRef tex_ref, ImPlot3DPoint p0, ImPlot3DPoint p1, ImPlot3DPoint p2, ImPlot3DPoint p3, Vector2 uv0)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            Vector2 uv1 = new Vector2(1, 0);
            Vector2 uv2 = new Vector2(1, 1);
            Vector2 uv3 = new Vector2(0, 1);
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            ImPlot3DSpec spec = new ImPlot3DSpec();
            ImPlot3DNative.ImPlot3D_PlotImage_Plot3DPoint(native_label_id, tex_ref, p0, p1, p2, p3, uv0, uv1, uv2, uv3, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotImage(ReadOnlySpan<char> label_id, ImTextureRef tex_ref, ImPlot3DPoint p0, ImPlot3DPoint p1, ImPlot3DPoint p2, ImPlot3DPoint p3, Vector2 uv0, Vector2 uv1)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            Vector2 uv2 = new Vector2(1, 1);
            Vector2 uv3 = new Vector2(0, 1);
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            ImPlot3DSpec spec = new ImPlot3DSpec();
            ImPlot3DNative.ImPlot3D_PlotImage_Plot3DPoint(native_label_id, tex_ref, p0, p1, p2, p3, uv0, uv1, uv2, uv3, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#endif
        public static void PlotImage(string label_id, ImTextureRef tex_ref, ImPlot3DPoint p0, ImPlot3DPoint p1, ImPlot3DPoint p2, ImPlot3DPoint p3, Vector2 uv0, Vector2 uv1)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            Vector2 uv2 = new Vector2(1, 1);
            Vector2 uv3 = new Vector2(0, 1);
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            ImPlot3DSpec spec = new ImPlot3DSpec();
            ImPlot3DNative.ImPlot3D_PlotImage_Plot3DPoint(native_label_id, tex_ref, p0, p1, p2, p3, uv0, uv1, uv2, uv3, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotImage(ReadOnlySpan<char> label_id, ImTextureRef tex_ref, ImPlot3DPoint p0, ImPlot3DPoint p1, ImPlot3DPoint p2, ImPlot3DPoint p3, Vector2 uv0, Vector2 uv1, Vector2 uv2)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            Vector2 uv3 = new Vector2(0, 1);
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            ImPlot3DSpec spec = new ImPlot3DSpec();
            ImPlot3DNative.ImPlot3D_PlotImage_Plot3DPoint(native_label_id, tex_ref, p0, p1, p2, p3, uv0, uv1, uv2, uv3, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#endif
        public static void PlotImage(string label_id, ImTextureRef tex_ref, ImPlot3DPoint p0, ImPlot3DPoint p1, ImPlot3DPoint p2, ImPlot3DPoint p3, Vector2 uv0, Vector2 uv1, Vector2 uv2)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            Vector2 uv3 = new Vector2(0, 1);
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            ImPlot3DSpec spec = new ImPlot3DSpec();
            ImPlot3DNative.ImPlot3D_PlotImage_Plot3DPoint(native_label_id, tex_ref, p0, p1, p2, p3, uv0, uv1, uv2, uv3, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotImage(ReadOnlySpan<char> label_id, ImTextureRef tex_ref, ImPlot3DPoint p0, ImPlot3DPoint p1, ImPlot3DPoint p2, ImPlot3DPoint p3, Vector2 uv0, Vector2 uv1, Vector2 uv2, Vector2 uv3)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            ImPlot3DSpec spec = new ImPlot3DSpec();
            ImPlot3DNative.ImPlot3D_PlotImage_Plot3DPoint(native_label_id, tex_ref, p0, p1, p2, p3, uv0, uv1, uv2, uv3, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#endif
        public static void PlotImage(string label_id, ImTextureRef tex_ref, ImPlot3DPoint p0, ImPlot3DPoint p1, ImPlot3DPoint p2, ImPlot3DPoint p3, Vector2 uv0, Vector2 uv1, Vector2 uv2, Vector2 uv3)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            Vector4 tint_col = new Vector4(1, 1, 1, 1);
            ImPlot3DSpec spec = new ImPlot3DSpec();
            ImPlot3DNative.ImPlot3D_PlotImage_Plot3DPoint(native_label_id, tex_ref, p0, p1, p2, p3, uv0, uv1, uv2, uv3, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotImage(ReadOnlySpan<char> label_id, ImTextureRef tex_ref, ImPlot3DPoint p0, ImPlot3DPoint p1, ImPlot3DPoint p2, ImPlot3DPoint p3, Vector2 uv0, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector4 tint_col)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            ImPlot3DNative.ImPlot3D_PlotImage_Plot3DPoint(native_label_id, tex_ref, p0, p1, p2, p3, uv0, uv1, uv2, uv3, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#endif
        public static void PlotImage(string label_id, ImTextureRef tex_ref, ImPlot3DPoint p0, ImPlot3DPoint p1, ImPlot3DPoint p2, ImPlot3DPoint p3, Vector2 uv0, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector4 tint_col)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            ImPlot3DNative.ImPlot3D_PlotImage_Plot3DPoint(native_label_id, tex_ref, p0, p1, p2, p3, uv0, uv1, uv2, uv3, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotImage(ReadOnlySpan<char> label_id, ImTextureRef tex_ref, ImPlot3DPoint p0, ImPlot3DPoint p1, ImPlot3DPoint p2, ImPlot3DPoint p3, Vector2 uv0, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector4 tint_col, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DNative.ImPlot3D_PlotImage_Plot3DPoint(native_label_id, tex_ref, p0, p1, p2, p3, uv0, uv1, uv2, uv3, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#endif
        public static void PlotImage(string label_id, ImTextureRef tex_ref, ImPlot3DPoint p0, ImPlot3DPoint p1, ImPlot3DPoint p2, ImPlot3DPoint p3, Vector2 uv0, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector4 tint_col, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DNative.ImPlot3D_PlotImage_Plot3DPoint(native_label_id, tex_ref, p0, p1, p2, p3, uv0, uv1, uv2, uv3, tint_col, spec);
            if (label_id_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label_id);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotLine(ReadOnlySpan<char> label_id, ref float xs, ref float ys, ref float zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_FloatPtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotLine(string label_id, ref float xs, ref float ys, ref float zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_FloatPtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotLine(ReadOnlySpan<char> label_id, ref float xs, ref float ys, ref float zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_FloatPtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotLine(string label_id, ref float xs, ref float ys, ref float zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_FloatPtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotLine(ReadOnlySpan<char> label_id, ref double xs, ref double ys, ref double zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_doublePtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotLine(string label_id, ref double xs, ref double ys, ref double zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_doublePtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotLine(ReadOnlySpan<char> label_id, ref double xs, ref double ys, ref double zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_doublePtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotLine(string label_id, ref double xs, ref double ys, ref double zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_doublePtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotLine(ReadOnlySpan<char> label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_S8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotLine(string label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_S8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotLine(ReadOnlySpan<char> label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_S8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotLine(string label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_S8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotLine(ReadOnlySpan<char> label_id, ref byte xs, ref byte ys, ref byte zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_U8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotLine(string label_id, ref byte xs, ref byte ys, ref byte zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_U8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotLine(ReadOnlySpan<char> label_id, ref byte xs, ref byte ys, ref byte zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_U8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotLine(string label_id, ref byte xs, ref byte ys, ref byte zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_U8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotLine(ReadOnlySpan<char> label_id, ref short xs, ref short ys, ref short zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_S16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotLine(string label_id, ref short xs, ref short ys, ref short zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_S16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotLine(ReadOnlySpan<char> label_id, ref short xs, ref short ys, ref short zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_S16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotLine(string label_id, ref short xs, ref short ys, ref short zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_S16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotLine(ReadOnlySpan<char> label_id, ref ushort xs, ref ushort ys, ref ushort zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_U16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotLine(string label_id, ref ushort xs, ref ushort ys, ref ushort zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_U16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotLine(ReadOnlySpan<char> label_id, ref ushort xs, ref ushort ys, ref ushort zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_U16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotLine(string label_id, ref ushort xs, ref ushort ys, ref ushort zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_U16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotLine(ReadOnlySpan<char> label_id, ref int xs, ref int ys, ref int zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_S32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotLine(string label_id, ref int xs, ref int ys, ref int zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_S32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotLine(ReadOnlySpan<char> label_id, ref int xs, ref int ys, ref int zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_S32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotLine(string label_id, ref int xs, ref int ys, ref int zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_S32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotLine(ReadOnlySpan<char> label_id, ref uint xs, ref uint ys, ref uint zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_U32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotLine(string label_id, ref uint xs, ref uint ys, ref uint zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_U32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotLine(ReadOnlySpan<char> label_id, ref uint xs, ref uint ys, ref uint zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_U32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotLine(string label_id, ref uint xs, ref uint ys, ref uint zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_U32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotLine(ReadOnlySpan<char> label_id, ref long xs, ref long ys, ref long zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_S64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotLine(string label_id, ref long xs, ref long ys, ref long zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_S64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotLine(ReadOnlySpan<char> label_id, ref long xs, ref long ys, ref long zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_S64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotLine(string label_id, ref long xs, ref long ys, ref long zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_S64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotLine(ReadOnlySpan<char> label_id, ref ulong xs, ref ulong ys, ref ulong zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_U64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotLine(string label_id, ref ulong xs, ref ulong ys, ref ulong zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_U64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotLine(ReadOnlySpan<char> label_id, ref ulong xs, ref ulong ys, ref ulong zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_U64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotLine(string label_id, ref ulong xs, ref ulong ys, ref ulong zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotLine_U64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotMesh(ReadOnlySpan<char> label_id, ref float vtx_xs, ref float vtx_ys, ref float vtx_zs, ref uint idxs, int vtx_count, int idx_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (float* native_vtx_xs = &vtx_xs)
            {
                fixed (float* native_vtx_ys = &vtx_ys)
                {
                    fixed (float* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_FloatPtr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#endif
        public static void PlotMesh(string label_id, ref float vtx_xs, ref float vtx_ys, ref float vtx_zs, ref uint idxs, int vtx_count, int idx_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (float* native_vtx_xs = &vtx_xs)
            {
                fixed (float* native_vtx_ys = &vtx_ys)
                {
                    fixed (float* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_FloatPtr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotMesh(ReadOnlySpan<char> label_id, ref float vtx_xs, ref float vtx_ys, ref float vtx_zs, ref uint idxs, int vtx_count, int idx_count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (float* native_vtx_xs = &vtx_xs)
            {
                fixed (float* native_vtx_ys = &vtx_ys)
                {
                    fixed (float* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_FloatPtr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#endif
        public static void PlotMesh(string label_id, ref float vtx_xs, ref float vtx_ys, ref float vtx_zs, ref uint idxs, int vtx_count, int idx_count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (float* native_vtx_xs = &vtx_xs)
            {
                fixed (float* native_vtx_ys = &vtx_ys)
                {
                    fixed (float* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_FloatPtr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotMesh(ReadOnlySpan<char> label_id, ref double vtx_xs, ref double vtx_ys, ref double vtx_zs, ref uint idxs, int vtx_count, int idx_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (double* native_vtx_xs = &vtx_xs)
            {
                fixed (double* native_vtx_ys = &vtx_ys)
                {
                    fixed (double* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_doublePtr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#endif
        public static void PlotMesh(string label_id, ref double vtx_xs, ref double vtx_ys, ref double vtx_zs, ref uint idxs, int vtx_count, int idx_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (double* native_vtx_xs = &vtx_xs)
            {
                fixed (double* native_vtx_ys = &vtx_ys)
                {
                    fixed (double* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_doublePtr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotMesh(ReadOnlySpan<char> label_id, ref double vtx_xs, ref double vtx_ys, ref double vtx_zs, ref uint idxs, int vtx_count, int idx_count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (double* native_vtx_xs = &vtx_xs)
            {
                fixed (double* native_vtx_ys = &vtx_ys)
                {
                    fixed (double* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_doublePtr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#endif
        public static void PlotMesh(string label_id, ref double vtx_xs, ref double vtx_ys, ref double vtx_zs, ref uint idxs, int vtx_count, int idx_count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (double* native_vtx_xs = &vtx_xs)
            {
                fixed (double* native_vtx_ys = &vtx_ys)
                {
                    fixed (double* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_doublePtr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotMesh(ReadOnlySpan<char> label_id, ref sbyte vtx_xs, ref sbyte vtx_ys, ref sbyte vtx_zs, ref uint idxs, int vtx_count, int idx_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (sbyte* native_vtx_xs = &vtx_xs)
            {
                fixed (sbyte* native_vtx_ys = &vtx_ys)
                {
                    fixed (sbyte* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_S8Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#endif
        public static void PlotMesh(string label_id, ref sbyte vtx_xs, ref sbyte vtx_ys, ref sbyte vtx_zs, ref uint idxs, int vtx_count, int idx_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (sbyte* native_vtx_xs = &vtx_xs)
            {
                fixed (sbyte* native_vtx_ys = &vtx_ys)
                {
                    fixed (sbyte* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_S8Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotMesh(ReadOnlySpan<char> label_id, ref sbyte vtx_xs, ref sbyte vtx_ys, ref sbyte vtx_zs, ref uint idxs, int vtx_count, int idx_count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (sbyte* native_vtx_xs = &vtx_xs)
            {
                fixed (sbyte* native_vtx_ys = &vtx_ys)
                {
                    fixed (sbyte* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_S8Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#endif
        public static void PlotMesh(string label_id, ref sbyte vtx_xs, ref sbyte vtx_ys, ref sbyte vtx_zs, ref uint idxs, int vtx_count, int idx_count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (sbyte* native_vtx_xs = &vtx_xs)
            {
                fixed (sbyte* native_vtx_ys = &vtx_ys)
                {
                    fixed (sbyte* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_S8Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotMesh(ReadOnlySpan<char> label_id, ref byte vtx_xs, ref byte vtx_ys, ref byte vtx_zs, ref uint idxs, int vtx_count, int idx_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (byte* native_vtx_xs = &vtx_xs)
            {
                fixed (byte* native_vtx_ys = &vtx_ys)
                {
                    fixed (byte* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_U8Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#endif
        public static void PlotMesh(string label_id, ref byte vtx_xs, ref byte vtx_ys, ref byte vtx_zs, ref uint idxs, int vtx_count, int idx_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (byte* native_vtx_xs = &vtx_xs)
            {
                fixed (byte* native_vtx_ys = &vtx_ys)
                {
                    fixed (byte* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_U8Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotMesh(ReadOnlySpan<char> label_id, ref byte vtx_xs, ref byte vtx_ys, ref byte vtx_zs, ref uint idxs, int vtx_count, int idx_count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (byte* native_vtx_xs = &vtx_xs)
            {
                fixed (byte* native_vtx_ys = &vtx_ys)
                {
                    fixed (byte* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_U8Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#endif
        public static void PlotMesh(string label_id, ref byte vtx_xs, ref byte vtx_ys, ref byte vtx_zs, ref uint idxs, int vtx_count, int idx_count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (byte* native_vtx_xs = &vtx_xs)
            {
                fixed (byte* native_vtx_ys = &vtx_ys)
                {
                    fixed (byte* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_U8Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotMesh(ReadOnlySpan<char> label_id, ref short vtx_xs, ref short vtx_ys, ref short vtx_zs, ref uint idxs, int vtx_count, int idx_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (short* native_vtx_xs = &vtx_xs)
            {
                fixed (short* native_vtx_ys = &vtx_ys)
                {
                    fixed (short* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_S16Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#endif
        public static void PlotMesh(string label_id, ref short vtx_xs, ref short vtx_ys, ref short vtx_zs, ref uint idxs, int vtx_count, int idx_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (short* native_vtx_xs = &vtx_xs)
            {
                fixed (short* native_vtx_ys = &vtx_ys)
                {
                    fixed (short* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_S16Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotMesh(ReadOnlySpan<char> label_id, ref short vtx_xs, ref short vtx_ys, ref short vtx_zs, ref uint idxs, int vtx_count, int idx_count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (short* native_vtx_xs = &vtx_xs)
            {
                fixed (short* native_vtx_ys = &vtx_ys)
                {
                    fixed (short* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_S16Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#endif
        public static void PlotMesh(string label_id, ref short vtx_xs, ref short vtx_ys, ref short vtx_zs, ref uint idxs, int vtx_count, int idx_count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (short* native_vtx_xs = &vtx_xs)
            {
                fixed (short* native_vtx_ys = &vtx_ys)
                {
                    fixed (short* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_S16Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotMesh(ReadOnlySpan<char> label_id, ref ushort vtx_xs, ref ushort vtx_ys, ref ushort vtx_zs, ref uint idxs, int vtx_count, int idx_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ushort* native_vtx_xs = &vtx_xs)
            {
                fixed (ushort* native_vtx_ys = &vtx_ys)
                {
                    fixed (ushort* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_U16Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#endif
        public static void PlotMesh(string label_id, ref ushort vtx_xs, ref ushort vtx_ys, ref ushort vtx_zs, ref uint idxs, int vtx_count, int idx_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ushort* native_vtx_xs = &vtx_xs)
            {
                fixed (ushort* native_vtx_ys = &vtx_ys)
                {
                    fixed (ushort* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_U16Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotMesh(ReadOnlySpan<char> label_id, ref ushort vtx_xs, ref ushort vtx_ys, ref ushort vtx_zs, ref uint idxs, int vtx_count, int idx_count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ushort* native_vtx_xs = &vtx_xs)
            {
                fixed (ushort* native_vtx_ys = &vtx_ys)
                {
                    fixed (ushort* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_U16Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#endif
        public static void PlotMesh(string label_id, ref ushort vtx_xs, ref ushort vtx_ys, ref ushort vtx_zs, ref uint idxs, int vtx_count, int idx_count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ushort* native_vtx_xs = &vtx_xs)
            {
                fixed (ushort* native_vtx_ys = &vtx_ys)
                {
                    fixed (ushort* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_U16Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotMesh(ReadOnlySpan<char> label_id, ref int vtx_xs, ref int vtx_ys, ref int vtx_zs, ref uint idxs, int vtx_count, int idx_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (int* native_vtx_xs = &vtx_xs)
            {
                fixed (int* native_vtx_ys = &vtx_ys)
                {
                    fixed (int* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_S32Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#endif
        public static void PlotMesh(string label_id, ref int vtx_xs, ref int vtx_ys, ref int vtx_zs, ref uint idxs, int vtx_count, int idx_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (int* native_vtx_xs = &vtx_xs)
            {
                fixed (int* native_vtx_ys = &vtx_ys)
                {
                    fixed (int* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_S32Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotMesh(ReadOnlySpan<char> label_id, ref int vtx_xs, ref int vtx_ys, ref int vtx_zs, ref uint idxs, int vtx_count, int idx_count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (int* native_vtx_xs = &vtx_xs)
            {
                fixed (int* native_vtx_ys = &vtx_ys)
                {
                    fixed (int* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_S32Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#endif
        public static void PlotMesh(string label_id, ref int vtx_xs, ref int vtx_ys, ref int vtx_zs, ref uint idxs, int vtx_count, int idx_count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (int* native_vtx_xs = &vtx_xs)
            {
                fixed (int* native_vtx_ys = &vtx_ys)
                {
                    fixed (int* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_S32Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotMesh(ReadOnlySpan<char> label_id, ref uint vtx_xs, ref uint vtx_ys, ref uint vtx_zs, ref uint idxs, int vtx_count, int idx_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (uint* native_vtx_xs = &vtx_xs)
            {
                fixed (uint* native_vtx_ys = &vtx_ys)
                {
                    fixed (uint* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_U32Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#endif
        public static void PlotMesh(string label_id, ref uint vtx_xs, ref uint vtx_ys, ref uint vtx_zs, ref uint idxs, int vtx_count, int idx_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (uint* native_vtx_xs = &vtx_xs)
            {
                fixed (uint* native_vtx_ys = &vtx_ys)
                {
                    fixed (uint* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_U32Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotMesh(ReadOnlySpan<char> label_id, ref uint vtx_xs, ref uint vtx_ys, ref uint vtx_zs, ref uint idxs, int vtx_count, int idx_count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (uint* native_vtx_xs = &vtx_xs)
            {
                fixed (uint* native_vtx_ys = &vtx_ys)
                {
                    fixed (uint* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_U32Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#endif
        public static void PlotMesh(string label_id, ref uint vtx_xs, ref uint vtx_ys, ref uint vtx_zs, ref uint idxs, int vtx_count, int idx_count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (uint* native_vtx_xs = &vtx_xs)
            {
                fixed (uint* native_vtx_ys = &vtx_ys)
                {
                    fixed (uint* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_U32Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotMesh(ReadOnlySpan<char> label_id, ref long vtx_xs, ref long vtx_ys, ref long vtx_zs, ref uint idxs, int vtx_count, int idx_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (long* native_vtx_xs = &vtx_xs)
            {
                fixed (long* native_vtx_ys = &vtx_ys)
                {
                    fixed (long* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_S64Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#endif
        public static void PlotMesh(string label_id, ref long vtx_xs, ref long vtx_ys, ref long vtx_zs, ref uint idxs, int vtx_count, int idx_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (long* native_vtx_xs = &vtx_xs)
            {
                fixed (long* native_vtx_ys = &vtx_ys)
                {
                    fixed (long* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_S64Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotMesh(ReadOnlySpan<char> label_id, ref long vtx_xs, ref long vtx_ys, ref long vtx_zs, ref uint idxs, int vtx_count, int idx_count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (long* native_vtx_xs = &vtx_xs)
            {
                fixed (long* native_vtx_ys = &vtx_ys)
                {
                    fixed (long* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_S64Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#endif
        public static void PlotMesh(string label_id, ref long vtx_xs, ref long vtx_ys, ref long vtx_zs, ref uint idxs, int vtx_count, int idx_count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (long* native_vtx_xs = &vtx_xs)
            {
                fixed (long* native_vtx_ys = &vtx_ys)
                {
                    fixed (long* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_S64Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotMesh(ReadOnlySpan<char> label_id, ref ulong vtx_xs, ref ulong vtx_ys, ref ulong vtx_zs, ref uint idxs, int vtx_count, int idx_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ulong* native_vtx_xs = &vtx_xs)
            {
                fixed (ulong* native_vtx_ys = &vtx_ys)
                {
                    fixed (ulong* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_U64Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#endif
        public static void PlotMesh(string label_id, ref ulong vtx_xs, ref ulong vtx_ys, ref ulong vtx_zs, ref uint idxs, int vtx_count, int idx_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ulong* native_vtx_xs = &vtx_xs)
            {
                fixed (ulong* native_vtx_ys = &vtx_ys)
                {
                    fixed (ulong* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_U64Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotMesh(ReadOnlySpan<char> label_id, ref ulong vtx_xs, ref ulong vtx_ys, ref ulong vtx_zs, ref uint idxs, int vtx_count, int idx_count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ulong* native_vtx_xs = &vtx_xs)
            {
                fixed (ulong* native_vtx_ys = &vtx_ys)
                {
                    fixed (ulong* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_U64Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#endif
        public static void PlotMesh(string label_id, ref ulong vtx_xs, ref ulong vtx_ys, ref ulong vtx_zs, ref uint idxs, int vtx_count, int idx_count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ulong* native_vtx_xs = &vtx_xs)
            {
                fixed (ulong* native_vtx_ys = &vtx_ys)
                {
                    fixed (ulong* native_vtx_zs = &vtx_zs)
                    {
                        fixed (uint* native_idxs = &idxs)
                        {
                            ImPlot3DNative.ImPlot3D_PlotMesh_U64Ptr(native_label_id, native_vtx_xs, native_vtx_ys, native_vtx_zs, native_idxs, vtx_count, idx_count, spec);
                            if (label_id_byteCount > Util.StackAllocationSizeLimit)
                            {
                                Util.Free(native_label_id);
                            }
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotQuad(ReadOnlySpan<char> label_id, ref float xs, ref float ys, ref float zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_FloatPtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotQuad(string label_id, ref float xs, ref float ys, ref float zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_FloatPtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotQuad(ReadOnlySpan<char> label_id, ref float xs, ref float ys, ref float zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_FloatPtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotQuad(string label_id, ref float xs, ref float ys, ref float zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_FloatPtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotQuad(ReadOnlySpan<char> label_id, ref double xs, ref double ys, ref double zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_doublePtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotQuad(string label_id, ref double xs, ref double ys, ref double zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_doublePtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotQuad(ReadOnlySpan<char> label_id, ref double xs, ref double ys, ref double zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_doublePtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotQuad(string label_id, ref double xs, ref double ys, ref double zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_doublePtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotQuad(ReadOnlySpan<char> label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_S8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotQuad(string label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_S8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotQuad(ReadOnlySpan<char> label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_S8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotQuad(string label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_S8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotQuad(ReadOnlySpan<char> label_id, ref byte xs, ref byte ys, ref byte zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_U8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotQuad(string label_id, ref byte xs, ref byte ys, ref byte zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_U8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotQuad(ReadOnlySpan<char> label_id, ref byte xs, ref byte ys, ref byte zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_U8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotQuad(string label_id, ref byte xs, ref byte ys, ref byte zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_U8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotQuad(ReadOnlySpan<char> label_id, ref short xs, ref short ys, ref short zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_S16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotQuad(string label_id, ref short xs, ref short ys, ref short zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_S16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotQuad(ReadOnlySpan<char> label_id, ref short xs, ref short ys, ref short zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_S16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotQuad(string label_id, ref short xs, ref short ys, ref short zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_S16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotQuad(ReadOnlySpan<char> label_id, ref ushort xs, ref ushort ys, ref ushort zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_U16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotQuad(string label_id, ref ushort xs, ref ushort ys, ref ushort zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_U16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotQuad(ReadOnlySpan<char> label_id, ref ushort xs, ref ushort ys, ref ushort zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_U16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotQuad(string label_id, ref ushort xs, ref ushort ys, ref ushort zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_U16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotQuad(ReadOnlySpan<char> label_id, ref int xs, ref int ys, ref int zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_S32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotQuad(string label_id, ref int xs, ref int ys, ref int zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_S32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotQuad(ReadOnlySpan<char> label_id, ref int xs, ref int ys, ref int zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_S32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotQuad(string label_id, ref int xs, ref int ys, ref int zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_S32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotQuad(ReadOnlySpan<char> label_id, ref uint xs, ref uint ys, ref uint zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_U32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotQuad(string label_id, ref uint xs, ref uint ys, ref uint zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_U32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotQuad(ReadOnlySpan<char> label_id, ref uint xs, ref uint ys, ref uint zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_U32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotQuad(string label_id, ref uint xs, ref uint ys, ref uint zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_U32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotQuad(ReadOnlySpan<char> label_id, ref long xs, ref long ys, ref long zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_S64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotQuad(string label_id, ref long xs, ref long ys, ref long zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_S64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotQuad(ReadOnlySpan<char> label_id, ref long xs, ref long ys, ref long zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_S64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotQuad(string label_id, ref long xs, ref long ys, ref long zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_S64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotQuad(ReadOnlySpan<char> label_id, ref ulong xs, ref ulong ys, ref ulong zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_U64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotQuad(string label_id, ref ulong xs, ref ulong ys, ref ulong zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_U64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotQuad(ReadOnlySpan<char> label_id, ref ulong xs, ref ulong ys, ref ulong zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_U64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotQuad(string label_id, ref ulong xs, ref ulong ys, ref ulong zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotQuad_U64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotScatter(ReadOnlySpan<char> label_id, ref float xs, ref float ys, ref float zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_FloatPtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotScatter(string label_id, ref float xs, ref float ys, ref float zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_FloatPtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotScatter(ReadOnlySpan<char> label_id, ref float xs, ref float ys, ref float zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_FloatPtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotScatter(string label_id, ref float xs, ref float ys, ref float zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_FloatPtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotScatter(ReadOnlySpan<char> label_id, ref double xs, ref double ys, ref double zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_doublePtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotScatter(string label_id, ref double xs, ref double ys, ref double zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_doublePtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotScatter(ReadOnlySpan<char> label_id, ref double xs, ref double ys, ref double zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_doublePtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotScatter(string label_id, ref double xs, ref double ys, ref double zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_doublePtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotScatter(ReadOnlySpan<char> label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_S8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotScatter(string label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_S8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotScatter(ReadOnlySpan<char> label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_S8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotScatter(string label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_S8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotScatter(ReadOnlySpan<char> label_id, ref byte xs, ref byte ys, ref byte zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_U8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotScatter(string label_id, ref byte xs, ref byte ys, ref byte zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_U8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotScatter(ReadOnlySpan<char> label_id, ref byte xs, ref byte ys, ref byte zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_U8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotScatter(string label_id, ref byte xs, ref byte ys, ref byte zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_U8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotScatter(ReadOnlySpan<char> label_id, ref short xs, ref short ys, ref short zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_S16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotScatter(string label_id, ref short xs, ref short ys, ref short zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_S16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotScatter(ReadOnlySpan<char> label_id, ref short xs, ref short ys, ref short zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_S16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotScatter(string label_id, ref short xs, ref short ys, ref short zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_S16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotScatter(ReadOnlySpan<char> label_id, ref ushort xs, ref ushort ys, ref ushort zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_U16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotScatter(string label_id, ref ushort xs, ref ushort ys, ref ushort zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_U16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotScatter(ReadOnlySpan<char> label_id, ref ushort xs, ref ushort ys, ref ushort zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_U16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotScatter(string label_id, ref ushort xs, ref ushort ys, ref ushort zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_U16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotScatter(ReadOnlySpan<char> label_id, ref int xs, ref int ys, ref int zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_S32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotScatter(string label_id, ref int xs, ref int ys, ref int zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_S32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotScatter(ReadOnlySpan<char> label_id, ref int xs, ref int ys, ref int zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_S32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotScatter(string label_id, ref int xs, ref int ys, ref int zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_S32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotScatter(ReadOnlySpan<char> label_id, ref uint xs, ref uint ys, ref uint zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_U32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotScatter(string label_id, ref uint xs, ref uint ys, ref uint zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_U32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotScatter(ReadOnlySpan<char> label_id, ref uint xs, ref uint ys, ref uint zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_U32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotScatter(string label_id, ref uint xs, ref uint ys, ref uint zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_U32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotScatter(ReadOnlySpan<char> label_id, ref long xs, ref long ys, ref long zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_S64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotScatter(string label_id, ref long xs, ref long ys, ref long zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_S64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotScatter(ReadOnlySpan<char> label_id, ref long xs, ref long ys, ref long zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_S64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotScatter(string label_id, ref long xs, ref long ys, ref long zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_S64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotScatter(ReadOnlySpan<char> label_id, ref ulong xs, ref ulong ys, ref ulong zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_U64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotScatter(string label_id, ref ulong xs, ref ulong ys, ref ulong zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_U64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotScatter(ReadOnlySpan<char> label_id, ref ulong xs, ref ulong ys, ref ulong zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_U64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotScatter(string label_id, ref ulong xs, ref ulong ys, ref ulong zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotScatter_U64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref float xs, ref float ys, ref float zs, int x_count, int y_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_min = 0.0;
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_FloatPtr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref float xs, ref float ys, ref float zs, int x_count, int y_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_min = 0.0;
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_FloatPtr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref float xs, ref float ys, ref float zs, int x_count, int y_count, double scale_min)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_FloatPtr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref float xs, ref float ys, ref float zs, int x_count, int y_count, double scale_min)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_FloatPtr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref float xs, ref float ys, ref float zs, int x_count, int y_count, double scale_min, double scale_max)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_FloatPtr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref float xs, ref float ys, ref float zs, int x_count, int y_count, double scale_min, double scale_max)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_FloatPtr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref float xs, ref float ys, ref float zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_FloatPtr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref float xs, ref float ys, ref float zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_FloatPtr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref double xs, ref double ys, ref double zs, int x_count, int y_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_min = 0.0;
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_doublePtr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref double xs, ref double ys, ref double zs, int x_count, int y_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_min = 0.0;
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_doublePtr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref double xs, ref double ys, ref double zs, int x_count, int y_count, double scale_min)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_doublePtr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref double xs, ref double ys, ref double zs, int x_count, int y_count, double scale_min)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_doublePtr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref double xs, ref double ys, ref double zs, int x_count, int y_count, double scale_min, double scale_max)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_doublePtr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref double xs, ref double ys, ref double zs, int x_count, int y_count, double scale_min, double scale_max)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_doublePtr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref double xs, ref double ys, ref double zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_doublePtr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref double xs, ref double ys, ref double zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_doublePtr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int x_count, int y_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_min = 0.0;
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S8Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int x_count, int y_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_min = 0.0;
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S8Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int x_count, int y_count, double scale_min)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S8Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int x_count, int y_count, double scale_min)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S8Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int x_count, int y_count, double scale_min, double scale_max)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S8Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int x_count, int y_count, double scale_min, double scale_max)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S8Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S8Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S8Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref byte xs, ref byte ys, ref byte zs, int x_count, int y_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_min = 0.0;
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U8Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref byte xs, ref byte ys, ref byte zs, int x_count, int y_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_min = 0.0;
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U8Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref byte xs, ref byte ys, ref byte zs, int x_count, int y_count, double scale_min)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U8Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref byte xs, ref byte ys, ref byte zs, int x_count, int y_count, double scale_min)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U8Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref byte xs, ref byte ys, ref byte zs, int x_count, int y_count, double scale_min, double scale_max)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U8Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref byte xs, ref byte ys, ref byte zs, int x_count, int y_count, double scale_min, double scale_max)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U8Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref byte xs, ref byte ys, ref byte zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U8Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref byte xs, ref byte ys, ref byte zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U8Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref short xs, ref short ys, ref short zs, int x_count, int y_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_min = 0.0;
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S16Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref short xs, ref short ys, ref short zs, int x_count, int y_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_min = 0.0;
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S16Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref short xs, ref short ys, ref short zs, int x_count, int y_count, double scale_min)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S16Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref short xs, ref short ys, ref short zs, int x_count, int y_count, double scale_min)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S16Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref short xs, ref short ys, ref short zs, int x_count, int y_count, double scale_min, double scale_max)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S16Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref short xs, ref short ys, ref short zs, int x_count, int y_count, double scale_min, double scale_max)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S16Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref short xs, ref short ys, ref short zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S16Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref short xs, ref short ys, ref short zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S16Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref ushort xs, ref ushort ys, ref ushort zs, int x_count, int y_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_min = 0.0;
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U16Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref ushort xs, ref ushort ys, ref ushort zs, int x_count, int y_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_min = 0.0;
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U16Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref ushort xs, ref ushort ys, ref ushort zs, int x_count, int y_count, double scale_min)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U16Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref ushort xs, ref ushort ys, ref ushort zs, int x_count, int y_count, double scale_min)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U16Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref ushort xs, ref ushort ys, ref ushort zs, int x_count, int y_count, double scale_min, double scale_max)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U16Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref ushort xs, ref ushort ys, ref ushort zs, int x_count, int y_count, double scale_min, double scale_max)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U16Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref ushort xs, ref ushort ys, ref ushort zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U16Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref ushort xs, ref ushort ys, ref ushort zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U16Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref int xs, ref int ys, ref int zs, int x_count, int y_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_min = 0.0;
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S32Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref int xs, ref int ys, ref int zs, int x_count, int y_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_min = 0.0;
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S32Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref int xs, ref int ys, ref int zs, int x_count, int y_count, double scale_min)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S32Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref int xs, ref int ys, ref int zs, int x_count, int y_count, double scale_min)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S32Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref int xs, ref int ys, ref int zs, int x_count, int y_count, double scale_min, double scale_max)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S32Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref int xs, ref int ys, ref int zs, int x_count, int y_count, double scale_min, double scale_max)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S32Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref int xs, ref int ys, ref int zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S32Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref int xs, ref int ys, ref int zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S32Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref uint xs, ref uint ys, ref uint zs, int x_count, int y_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_min = 0.0;
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U32Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref uint xs, ref uint ys, ref uint zs, int x_count, int y_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_min = 0.0;
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U32Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref uint xs, ref uint ys, ref uint zs, int x_count, int y_count, double scale_min)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U32Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref uint xs, ref uint ys, ref uint zs, int x_count, int y_count, double scale_min)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U32Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref uint xs, ref uint ys, ref uint zs, int x_count, int y_count, double scale_min, double scale_max)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U32Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref uint xs, ref uint ys, ref uint zs, int x_count, int y_count, double scale_min, double scale_max)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U32Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref uint xs, ref uint ys, ref uint zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U32Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref uint xs, ref uint ys, ref uint zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U32Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref long xs, ref long ys, ref long zs, int x_count, int y_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_min = 0.0;
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S64Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref long xs, ref long ys, ref long zs, int x_count, int y_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_min = 0.0;
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S64Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref long xs, ref long ys, ref long zs, int x_count, int y_count, double scale_min)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S64Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref long xs, ref long ys, ref long zs, int x_count, int y_count, double scale_min)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S64Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref long xs, ref long ys, ref long zs, int x_count, int y_count, double scale_min, double scale_max)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S64Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref long xs, ref long ys, ref long zs, int x_count, int y_count, double scale_min, double scale_max)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S64Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref long xs, ref long ys, ref long zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S64Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref long xs, ref long ys, ref long zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_S64Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref ulong xs, ref ulong ys, ref ulong zs, int x_count, int y_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_min = 0.0;
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U64Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref ulong xs, ref ulong ys, ref ulong zs, int x_count, int y_count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_min = 0.0;
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U64Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref ulong xs, ref ulong ys, ref ulong zs, int x_count, int y_count, double scale_min)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U64Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref ulong xs, ref ulong ys, ref ulong zs, int x_count, int y_count, double scale_min)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            double scale_max = 0.0;
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U64Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref ulong xs, ref ulong ys, ref ulong zs, int x_count, int y_count, double scale_min, double scale_max)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U64Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref ulong xs, ref ulong ys, ref ulong zs, int x_count, int y_count, double scale_min, double scale_max)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U64Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotSurface(ReadOnlySpan<char> label_id, ref ulong xs, ref ulong ys, ref ulong zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U64Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotSurface(string label_id, ref ulong xs, ref ulong ys, ref ulong zs, int x_count, int y_count, double scale_min, double scale_max, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotSurface_U64Ptr(native_label_id, native_xs, native_ys, native_zs, x_count, y_count, scale_min, scale_max, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotText(ReadOnlySpan<char> text, double x, double y, double z)
        {
            byte* native_text;
            int text_byteCount = 0;
            if (text != null)
            {
                text_byteCount = Encoding.UTF8.GetByteCount(text);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text = Util.Allocate(text_byteCount + 1);
                }
                else
                {
                    byte* native_text_stackBytes = stackalloc byte[text_byteCount + 1];
                    native_text = native_text_stackBytes;
                }
                int native_text_offset = Util.GetUtf8(text, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            else { native_text = null; }
            double angle = 0.0;
            Vector2 pix_offset = new Vector2();
            ImPlot3DNative.ImPlot3D_PlotText(native_text, x, y, z, angle, pix_offset);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
            }
        }
#endif
        public static void PlotText(string text, double x, double y, double z)
        {
            byte* native_text;
            int text_byteCount = 0;
            if (text != null)
            {
                text_byteCount = Encoding.UTF8.GetByteCount(text);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text = Util.Allocate(text_byteCount + 1);
                }
                else
                {
                    byte* native_text_stackBytes = stackalloc byte[text_byteCount + 1];
                    native_text = native_text_stackBytes;
                }
                int native_text_offset = Util.GetUtf8(text, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            else { native_text = null; }
            double angle = 0.0;
            Vector2 pix_offset = new Vector2();
            ImPlot3DNative.ImPlot3D_PlotText(native_text, x, y, z, angle, pix_offset);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotText(ReadOnlySpan<char> text, double x, double y, double z, double angle)
        {
            byte* native_text;
            int text_byteCount = 0;
            if (text != null)
            {
                text_byteCount = Encoding.UTF8.GetByteCount(text);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text = Util.Allocate(text_byteCount + 1);
                }
                else
                {
                    byte* native_text_stackBytes = stackalloc byte[text_byteCount + 1];
                    native_text = native_text_stackBytes;
                }
                int native_text_offset = Util.GetUtf8(text, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            else { native_text = null; }
            Vector2 pix_offset = new Vector2();
            ImPlot3DNative.ImPlot3D_PlotText(native_text, x, y, z, angle, pix_offset);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
            }
        }
#endif
        public static void PlotText(string text, double x, double y, double z, double angle)
        {
            byte* native_text;
            int text_byteCount = 0;
            if (text != null)
            {
                text_byteCount = Encoding.UTF8.GetByteCount(text);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text = Util.Allocate(text_byteCount + 1);
                }
                else
                {
                    byte* native_text_stackBytes = stackalloc byte[text_byteCount + 1];
                    native_text = native_text_stackBytes;
                }
                int native_text_offset = Util.GetUtf8(text, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            else { native_text = null; }
            Vector2 pix_offset = new Vector2();
            ImPlot3DNative.ImPlot3D_PlotText(native_text, x, y, z, angle, pix_offset);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotText(ReadOnlySpan<char> text, double x, double y, double z, double angle, Vector2 pix_offset)
        {
            byte* native_text;
            int text_byteCount = 0;
            if (text != null)
            {
                text_byteCount = Encoding.UTF8.GetByteCount(text);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text = Util.Allocate(text_byteCount + 1);
                }
                else
                {
                    byte* native_text_stackBytes = stackalloc byte[text_byteCount + 1];
                    native_text = native_text_stackBytes;
                }
                int native_text_offset = Util.GetUtf8(text, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            else { native_text = null; }
            ImPlot3DNative.ImPlot3D_PlotText(native_text, x, y, z, angle, pix_offset);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
            }
        }
#endif
        public static void PlotText(string text, double x, double y, double z, double angle, Vector2 pix_offset)
        {
            byte* native_text;
            int text_byteCount = 0;
            if (text != null)
            {
                text_byteCount = Encoding.UTF8.GetByteCount(text);
                if (text_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_text = Util.Allocate(text_byteCount + 1);
                }
                else
                {
                    byte* native_text_stackBytes = stackalloc byte[text_byteCount + 1];
                    native_text = native_text_stackBytes;
                }
                int native_text_offset = Util.GetUtf8(text, native_text, text_byteCount);
                native_text[native_text_offset] = 0;
            }
            else { native_text = null; }
            ImPlot3DNative.ImPlot3D_PlotText(native_text, x, y, z, angle, pix_offset);
            if (text_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_text);
            }
        }
        public static Vector2 PlotToPixels(ImPlot3DPoint point)
        {
            Vector2 ret = ImPlot3DNative.ImPlot3D_PlotToPixels_Plot3DPoint(point);
            return ret;
        }
        public static Vector2 PlotToPixels(double x, double y, double z)
        {
            Vector2 ret = ImPlot3DNative.ImPlot3D_PlotToPixels_double(x, y, z);
            return ret;
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotTriangle(ReadOnlySpan<char> label_id, ref float xs, ref float ys, ref float zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_FloatPtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotTriangle(string label_id, ref float xs, ref float ys, ref float zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_FloatPtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotTriangle(ReadOnlySpan<char> label_id, ref float xs, ref float ys, ref float zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_FloatPtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotTriangle(string label_id, ref float xs, ref float ys, ref float zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (float* native_xs = &xs)
            {
                fixed (float* native_ys = &ys)
                {
                    fixed (float* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_FloatPtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotTriangle(ReadOnlySpan<char> label_id, ref double xs, ref double ys, ref double zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_doublePtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotTriangle(string label_id, ref double xs, ref double ys, ref double zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_doublePtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotTriangle(ReadOnlySpan<char> label_id, ref double xs, ref double ys, ref double zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_doublePtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotTriangle(string label_id, ref double xs, ref double ys, ref double zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (double* native_xs = &xs)
            {
                fixed (double* native_ys = &ys)
                {
                    fixed (double* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_doublePtr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotTriangle(ReadOnlySpan<char> label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_S8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotTriangle(string label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_S8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotTriangle(ReadOnlySpan<char> label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_S8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotTriangle(string label_id, ref sbyte xs, ref sbyte ys, ref sbyte zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (sbyte* native_xs = &xs)
            {
                fixed (sbyte* native_ys = &ys)
                {
                    fixed (sbyte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_S8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotTriangle(ReadOnlySpan<char> label_id, ref byte xs, ref byte ys, ref byte zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_U8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotTriangle(string label_id, ref byte xs, ref byte ys, ref byte zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_U8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotTriangle(ReadOnlySpan<char> label_id, ref byte xs, ref byte ys, ref byte zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_U8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotTriangle(string label_id, ref byte xs, ref byte ys, ref byte zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (byte* native_xs = &xs)
            {
                fixed (byte* native_ys = &ys)
                {
                    fixed (byte* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_U8Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotTriangle(ReadOnlySpan<char> label_id, ref short xs, ref short ys, ref short zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_S16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotTriangle(string label_id, ref short xs, ref short ys, ref short zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_S16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotTriangle(ReadOnlySpan<char> label_id, ref short xs, ref short ys, ref short zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_S16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotTriangle(string label_id, ref short xs, ref short ys, ref short zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (short* native_xs = &xs)
            {
                fixed (short* native_ys = &ys)
                {
                    fixed (short* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_S16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotTriangle(ReadOnlySpan<char> label_id, ref ushort xs, ref ushort ys, ref ushort zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_U16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotTriangle(string label_id, ref ushort xs, ref ushort ys, ref ushort zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_U16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotTriangle(ReadOnlySpan<char> label_id, ref ushort xs, ref ushort ys, ref ushort zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_U16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotTriangle(string label_id, ref ushort xs, ref ushort ys, ref ushort zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ushort* native_xs = &xs)
            {
                fixed (ushort* native_ys = &ys)
                {
                    fixed (ushort* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_U16Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotTriangle(ReadOnlySpan<char> label_id, ref int xs, ref int ys, ref int zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_S32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotTriangle(string label_id, ref int xs, ref int ys, ref int zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_S32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotTriangle(ReadOnlySpan<char> label_id, ref int xs, ref int ys, ref int zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_S32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotTriangle(string label_id, ref int xs, ref int ys, ref int zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (int* native_xs = &xs)
            {
                fixed (int* native_ys = &ys)
                {
                    fixed (int* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_S32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotTriangle(ReadOnlySpan<char> label_id, ref uint xs, ref uint ys, ref uint zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_U32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotTriangle(string label_id, ref uint xs, ref uint ys, ref uint zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_U32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotTriangle(ReadOnlySpan<char> label_id, ref uint xs, ref uint ys, ref uint zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_U32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotTriangle(string label_id, ref uint xs, ref uint ys, ref uint zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (uint* native_xs = &xs)
            {
                fixed (uint* native_ys = &ys)
                {
                    fixed (uint* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_U32Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotTriangle(ReadOnlySpan<char> label_id, ref long xs, ref long ys, ref long zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_S64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotTriangle(string label_id, ref long xs, ref long ys, ref long zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_S64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotTriangle(ReadOnlySpan<char> label_id, ref long xs, ref long ys, ref long zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_S64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotTriangle(string label_id, ref long xs, ref long ys, ref long zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (long* native_xs = &xs)
            {
                fixed (long* native_ys = &ys)
                {
                    fixed (long* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_S64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotTriangle(ReadOnlySpan<char> label_id, ref ulong xs, ref ulong ys, ref ulong zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_U64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotTriangle(string label_id, ref ulong xs, ref ulong ys, ref ulong zs, int count)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            ImPlot3DSpec spec = new ImPlot3DSpec();
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_U64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PlotTriangle(ReadOnlySpan<char> label_id, ref ulong xs, ref ulong ys, ref ulong zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_U64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
#endif
        public static void PlotTriangle(string label_id, ref ulong xs, ref ulong ys, ref ulong zs, int count, ImPlot3DSpec spec)
        {
            byte* native_label_id;
            int label_id_byteCount = 0;
            if (label_id != null)
            {
                label_id_byteCount = Encoding.UTF8.GetByteCount(label_id);
                if (label_id_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label_id = Util.Allocate(label_id_byteCount + 1);
                }
                else
                {
                    byte* native_label_id_stackBytes = stackalloc byte[label_id_byteCount + 1];
                    native_label_id = native_label_id_stackBytes;
                }
                int native_label_id_offset = Util.GetUtf8(label_id, native_label_id, label_id_byteCount);
                native_label_id[native_label_id_offset] = 0;
            }
            else { native_label_id = null; }
            fixed (ulong* native_xs = &xs)
            {
                fixed (ulong* native_ys = &ys)
                {
                    fixed (ulong* native_zs = &zs)
                    {
                        ImPlot3DNative.ImPlot3D_PlotTriangle_U64Ptr(native_label_id, native_xs, native_ys, native_zs, count, spec);
                        if (label_id_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_label_id);
                        }
                    }
                }
            }
        }
        public static void PopColormap()
        {
            int count = 1;
            ImPlot3DNative.ImPlot3D_PopColormap(count);
        }
        public static void PopColormap(int count)
        {
            ImPlot3DNative.ImPlot3D_PopColormap(count);
        }
        public static void PopStyleColor()
        {
            int count = 1;
            ImPlot3DNative.ImPlot3D_PopStyleColor(count);
        }
        public static void PopStyleColor(int count)
        {
            ImPlot3DNative.ImPlot3D_PopStyleColor(count);
        }
        public static void PopStyleVar()
        {
            int count = 1;
            ImPlot3DNative.ImPlot3D_PopStyleVar(count);
        }
        public static void PopStyleVar(int count)
        {
            ImPlot3DNative.ImPlot3D_PopStyleVar(count);
        }
        public static void PushColormap(ImPlot3DColormap cmap)
        {
            ImPlot3DNative.ImPlot3D_PushColormap_Plot3DColormap(cmap);
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void PushColormap(ReadOnlySpan<char> name)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            ImPlot3DNative.ImPlot3D_PushColormap_Str(native_name);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
        }
#endif
        public static void PushColormap(string name)
        {
            byte* native_name;
            int name_byteCount = 0;
            if (name != null)
            {
                name_byteCount = Encoding.UTF8.GetByteCount(name);
                if (name_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_name = Util.Allocate(name_byteCount + 1);
                }
                else
                {
                    byte* native_name_stackBytes = stackalloc byte[name_byteCount + 1];
                    native_name = native_name_stackBytes;
                }
                int native_name_offset = Util.GetUtf8(name, native_name, name_byteCount);
                native_name[native_name_offset] = 0;
            }
            else { native_name = null; }
            ImPlot3DNative.ImPlot3D_PushColormap_Str(native_name);
            if (name_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_name);
            }
        }
        public static void PushStyleColor(ImPlot3DCol idx, uint col)
        {
            ImPlot3DNative.ImPlot3D_PushStyleColor_U32(idx, col);
        }
        public static void PushStyleColor(ImPlot3DCol idx, Vector4 col)
        {
            ImPlot3DNative.ImPlot3D_PushStyleColor_Vec4(idx, col);
        }
        public static void PushStyleVar(ImPlot3DStyleVar idx, float val)
        {
            ImPlot3DNative.ImPlot3D_PushStyleVar_Float(idx, val);
        }
        public static void PushStyleVar(ImPlot3DStyleVar idx, int val)
        {
            ImPlot3DNative.ImPlot3D_PushStyleVar_Int(idx, val);
        }
        public static void PushStyleVar(ImPlot3DStyleVar idx, Vector2 val)
        {
            ImPlot3DNative.ImPlot3D_PushStyleVar_Vec2(idx, val);
        }
        public static Vector4 SampleColormap(float t)
        {
            ImPlot3DColormap cmap = (ImPlot3DColormap)(-1);
            Vector4 ret = ImPlot3DNative.ImPlot3D_SampleColormap(t, cmap);
            return ret;
        }
        public static Vector4 SampleColormap(float t, ImPlot3DColormap cmap)
        {
            Vector4 ret = ImPlot3DNative.ImPlot3D_SampleColormap(t, cmap);
            return ret;
        }
        public static void SetCurrentContext(IntPtr ctx)
        {
            ImPlot3DNative.ImPlot3D_SetCurrentContext(ctx);
        }
        public static void SetStyle(ImPlot3DStyle style)
        {
            ImPlot3DNative.ImPlot3D_SetStyle(style);
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void SetupAxes(ReadOnlySpan<char> x_label, ReadOnlySpan<char> y_label, ReadOnlySpan<char> z_label)
        {
            byte* native_x_label;
            int x_label_byteCount = 0;
            if (x_label != null)
            {
                x_label_byteCount = Encoding.UTF8.GetByteCount(x_label);
                if (x_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_x_label = Util.Allocate(x_label_byteCount + 1);
                }
                else
                {
                    byte* native_x_label_stackBytes = stackalloc byte[x_label_byteCount + 1];
                    native_x_label = native_x_label_stackBytes;
                }
                int native_x_label_offset = Util.GetUtf8(x_label, native_x_label, x_label_byteCount);
                native_x_label[native_x_label_offset] = 0;
            }
            else { native_x_label = null; }
            byte* native_y_label;
            int y_label_byteCount = 0;
            if (y_label != null)
            {
                y_label_byteCount = Encoding.UTF8.GetByteCount(y_label);
                if (y_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_y_label = Util.Allocate(y_label_byteCount + 1);
                }
                else
                {
                    byte* native_y_label_stackBytes = stackalloc byte[y_label_byteCount + 1];
                    native_y_label = native_y_label_stackBytes;
                }
                int native_y_label_offset = Util.GetUtf8(y_label, native_y_label, y_label_byteCount);
                native_y_label[native_y_label_offset] = 0;
            }
            else { native_y_label = null; }
            byte* native_z_label;
            int z_label_byteCount = 0;
            if (z_label != null)
            {
                z_label_byteCount = Encoding.UTF8.GetByteCount(z_label);
                if (z_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_z_label = Util.Allocate(z_label_byteCount + 1);
                }
                else
                {
                    byte* native_z_label_stackBytes = stackalloc byte[z_label_byteCount + 1];
                    native_z_label = native_z_label_stackBytes;
                }
                int native_z_label_offset = Util.GetUtf8(z_label, native_z_label, z_label_byteCount);
                native_z_label[native_z_label_offset] = 0;
            }
            else { native_z_label = null; }
            ImPlot3DAxisFlags x_flags = (ImPlot3DAxisFlags)0;
            ImPlot3DAxisFlags y_flags = (ImPlot3DAxisFlags)0;
            ImPlot3DAxisFlags z_flags = (ImPlot3DAxisFlags)0;
            ImPlot3DNative.ImPlot3D_SetupAxes(native_x_label, native_y_label, native_z_label, x_flags, y_flags, z_flags);
            if (x_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_x_label);
            }
            if (y_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_y_label);
            }
            if (z_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_z_label);
            }
        }
#endif
        public static void SetupAxes(string x_label, string y_label, string z_label)
        {
            byte* native_x_label;
            int x_label_byteCount = 0;
            if (x_label != null)
            {
                x_label_byteCount = Encoding.UTF8.GetByteCount(x_label);
                if (x_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_x_label = Util.Allocate(x_label_byteCount + 1);
                }
                else
                {
                    byte* native_x_label_stackBytes = stackalloc byte[x_label_byteCount + 1];
                    native_x_label = native_x_label_stackBytes;
                }
                int native_x_label_offset = Util.GetUtf8(x_label, native_x_label, x_label_byteCount);
                native_x_label[native_x_label_offset] = 0;
            }
            else { native_x_label = null; }
            byte* native_y_label;
            int y_label_byteCount = 0;
            if (y_label != null)
            {
                y_label_byteCount = Encoding.UTF8.GetByteCount(y_label);
                if (y_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_y_label = Util.Allocate(y_label_byteCount + 1);
                }
                else
                {
                    byte* native_y_label_stackBytes = stackalloc byte[y_label_byteCount + 1];
                    native_y_label = native_y_label_stackBytes;
                }
                int native_y_label_offset = Util.GetUtf8(y_label, native_y_label, y_label_byteCount);
                native_y_label[native_y_label_offset] = 0;
            }
            else { native_y_label = null; }
            byte* native_z_label;
            int z_label_byteCount = 0;
            if (z_label != null)
            {
                z_label_byteCount = Encoding.UTF8.GetByteCount(z_label);
                if (z_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_z_label = Util.Allocate(z_label_byteCount + 1);
                }
                else
                {
                    byte* native_z_label_stackBytes = stackalloc byte[z_label_byteCount + 1];
                    native_z_label = native_z_label_stackBytes;
                }
                int native_z_label_offset = Util.GetUtf8(z_label, native_z_label, z_label_byteCount);
                native_z_label[native_z_label_offset] = 0;
            }
            else { native_z_label = null; }
            ImPlot3DAxisFlags x_flags = (ImPlot3DAxisFlags)0;
            ImPlot3DAxisFlags y_flags = (ImPlot3DAxisFlags)0;
            ImPlot3DAxisFlags z_flags = (ImPlot3DAxisFlags)0;
            ImPlot3DNative.ImPlot3D_SetupAxes(native_x_label, native_y_label, native_z_label, x_flags, y_flags, z_flags);
            if (x_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_x_label);
            }
            if (y_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_y_label);
            }
            if (z_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_z_label);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void SetupAxes(ReadOnlySpan<char> x_label, ReadOnlySpan<char> y_label, ReadOnlySpan<char> z_label, ImPlot3DAxisFlags x_flags)
        {
            byte* native_x_label;
            int x_label_byteCount = 0;
            if (x_label != null)
            {
                x_label_byteCount = Encoding.UTF8.GetByteCount(x_label);
                if (x_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_x_label = Util.Allocate(x_label_byteCount + 1);
                }
                else
                {
                    byte* native_x_label_stackBytes = stackalloc byte[x_label_byteCount + 1];
                    native_x_label = native_x_label_stackBytes;
                }
                int native_x_label_offset = Util.GetUtf8(x_label, native_x_label, x_label_byteCount);
                native_x_label[native_x_label_offset] = 0;
            }
            else { native_x_label = null; }
            byte* native_y_label;
            int y_label_byteCount = 0;
            if (y_label != null)
            {
                y_label_byteCount = Encoding.UTF8.GetByteCount(y_label);
                if (y_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_y_label = Util.Allocate(y_label_byteCount + 1);
                }
                else
                {
                    byte* native_y_label_stackBytes = stackalloc byte[y_label_byteCount + 1];
                    native_y_label = native_y_label_stackBytes;
                }
                int native_y_label_offset = Util.GetUtf8(y_label, native_y_label, y_label_byteCount);
                native_y_label[native_y_label_offset] = 0;
            }
            else { native_y_label = null; }
            byte* native_z_label;
            int z_label_byteCount = 0;
            if (z_label != null)
            {
                z_label_byteCount = Encoding.UTF8.GetByteCount(z_label);
                if (z_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_z_label = Util.Allocate(z_label_byteCount + 1);
                }
                else
                {
                    byte* native_z_label_stackBytes = stackalloc byte[z_label_byteCount + 1];
                    native_z_label = native_z_label_stackBytes;
                }
                int native_z_label_offset = Util.GetUtf8(z_label, native_z_label, z_label_byteCount);
                native_z_label[native_z_label_offset] = 0;
            }
            else { native_z_label = null; }
            ImPlot3DAxisFlags y_flags = (ImPlot3DAxisFlags)0;
            ImPlot3DAxisFlags z_flags = (ImPlot3DAxisFlags)0;
            ImPlot3DNative.ImPlot3D_SetupAxes(native_x_label, native_y_label, native_z_label, x_flags, y_flags, z_flags);
            if (x_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_x_label);
            }
            if (y_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_y_label);
            }
            if (z_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_z_label);
            }
        }
#endif
        public static void SetupAxes(string x_label, string y_label, string z_label, ImPlot3DAxisFlags x_flags)
        {
            byte* native_x_label;
            int x_label_byteCount = 0;
            if (x_label != null)
            {
                x_label_byteCount = Encoding.UTF8.GetByteCount(x_label);
                if (x_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_x_label = Util.Allocate(x_label_byteCount + 1);
                }
                else
                {
                    byte* native_x_label_stackBytes = stackalloc byte[x_label_byteCount + 1];
                    native_x_label = native_x_label_stackBytes;
                }
                int native_x_label_offset = Util.GetUtf8(x_label, native_x_label, x_label_byteCount);
                native_x_label[native_x_label_offset] = 0;
            }
            else { native_x_label = null; }
            byte* native_y_label;
            int y_label_byteCount = 0;
            if (y_label != null)
            {
                y_label_byteCount = Encoding.UTF8.GetByteCount(y_label);
                if (y_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_y_label = Util.Allocate(y_label_byteCount + 1);
                }
                else
                {
                    byte* native_y_label_stackBytes = stackalloc byte[y_label_byteCount + 1];
                    native_y_label = native_y_label_stackBytes;
                }
                int native_y_label_offset = Util.GetUtf8(y_label, native_y_label, y_label_byteCount);
                native_y_label[native_y_label_offset] = 0;
            }
            else { native_y_label = null; }
            byte* native_z_label;
            int z_label_byteCount = 0;
            if (z_label != null)
            {
                z_label_byteCount = Encoding.UTF8.GetByteCount(z_label);
                if (z_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_z_label = Util.Allocate(z_label_byteCount + 1);
                }
                else
                {
                    byte* native_z_label_stackBytes = stackalloc byte[z_label_byteCount + 1];
                    native_z_label = native_z_label_stackBytes;
                }
                int native_z_label_offset = Util.GetUtf8(z_label, native_z_label, z_label_byteCount);
                native_z_label[native_z_label_offset] = 0;
            }
            else { native_z_label = null; }
            ImPlot3DAxisFlags y_flags = (ImPlot3DAxisFlags)0;
            ImPlot3DAxisFlags z_flags = (ImPlot3DAxisFlags)0;
            ImPlot3DNative.ImPlot3D_SetupAxes(native_x_label, native_y_label, native_z_label, x_flags, y_flags, z_flags);
            if (x_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_x_label);
            }
            if (y_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_y_label);
            }
            if (z_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_z_label);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void SetupAxes(ReadOnlySpan<char> x_label, ReadOnlySpan<char> y_label, ReadOnlySpan<char> z_label, ImPlot3DAxisFlags x_flags, ImPlot3DAxisFlags y_flags)
        {
            byte* native_x_label;
            int x_label_byteCount = 0;
            if (x_label != null)
            {
                x_label_byteCount = Encoding.UTF8.GetByteCount(x_label);
                if (x_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_x_label = Util.Allocate(x_label_byteCount + 1);
                }
                else
                {
                    byte* native_x_label_stackBytes = stackalloc byte[x_label_byteCount + 1];
                    native_x_label = native_x_label_stackBytes;
                }
                int native_x_label_offset = Util.GetUtf8(x_label, native_x_label, x_label_byteCount);
                native_x_label[native_x_label_offset] = 0;
            }
            else { native_x_label = null; }
            byte* native_y_label;
            int y_label_byteCount = 0;
            if (y_label != null)
            {
                y_label_byteCount = Encoding.UTF8.GetByteCount(y_label);
                if (y_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_y_label = Util.Allocate(y_label_byteCount + 1);
                }
                else
                {
                    byte* native_y_label_stackBytes = stackalloc byte[y_label_byteCount + 1];
                    native_y_label = native_y_label_stackBytes;
                }
                int native_y_label_offset = Util.GetUtf8(y_label, native_y_label, y_label_byteCount);
                native_y_label[native_y_label_offset] = 0;
            }
            else { native_y_label = null; }
            byte* native_z_label;
            int z_label_byteCount = 0;
            if (z_label != null)
            {
                z_label_byteCount = Encoding.UTF8.GetByteCount(z_label);
                if (z_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_z_label = Util.Allocate(z_label_byteCount + 1);
                }
                else
                {
                    byte* native_z_label_stackBytes = stackalloc byte[z_label_byteCount + 1];
                    native_z_label = native_z_label_stackBytes;
                }
                int native_z_label_offset = Util.GetUtf8(z_label, native_z_label, z_label_byteCount);
                native_z_label[native_z_label_offset] = 0;
            }
            else { native_z_label = null; }
            ImPlot3DAxisFlags z_flags = (ImPlot3DAxisFlags)0;
            ImPlot3DNative.ImPlot3D_SetupAxes(native_x_label, native_y_label, native_z_label, x_flags, y_flags, z_flags);
            if (x_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_x_label);
            }
            if (y_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_y_label);
            }
            if (z_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_z_label);
            }
        }
#endif
        public static void SetupAxes(string x_label, string y_label, string z_label, ImPlot3DAxisFlags x_flags, ImPlot3DAxisFlags y_flags)
        {
            byte* native_x_label;
            int x_label_byteCount = 0;
            if (x_label != null)
            {
                x_label_byteCount = Encoding.UTF8.GetByteCount(x_label);
                if (x_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_x_label = Util.Allocate(x_label_byteCount + 1);
                }
                else
                {
                    byte* native_x_label_stackBytes = stackalloc byte[x_label_byteCount + 1];
                    native_x_label = native_x_label_stackBytes;
                }
                int native_x_label_offset = Util.GetUtf8(x_label, native_x_label, x_label_byteCount);
                native_x_label[native_x_label_offset] = 0;
            }
            else { native_x_label = null; }
            byte* native_y_label;
            int y_label_byteCount = 0;
            if (y_label != null)
            {
                y_label_byteCount = Encoding.UTF8.GetByteCount(y_label);
                if (y_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_y_label = Util.Allocate(y_label_byteCount + 1);
                }
                else
                {
                    byte* native_y_label_stackBytes = stackalloc byte[y_label_byteCount + 1];
                    native_y_label = native_y_label_stackBytes;
                }
                int native_y_label_offset = Util.GetUtf8(y_label, native_y_label, y_label_byteCount);
                native_y_label[native_y_label_offset] = 0;
            }
            else { native_y_label = null; }
            byte* native_z_label;
            int z_label_byteCount = 0;
            if (z_label != null)
            {
                z_label_byteCount = Encoding.UTF8.GetByteCount(z_label);
                if (z_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_z_label = Util.Allocate(z_label_byteCount + 1);
                }
                else
                {
                    byte* native_z_label_stackBytes = stackalloc byte[z_label_byteCount + 1];
                    native_z_label = native_z_label_stackBytes;
                }
                int native_z_label_offset = Util.GetUtf8(z_label, native_z_label, z_label_byteCount);
                native_z_label[native_z_label_offset] = 0;
            }
            else { native_z_label = null; }
            ImPlot3DAxisFlags z_flags = (ImPlot3DAxisFlags)0;
            ImPlot3DNative.ImPlot3D_SetupAxes(native_x_label, native_y_label, native_z_label, x_flags, y_flags, z_flags);
            if (x_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_x_label);
            }
            if (y_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_y_label);
            }
            if (z_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_z_label);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void SetupAxes(ReadOnlySpan<char> x_label, ReadOnlySpan<char> y_label, ReadOnlySpan<char> z_label, ImPlot3DAxisFlags x_flags, ImPlot3DAxisFlags y_flags, ImPlot3DAxisFlags z_flags)
        {
            byte* native_x_label;
            int x_label_byteCount = 0;
            if (x_label != null)
            {
                x_label_byteCount = Encoding.UTF8.GetByteCount(x_label);
                if (x_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_x_label = Util.Allocate(x_label_byteCount + 1);
                }
                else
                {
                    byte* native_x_label_stackBytes = stackalloc byte[x_label_byteCount + 1];
                    native_x_label = native_x_label_stackBytes;
                }
                int native_x_label_offset = Util.GetUtf8(x_label, native_x_label, x_label_byteCount);
                native_x_label[native_x_label_offset] = 0;
            }
            else { native_x_label = null; }
            byte* native_y_label;
            int y_label_byteCount = 0;
            if (y_label != null)
            {
                y_label_byteCount = Encoding.UTF8.GetByteCount(y_label);
                if (y_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_y_label = Util.Allocate(y_label_byteCount + 1);
                }
                else
                {
                    byte* native_y_label_stackBytes = stackalloc byte[y_label_byteCount + 1];
                    native_y_label = native_y_label_stackBytes;
                }
                int native_y_label_offset = Util.GetUtf8(y_label, native_y_label, y_label_byteCount);
                native_y_label[native_y_label_offset] = 0;
            }
            else { native_y_label = null; }
            byte* native_z_label;
            int z_label_byteCount = 0;
            if (z_label != null)
            {
                z_label_byteCount = Encoding.UTF8.GetByteCount(z_label);
                if (z_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_z_label = Util.Allocate(z_label_byteCount + 1);
                }
                else
                {
                    byte* native_z_label_stackBytes = stackalloc byte[z_label_byteCount + 1];
                    native_z_label = native_z_label_stackBytes;
                }
                int native_z_label_offset = Util.GetUtf8(z_label, native_z_label, z_label_byteCount);
                native_z_label[native_z_label_offset] = 0;
            }
            else { native_z_label = null; }
            ImPlot3DNative.ImPlot3D_SetupAxes(native_x_label, native_y_label, native_z_label, x_flags, y_flags, z_flags);
            if (x_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_x_label);
            }
            if (y_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_y_label);
            }
            if (z_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_z_label);
            }
        }
#endif
        public static void SetupAxes(string x_label, string y_label, string z_label, ImPlot3DAxisFlags x_flags, ImPlot3DAxisFlags y_flags, ImPlot3DAxisFlags z_flags)
        {
            byte* native_x_label;
            int x_label_byteCount = 0;
            if (x_label != null)
            {
                x_label_byteCount = Encoding.UTF8.GetByteCount(x_label);
                if (x_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_x_label = Util.Allocate(x_label_byteCount + 1);
                }
                else
                {
                    byte* native_x_label_stackBytes = stackalloc byte[x_label_byteCount + 1];
                    native_x_label = native_x_label_stackBytes;
                }
                int native_x_label_offset = Util.GetUtf8(x_label, native_x_label, x_label_byteCount);
                native_x_label[native_x_label_offset] = 0;
            }
            else { native_x_label = null; }
            byte* native_y_label;
            int y_label_byteCount = 0;
            if (y_label != null)
            {
                y_label_byteCount = Encoding.UTF8.GetByteCount(y_label);
                if (y_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_y_label = Util.Allocate(y_label_byteCount + 1);
                }
                else
                {
                    byte* native_y_label_stackBytes = stackalloc byte[y_label_byteCount + 1];
                    native_y_label = native_y_label_stackBytes;
                }
                int native_y_label_offset = Util.GetUtf8(y_label, native_y_label, y_label_byteCount);
                native_y_label[native_y_label_offset] = 0;
            }
            else { native_y_label = null; }
            byte* native_z_label;
            int z_label_byteCount = 0;
            if (z_label != null)
            {
                z_label_byteCount = Encoding.UTF8.GetByteCount(z_label);
                if (z_label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_z_label = Util.Allocate(z_label_byteCount + 1);
                }
                else
                {
                    byte* native_z_label_stackBytes = stackalloc byte[z_label_byteCount + 1];
                    native_z_label = native_z_label_stackBytes;
                }
                int native_z_label_offset = Util.GetUtf8(z_label, native_z_label, z_label_byteCount);
                native_z_label[native_z_label_offset] = 0;
            }
            else { native_z_label = null; }
            ImPlot3DNative.ImPlot3D_SetupAxes(native_x_label, native_y_label, native_z_label, x_flags, y_flags, z_flags);
            if (x_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_x_label);
            }
            if (y_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_y_label);
            }
            if (z_label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_z_label);
            }
        }
        public static void SetupAxesLimits(double x_min, double x_max, double y_min, double y_max, double z_min, double z_max)
        {
            ImPlot3DCond cond = ImPlot3DCond.Once;
            ImPlot3DNative.ImPlot3D_SetupAxesLimits(x_min, x_max, y_min, y_max, z_min, z_max, cond);
        }
        public static void SetupAxesLimits(double x_min, double x_max, double y_min, double y_max, double z_min, double z_max, ImPlot3DCond cond)
        {
            ImPlot3DNative.ImPlot3D_SetupAxesLimits(x_min, x_max, y_min, y_max, z_min, z_max, cond);
        }
        public static void SetupAxis(ImAxis3D axis)
        {
            byte* native_label = null;
            ImPlot3DAxisFlags flags = (ImPlot3DAxisFlags)0;
            ImPlot3DNative.ImPlot3D_SetupAxis(axis, native_label, flags);
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void SetupAxis(ImAxis3D axis, ReadOnlySpan<char> label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImPlot3DAxisFlags flags = (ImPlot3DAxisFlags)0;
            ImPlot3DNative.ImPlot3D_SetupAxis(axis, native_label, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
#endif
        public static void SetupAxis(ImAxis3D axis, string label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImPlot3DAxisFlags flags = (ImPlot3DAxisFlags)0;
            ImPlot3DNative.ImPlot3D_SetupAxis(axis, native_label, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static void SetupAxis(ImAxis3D axis, ReadOnlySpan<char> label, ImPlot3DAxisFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImPlot3DNative.ImPlot3D_SetupAxis(axis, native_label, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
#endif
        public static void SetupAxis(ImAxis3D axis, string label, ImPlot3DAxisFlags flags)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            ImPlot3DNative.ImPlot3D_SetupAxis(axis, native_label, flags);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
        }
        public static void SetupAxisFormat(ImAxis3D axis, IntPtr formatter)
        {
            void* data = null;
            ImPlot3DNative.ImPlot3D_SetupAxisFormat(axis, formatter, data);
        }
        public static void SetupAxisFormat(ImAxis3D axis, IntPtr formatter, IntPtr data)
        {
            void* native_data = (void*)data.ToPointer();
            ImPlot3DNative.ImPlot3D_SetupAxisFormat(axis, formatter, native_data);
        }
        public static void SetupAxisLimits(ImAxis3D axis, double v_min, double v_max)
        {
            ImPlot3DCond cond = ImPlot3DCond.Once;
            ImPlot3DNative.ImPlot3D_SetupAxisLimits(axis, v_min, v_max, cond);
        }
        public static void SetupAxisLimits(ImAxis3D axis, double v_min, double v_max, ImPlot3DCond cond)
        {
            ImPlot3DNative.ImPlot3D_SetupAxisLimits(axis, v_min, v_max, cond);
        }
        public static void SetupAxisLimitsConstraints(ImAxis3D axis, double v_min, double v_max)
        {
            ImPlot3DNative.ImPlot3D_SetupAxisLimitsConstraints(axis, v_min, v_max);
        }
        public static void SetupAxisScale(ImAxis3D axis, ImPlot3DScale scale)
        {
            ImPlot3DNative.ImPlot3D_SetupAxisScale_Plot3DScale(axis, scale);
        }
        public static void SetupAxisScale(ImAxis3D axis, IntPtr forward, IntPtr inverse)
        {
            void* data = null;
            ImPlot3DNative.ImPlot3D_SetupAxisScale_Plot3DTransform(axis, forward, inverse, data);
        }
        public static void SetupAxisScale(ImAxis3D axis, IntPtr forward, IntPtr inverse, IntPtr data)
        {
            void* native_data = (void*)data.ToPointer();
            ImPlot3DNative.ImPlot3D_SetupAxisScale_Plot3DTransform(axis, forward, inverse, native_data);
        }
        public static void SetupAxisTicks(ImAxis3D axis, ref double values, int n_ticks)
        {
            byte** labels = null;
            byte keep_default = 0;
            fixed (double* native_values = &values)
            {
                ImPlot3DNative.ImPlot3D_SetupAxisTicks_doublePtr(axis, native_values, n_ticks, labels, keep_default);
            }
        }
        public static void SetupAxisTicks(ImAxis3D axis, ref double values, int n_ticks, string[] labels)
        {
            int* labels_byteCounts = stackalloc int[labels.Length];
            int labels_byteCount = 0;
            for (int i = 0; i < labels.Length; i++)
            {
                string s = labels[i];
                labels_byteCounts[i] = Encoding.UTF8.GetByteCount(s);
                labels_byteCount += labels_byteCounts[i] + 1;
            }
            byte* native_labels_data = stackalloc byte[labels_byteCount];
            int offset = 0;
            for (int i = 0; i < labels.Length; i++)
            {
                string s = labels[i];
                offset += Util.GetUtf8(s, native_labels_data + offset, labels_byteCounts[i]);
                native_labels_data[offset++] = 0;
            }
            byte** native_labels = stackalloc byte*[labels.Length];
            offset = 0;
            for (int i = 0; i < labels.Length; i++)
            {
                native_labels[i] = &native_labels_data[offset];
                offset += labels_byteCounts[i] + 1;
            }
            byte keep_default = 0;
            fixed (double* native_values = &values)
            {
                ImPlot3DNative.ImPlot3D_SetupAxisTicks_doublePtr(axis, native_values, n_ticks, native_labels, keep_default);
            }
        }
        public static void SetupAxisTicks(ImAxis3D axis, ref double values, int n_ticks, string[] labels, bool keep_default)
        {
            int* labels_byteCounts = stackalloc int[labels.Length];
            int labels_byteCount = 0;
            for (int i = 0; i < labels.Length; i++)
            {
                string s = labels[i];
                labels_byteCounts[i] = Encoding.UTF8.GetByteCount(s);
                labels_byteCount += labels_byteCounts[i] + 1;
            }
            byte* native_labels_data = stackalloc byte[labels_byteCount];
            int offset = 0;
            for (int i = 0; i < labels.Length; i++)
            {
                string s = labels[i];
                offset += Util.GetUtf8(s, native_labels_data + offset, labels_byteCounts[i]);
                native_labels_data[offset++] = 0;
            }
            byte** native_labels = stackalloc byte*[labels.Length];
            offset = 0;
            for (int i = 0; i < labels.Length; i++)
            {
                native_labels[i] = &native_labels_data[offset];
                offset += labels_byteCounts[i] + 1;
            }
            byte native_keep_default = keep_default ? (byte)1 : (byte)0;
            fixed (double* native_values = &values)
            {
                ImPlot3DNative.ImPlot3D_SetupAxisTicks_doublePtr(axis, native_values, n_ticks, native_labels, native_keep_default);
            }
        }
        public static void SetupAxisTicks(ImAxis3D axis, double v_min, double v_max, int n_ticks)
        {
            byte** labels = null;
            byte keep_default = 0;
            ImPlot3DNative.ImPlot3D_SetupAxisTicks_double(axis, v_min, v_max, n_ticks, labels, keep_default);
        }
        public static void SetupAxisTicks(ImAxis3D axis, double v_min, double v_max, int n_ticks, string[] labels)
        {
            int* labels_byteCounts = stackalloc int[labels.Length];
            int labels_byteCount = 0;
            for (int i = 0; i < labels.Length; i++)
            {
                string s = labels[i];
                labels_byteCounts[i] = Encoding.UTF8.GetByteCount(s);
                labels_byteCount += labels_byteCounts[i] + 1;
            }
            byte* native_labels_data = stackalloc byte[labels_byteCount];
            int offset = 0;
            for (int i = 0; i < labels.Length; i++)
            {
                string s = labels[i];
                offset += Util.GetUtf8(s, native_labels_data + offset, labels_byteCounts[i]);
                native_labels_data[offset++] = 0;
            }
            byte** native_labels = stackalloc byte*[labels.Length];
            offset = 0;
            for (int i = 0; i < labels.Length; i++)
            {
                native_labels[i] = &native_labels_data[offset];
                offset += labels_byteCounts[i] + 1;
            }
            byte keep_default = 0;
            ImPlot3DNative.ImPlot3D_SetupAxisTicks_double(axis, v_min, v_max, n_ticks, native_labels, keep_default);
        }
        public static void SetupAxisTicks(ImAxis3D axis, double v_min, double v_max, int n_ticks, string[] labels, bool keep_default)
        {
            int* labels_byteCounts = stackalloc int[labels.Length];
            int labels_byteCount = 0;
            for (int i = 0; i < labels.Length; i++)
            {
                string s = labels[i];
                labels_byteCounts[i] = Encoding.UTF8.GetByteCount(s);
                labels_byteCount += labels_byteCounts[i] + 1;
            }
            byte* native_labels_data = stackalloc byte[labels_byteCount];
            int offset = 0;
            for (int i = 0; i < labels.Length; i++)
            {
                string s = labels[i];
                offset += Util.GetUtf8(s, native_labels_data + offset, labels_byteCounts[i]);
                native_labels_data[offset++] = 0;
            }
            byte** native_labels = stackalloc byte*[labels.Length];
            offset = 0;
            for (int i = 0; i < labels.Length; i++)
            {
                native_labels[i] = &native_labels_data[offset];
                offset += labels_byteCounts[i] + 1;
            }
            byte native_keep_default = keep_default ? (byte)1 : (byte)0;
            ImPlot3DNative.ImPlot3D_SetupAxisTicks_double(axis, v_min, v_max, n_ticks, native_labels, native_keep_default);
        }
        public static void SetupAxisZoomConstraints(ImAxis3D axis, double zoom_min, double zoom_max)
        {
            ImPlot3DNative.ImPlot3D_SetupAxisZoomConstraints(axis, zoom_min, zoom_max);
        }
        public static void SetupBoxInitialRotation(double elevation, double azimuth)
        {
            ImPlot3DNative.ImPlot3D_SetupBoxInitialRotation_double(elevation, azimuth);
        }
        public static void SetupBoxInitialRotation(ImPlot3DQuat rotation)
        {
            ImPlot3DNative.ImPlot3D_SetupBoxInitialRotation_Plot3DQuat(rotation);
        }
        public static void SetupBoxRotation(double elevation, double azimuth)
        {
            byte animate = 0;
            ImPlot3DCond cond = ImPlot3DCond.Once;
            ImPlot3DNative.ImPlot3D_SetupBoxRotation_double(elevation, azimuth, animate, cond);
        }
        public static void SetupBoxRotation(double elevation, double azimuth, bool animate)
        {
            byte native_animate = animate ? (byte)1 : (byte)0;
            ImPlot3DCond cond = ImPlot3DCond.Once;
            ImPlot3DNative.ImPlot3D_SetupBoxRotation_double(elevation, azimuth, native_animate, cond);
        }
        public static void SetupBoxRotation(double elevation, double azimuth, bool animate, ImPlot3DCond cond)
        {
            byte native_animate = animate ? (byte)1 : (byte)0;
            ImPlot3DNative.ImPlot3D_SetupBoxRotation_double(elevation, azimuth, native_animate, cond);
        }
        public static void SetupBoxRotation(ImPlot3DQuat rotation)
        {
            byte animate = 0;
            ImPlot3DCond cond = ImPlot3DCond.Once;
            ImPlot3DNative.ImPlot3D_SetupBoxRotation_Plot3DQuat(rotation, animate, cond);
        }
        public static void SetupBoxRotation(ImPlot3DQuat rotation, bool animate)
        {
            byte native_animate = animate ? (byte)1 : (byte)0;
            ImPlot3DCond cond = ImPlot3DCond.Once;
            ImPlot3DNative.ImPlot3D_SetupBoxRotation_Plot3DQuat(rotation, native_animate, cond);
        }
        public static void SetupBoxRotation(ImPlot3DQuat rotation, bool animate, ImPlot3DCond cond)
        {
            byte native_animate = animate ? (byte)1 : (byte)0;
            ImPlot3DNative.ImPlot3D_SetupBoxRotation_Plot3DQuat(rotation, native_animate, cond);
        }
        public static void SetupBoxScale(double x, double y, double z)
        {
            ImPlot3DNative.ImPlot3D_SetupBoxScale(x, y, z);
        }
        public static void SetupLegend(ImPlot3DLocation location)
        {
            ImPlot3DLegendFlags flags = (ImPlot3DLegendFlags)0;
            ImPlot3DNative.ImPlot3D_SetupLegend(location, flags);
        }
        public static void SetupLegend(ImPlot3DLocation location, ImPlot3DLegendFlags flags)
        {
            ImPlot3DNative.ImPlot3D_SetupLegend(location, flags);
        }
        public static void ShowAboutWindow()
        {
            byte* p_open = null;
            ImPlot3DNative.ImPlot3D_ShowAboutWindow(p_open);
        }
        public static void ShowAboutWindow(ref bool p_open)
        {
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            ImPlot3DNative.ImPlot3D_ShowAboutWindow(native_p_open);
            p_open = native_p_open_val != 0;
        }
        public static void ShowAllDemos()
        {
            ImPlot3DNative.ImPlot3D_ShowAllDemos();
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool ShowColormapSelector(ReadOnlySpan<char> label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImPlot3DNative.ImPlot3D_ShowColormapSelector(native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#endif
        public static bool ShowColormapSelector(string label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImPlot3DNative.ImPlot3D_ShowColormapSelector(native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static void ShowDemoWindow()
        {
            byte* p_open = null;
            ImPlot3DNative.ImPlot3D_ShowDemoWindow(p_open);
        }
        public static void ShowDemoWindow(ref bool p_open)
        {
            byte native_p_open_val = p_open ? (byte)1 : (byte)0;
            byte* native_p_open = &native_p_open_val;
            ImPlot3DNative.ImPlot3D_ShowDemoWindow(native_p_open);
            p_open = native_p_open_val != 0;
        }
        public static void ShowMetricsWindow()
        {
            byte* p_popen = null;
            ImPlot3DNative.ImPlot3D_ShowMetricsWindow(p_popen);
        }
        public static void ShowMetricsWindow(ref bool p_popen)
        {
            byte native_p_popen_val = p_popen ? (byte)1 : (byte)0;
            byte* native_p_popen = &native_p_popen_val;
            ImPlot3DNative.ImPlot3D_ShowMetricsWindow(native_p_popen);
            p_popen = native_p_popen_val != 0;
        }
        public static void ShowStyleEditor()
        {
            ImPlot3DStyle* @ref = null;
            ImPlot3DNative.ImPlot3D_ShowStyleEditor(@ref);
        }
        public static void ShowStyleEditor(ImPlot3DStylePtr @ref)
        {
            ImPlot3DStyle* native_ref = @ref.NativePtr;
            ImPlot3DNative.ImPlot3D_ShowStyleEditor(native_ref);
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool ShowStyleSelector(ReadOnlySpan<char> label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImPlot3DNative.ImPlot3D_ShowStyleSelector(native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#endif
        public static bool ShowStyleSelector(string label)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImPlot3DNative.ImPlot3D_ShowStyleSelector(native_label);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public static void StyleColorsAuto()
        {
            ImPlot3DStyle* dst = null;
            ImPlot3DNative.ImPlot3D_StyleColorsAuto(dst);
        }
        public static void StyleColorsAuto(ImPlot3DStylePtr dst)
        {
            ImPlot3DStyle* native_dst = dst.NativePtr;
            ImPlot3DNative.ImPlot3D_StyleColorsAuto(native_dst);
        }
        public static void StyleColorsClassic()
        {
            ImPlot3DStyle* dst = null;
            ImPlot3DNative.ImPlot3D_StyleColorsClassic(dst);
        }
        public static void StyleColorsClassic(ImPlot3DStylePtr dst)
        {
            ImPlot3DStyle* native_dst = dst.NativePtr;
            ImPlot3DNative.ImPlot3D_StyleColorsClassic(native_dst);
        }
        public static void StyleColorsDark()
        {
            ImPlot3DStyle* dst = null;
            ImPlot3DNative.ImPlot3D_StyleColorsDark(dst);
        }
        public static void StyleColorsDark(ImPlot3DStylePtr dst)
        {
            ImPlot3DStyle* native_dst = dst.NativePtr;
            ImPlot3DNative.ImPlot3D_StyleColorsDark(native_dst);
        }
        public static void StyleColorsLight()
        {
            ImPlot3DStyle* dst = null;
            ImPlot3DNative.ImPlot3D_StyleColorsLight(dst);
        }
        public static void StyleColorsLight(ImPlot3DStylePtr dst)
        {
            ImPlot3DStyle* native_dst = dst.NativePtr;
            ImPlot3DNative.ImPlot3D_StyleColorsLight(native_dst);
        }
    }
}
