using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlot3DNET
{
    public unsafe partial struct ImPlot3DBox
    {
        public ImPlot3DPoint Min;
        public ImPlot3DPoint Max;
    }
    public unsafe partial struct ImPlot3DBoxPtr
    {
        public ImPlot3DBox* NativePtr { get; }
        public ImPlot3DBoxPtr(ImPlot3DBox* nativePtr) => NativePtr = nativePtr;
        public ImPlot3DBoxPtr(IntPtr nativePtr) => NativePtr = (ImPlot3DBox*)nativePtr;
        public static implicit operator ImPlot3DBoxPtr(ImPlot3DBox* nativePtr) => new ImPlot3DBoxPtr(nativePtr);
        public static implicit operator ImPlot3DBox* (ImPlot3DBoxPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlot3DBoxPtr(IntPtr nativePtr) => new ImPlot3DBoxPtr(nativePtr);
        public ref ImPlot3DPoint Min => ref Unsafe.AsRef<ImPlot3DPoint>(&NativePtr->Min);
        public ref ImPlot3DPoint Max => ref Unsafe.AsRef<ImPlot3DPoint>(&NativePtr->Max);
        public bool ClipLineSegment(ImPlot3DPoint p0, ImPlot3DPoint p1, ImPlot3DPointPtr p0_clipped, ImPlot3DPointPtr p1_clipped)
        {
            ImPlot3DPoint* native_p0_clipped = p0_clipped.NativePtr;
            ImPlot3DPoint* native_p1_clipped = p1_clipped.NativePtr;
            byte ret = ImPlot3DNative.ImPlot3DBox_ClipLineSegment((ImPlot3DBox*)(NativePtr), p0, p1, native_p0_clipped, native_p1_clipped);
            return ret != 0;
        }
        public bool Contains(ImPlot3DPoint point)
        {
            byte ret = ImPlot3DNative.ImPlot3DBox_Contains((ImPlot3DBox*)(NativePtr), point);
            return ret != 0;
        }
        public void Destroy()
        {
            ImPlot3DNative.ImPlot3DBox_destroy((ImPlot3DBox*)(NativePtr));
        }
        public void Expand(ImPlot3DPoint point)
        {
            ImPlot3DNative.ImPlot3DBox_Expand((ImPlot3DBox*)(NativePtr), point);
        }
    }
}
