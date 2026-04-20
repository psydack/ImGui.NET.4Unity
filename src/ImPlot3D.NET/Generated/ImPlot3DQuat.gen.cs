using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlot3DNET
{
    public unsafe partial struct ImPlot3DQuat
    {
        public double x;
        public double y;
        public double z;
        public double w;
    }
    public unsafe partial struct ImPlot3DQuatPtr
    {
        public ImPlot3DQuat* NativePtr { get; }
        public ImPlot3DQuatPtr(ImPlot3DQuat* nativePtr) => NativePtr = nativePtr;
        public ImPlot3DQuatPtr(IntPtr nativePtr) => NativePtr = (ImPlot3DQuat*)nativePtr;
        public static implicit operator ImPlot3DQuatPtr(ImPlot3DQuat* nativePtr) => new ImPlot3DQuatPtr(nativePtr);
        public static implicit operator ImPlot3DQuat* (ImPlot3DQuatPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlot3DQuatPtr(IntPtr nativePtr) => new ImPlot3DQuatPtr(nativePtr);
        public ref double x => ref Unsafe.AsRef<double>(&NativePtr->x);
        public ref double y => ref Unsafe.AsRef<double>(&NativePtr->y);
        public ref double z => ref Unsafe.AsRef<double>(&NativePtr->z);
        public ref double w => ref Unsafe.AsRef<double>(&NativePtr->w);
        public ImPlot3DQuat Conjugate()
        {
            ImPlot3DQuat ret = ImPlot3DNative.ImPlot3DQuat_Conjugate((ImPlot3DQuat*)(NativePtr));
            return ret;
        }
        public void Destroy()
        {
            ImPlot3DNative.ImPlot3DQuat_destroy((ImPlot3DQuat*)(NativePtr));
        }
        public double Dot(ImPlot3DQuat rhs)
        {
            double ret = ImPlot3DNative.ImPlot3DQuat_Dot((ImPlot3DQuat*)(NativePtr), rhs);
            return ret;
        }
        public ImPlot3DQuat FromElAz(double elevation, double azimuth)
        {
            ImPlot3DQuat ret = ImPlot3DNative.ImPlot3DQuat_FromElAz(elevation, azimuth);
            return ret;
        }
        public ImPlot3DQuat FromTwoVectors(ImPlot3DPoint v0, ImPlot3DPoint v1)
        {
            ImPlot3DQuat ret = ImPlot3DNative.ImPlot3DQuat_FromTwoVectors(v0, v1);
            return ret;
        }
        public ImPlot3DQuat Inverse()
        {
            ImPlot3DQuat ret = ImPlot3DNative.ImPlot3DQuat_Inverse((ImPlot3DQuat*)(NativePtr));
            return ret;
        }
        public double Length()
        {
            double ret = ImPlot3DNative.ImPlot3DQuat_Length((ImPlot3DQuat*)(NativePtr));
            return ret;
        }
        public ImPlot3DQuatPtr Normalize()
        {
            ImPlot3DQuat* ret = ImPlot3DNative.ImPlot3DQuat_Normalize((ImPlot3DQuat*)(NativePtr));
            return new ImPlot3DQuatPtr(ret);
        }
        public ImPlot3DQuat Normalized()
        {
            ImPlot3DQuat ret = ImPlot3DNative.ImPlot3DQuat_Normalized((ImPlot3DQuat*)(NativePtr));
            return ret;
        }
        public ImPlot3DQuat Slerp(ImPlot3DQuat q1, ImPlot3DQuat q2, double t)
        {
            ImPlot3DQuat ret = ImPlot3DNative.ImPlot3DQuat_Slerp(q1, q2, t);
            return ret;
        }
    }
}
