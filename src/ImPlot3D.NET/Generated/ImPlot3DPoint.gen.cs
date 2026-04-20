using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlot3DNET
{
    public unsafe partial struct ImPlot3DPoint
    {
        public double x;
        public double y;
        public double z;
    }
    public unsafe partial struct ImPlot3DPointPtr
    {
        public ImPlot3DPoint* NativePtr { get; }
        public ImPlot3DPointPtr(ImPlot3DPoint* nativePtr) => NativePtr = nativePtr;
        public ImPlot3DPointPtr(IntPtr nativePtr) => NativePtr = (ImPlot3DPoint*)nativePtr;
        public static implicit operator ImPlot3DPointPtr(ImPlot3DPoint* nativePtr) => new ImPlot3DPointPtr(nativePtr);
        public static implicit operator ImPlot3DPoint* (ImPlot3DPointPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlot3DPointPtr(IntPtr nativePtr) => new ImPlot3DPointPtr(nativePtr);
        public ref double x => ref Unsafe.AsRef<double>(&NativePtr->x);
        public ref double y => ref Unsafe.AsRef<double>(&NativePtr->y);
        public ref double z => ref Unsafe.AsRef<double>(&NativePtr->z);
        public ImPlot3DPoint Cross(ImPlot3DPoint rhs)
        {
            ImPlot3DPoint ret = ImPlot3DNative.ImPlot3DPoint_Cross((ImPlot3DPoint*)(NativePtr), rhs);
            return ret;
        }
        public void Destroy()
        {
            ImPlot3DNative.ImPlot3DPoint_destroy((ImPlot3DPoint*)(NativePtr));
        }
        public double Dot(ImPlot3DPoint rhs)
        {
            double ret = ImPlot3DNative.ImPlot3DPoint_Dot((ImPlot3DPoint*)(NativePtr), rhs);
            return ret;
        }
        public bool IsNaN()
        {
            byte ret = ImPlot3DNative.ImPlot3DPoint_IsNaN((ImPlot3DPoint*)(NativePtr));
            return ret != 0;
        }
        public double Length()
        {
            double ret = ImPlot3DNative.ImPlot3DPoint_Length((ImPlot3DPoint*)(NativePtr));
            return ret;
        }
        public double LengthSquared()
        {
            double ret = ImPlot3DNative.ImPlot3DPoint_LengthSquared((ImPlot3DPoint*)(NativePtr));
            return ret;
        }
        public void Normalize()
        {
            ImPlot3DNative.ImPlot3DPoint_Normalize((ImPlot3DPoint*)(NativePtr));
        }
        public ImPlot3DPoint Normalized()
        {
            ImPlot3DPoint ret = ImPlot3DNative.ImPlot3DPoint_Normalized((ImPlot3DPoint*)(NativePtr));
            return ret;
        }
    }
}
