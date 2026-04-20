using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlot3DNET
{
    public unsafe partial struct ImPlot3DRay
    {
        public ImPlot3DPoint Origin;
        public ImPlot3DPoint Direction;
    }
    public unsafe partial struct ImPlot3DRayPtr
    {
        public ImPlot3DRay* NativePtr { get; }
        public ImPlot3DRayPtr(ImPlot3DRay* nativePtr) => NativePtr = nativePtr;
        public ImPlot3DRayPtr(IntPtr nativePtr) => NativePtr = (ImPlot3DRay*)nativePtr;
        public static implicit operator ImPlot3DRayPtr(ImPlot3DRay* nativePtr) => new ImPlot3DRayPtr(nativePtr);
        public static implicit operator ImPlot3DRay* (ImPlot3DRayPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlot3DRayPtr(IntPtr nativePtr) => new ImPlot3DRayPtr(nativePtr);
        public ref ImPlot3DPoint Origin => ref Unsafe.AsRef<ImPlot3DPoint>(&NativePtr->Origin);
        public ref ImPlot3DPoint Direction => ref Unsafe.AsRef<ImPlot3DPoint>(&NativePtr->Direction);
    }
}
