using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlot3DNET
{
    public unsafe partial struct ImPlot3DPlane
    {
        public ImPlot3DPoint Point;
        public ImPlot3DPoint Normal;
    }
    public unsafe partial struct ImPlot3DPlanePtr
    {
        public ImPlot3DPlane* NativePtr { get; }
        public ImPlot3DPlanePtr(ImPlot3DPlane* nativePtr) => NativePtr = nativePtr;
        public ImPlot3DPlanePtr(IntPtr nativePtr) => NativePtr = (ImPlot3DPlane*)nativePtr;
        public static implicit operator ImPlot3DPlanePtr(ImPlot3DPlane* nativePtr) => new ImPlot3DPlanePtr(nativePtr);
        public static implicit operator ImPlot3DPlane* (ImPlot3DPlanePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlot3DPlanePtr(IntPtr nativePtr) => new ImPlot3DPlanePtr(nativePtr);
        public ref ImPlot3DPoint Point => ref Unsafe.AsRef<ImPlot3DPoint>(&NativePtr->Point);
        public ref ImPlot3DPoint Normal => ref Unsafe.AsRef<ImPlot3DPoint>(&NativePtr->Normal);
    }
}
