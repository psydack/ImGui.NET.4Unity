using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlot3DNET
{
    public unsafe partial struct ImPlot3DRange
    {
        public double Min;
        public double Max;
    }
    public unsafe partial struct ImPlot3DRangePtr
    {
        public ImPlot3DRange* NativePtr { get; }
        public ImPlot3DRangePtr(ImPlot3DRange* nativePtr) => NativePtr = nativePtr;
        public ImPlot3DRangePtr(IntPtr nativePtr) => NativePtr = (ImPlot3DRange*)nativePtr;
        public static implicit operator ImPlot3DRangePtr(ImPlot3DRange* nativePtr) => new ImPlot3DRangePtr(nativePtr);
        public static implicit operator ImPlot3DRange* (ImPlot3DRangePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlot3DRangePtr(IntPtr nativePtr) => new ImPlot3DRangePtr(nativePtr);
        public ref double Min => ref Unsafe.AsRef<double>(&NativePtr->Min);
        public ref double Max => ref Unsafe.AsRef<double>(&NativePtr->Max);
        public bool Contains(double value)
        {
            byte ret = ImPlot3DNative.ImPlot3DRange_Contains((ImPlot3DRange*)(NativePtr), value);
            return ret != 0;
        }
        public void Destroy()
        {
            ImPlot3DNative.ImPlot3DRange_destroy((ImPlot3DRange*)(NativePtr));
        }
        public void Expand(double value)
        {
            ImPlot3DNative.ImPlot3DRange_Expand((ImPlot3DRange*)(NativePtr), value);
        }
        public double Size()
        {
            double ret = ImPlot3DNative.ImPlot3DRange_Size((ImPlot3DRange*)(NativePtr));
            return ret;
        }
    }
}
