using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlot3DNET
{
    public unsafe partial struct ImPlot3DSpec
    {
        public Vector4 LineColor;
        public uint* LineColors;
        public float LineWeight;
        public Vector4 FillColor;
        public uint* FillColors;
        public float FillAlpha;
        public ImPlot3DMarker Marker;
        public float MarkerSize;
        public float* MarkerSizes;
        public Vector4 MarkerLineColor;
        public uint* MarkerLineColors;
        public Vector4 MarkerFillColor;
        public uint* MarkerFillColors;
        public int Offset;
        public int Stride;
        public ImPlot3DItemFlags Flags;
    }
    public unsafe partial struct ImPlot3DSpecPtr
    {
        public ImPlot3DSpec* NativePtr { get; }
        public ImPlot3DSpecPtr(ImPlot3DSpec* nativePtr) => NativePtr = nativePtr;
        public ImPlot3DSpecPtr(IntPtr nativePtr) => NativePtr = (ImPlot3DSpec*)nativePtr;
        public static implicit operator ImPlot3DSpecPtr(ImPlot3DSpec* nativePtr) => new ImPlot3DSpecPtr(nativePtr);
        public static implicit operator ImPlot3DSpec* (ImPlot3DSpecPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlot3DSpecPtr(IntPtr nativePtr) => new ImPlot3DSpecPtr(nativePtr);
        public ref Vector4 LineColor => ref Unsafe.AsRef<Vector4>(&NativePtr->LineColor);
        public IntPtr LineColors { get => (IntPtr)NativePtr->LineColors; set => NativePtr->LineColors = (uint*)value; }
        public ref float LineWeight => ref Unsafe.AsRef<float>(&NativePtr->LineWeight);
        public ref Vector4 FillColor => ref Unsafe.AsRef<Vector4>(&NativePtr->FillColor);
        public IntPtr FillColors { get => (IntPtr)NativePtr->FillColors; set => NativePtr->FillColors = (uint*)value; }
        public ref float FillAlpha => ref Unsafe.AsRef<float>(&NativePtr->FillAlpha);
        public ref ImPlot3DMarker Marker => ref Unsafe.AsRef<ImPlot3DMarker>(&NativePtr->Marker);
        public ref float MarkerSize => ref Unsafe.AsRef<float>(&NativePtr->MarkerSize);
        public IntPtr MarkerSizes { get => (IntPtr)NativePtr->MarkerSizes; set => NativePtr->MarkerSizes = (float*)value; }
        public ref Vector4 MarkerLineColor => ref Unsafe.AsRef<Vector4>(&NativePtr->MarkerLineColor);
        public IntPtr MarkerLineColors { get => (IntPtr)NativePtr->MarkerLineColors; set => NativePtr->MarkerLineColors = (uint*)value; }
        public ref Vector4 MarkerFillColor => ref Unsafe.AsRef<Vector4>(&NativePtr->MarkerFillColor);
        public IntPtr MarkerFillColors { get => (IntPtr)NativePtr->MarkerFillColors; set => NativePtr->MarkerFillColors = (uint*)value; }
        public ref int Offset => ref Unsafe.AsRef<int>(&NativePtr->Offset);
        public ref int Stride => ref Unsafe.AsRef<int>(&NativePtr->Stride);
        public ref ImPlot3DItemFlags Flags => ref Unsafe.AsRef<ImPlot3DItemFlags>(&NativePtr->Flags);
        public void Destroy()
        {
            ImPlot3DNative.ImPlot3DSpec_destroy((ImPlot3DSpec*)(NativePtr));
        }
        public void SetProp(ImPlot3DProp prop, float v)
        {
            ImPlot3DNative.ImPlot3DSpec_SetProp_Float((ImPlot3DSpec*)(NativePtr), prop, v);
        }
        public void SetProp(ImPlot3DProp prop, double v)
        {
            ImPlot3DNative.ImPlot3DSpec_SetProp_double((ImPlot3DSpec*)(NativePtr), prop, v);
        }
        public void SetProp(ImPlot3DProp prop, sbyte v)
        {
            ImPlot3DNative.ImPlot3DSpec_SetProp_S8((ImPlot3DSpec*)(NativePtr), prop, v);
        }
        public void SetProp(ImPlot3DProp prop, byte v)
        {
            ImPlot3DNative.ImPlot3DSpec_SetProp_U8((ImPlot3DSpec*)(NativePtr), prop, v);
        }
        public void SetProp(ImPlot3DProp prop, short v)
        {
            ImPlot3DNative.ImPlot3DSpec_SetProp_S16((ImPlot3DSpec*)(NativePtr), prop, v);
        }
        public void SetProp(ImPlot3DProp prop, ushort v)
        {
            ImPlot3DNative.ImPlot3DSpec_SetProp_U16((ImPlot3DSpec*)(NativePtr), prop, v);
        }
        public void SetProp(ImPlot3DProp prop, int v)
        {
            ImPlot3DNative.ImPlot3DSpec_SetProp_S32((ImPlot3DSpec*)(NativePtr), prop, v);
        }
        public void SetProp(ImPlot3DProp prop, uint v)
        {
            ImPlot3DNative.ImPlot3DSpec_SetProp_U32((ImPlot3DSpec*)(NativePtr), prop, v);
        }
        public void SetProp(ImPlot3DProp prop, long v)
        {
            ImPlot3DNative.ImPlot3DSpec_SetProp_S64((ImPlot3DSpec*)(NativePtr), prop, v);
        }
        public void SetProp(ImPlot3DProp prop, ulong v)
        {
            ImPlot3DNative.ImPlot3DSpec_SetProp_U64((ImPlot3DSpec*)(NativePtr), prop, v);
        }
        public void SetProp(ImPlot3DProp prop, ref uint v)
        {
            fixed (uint* native_v = &v)
            {
                ImPlot3DNative.ImPlot3DSpec_SetProp_U32Ptr((ImPlot3DSpec*)(NativePtr), prop, native_v);
            }
        }
        public void SetProp(ImPlot3DProp prop, ref float v)
        {
            fixed (float* native_v = &v)
            {
                ImPlot3DNative.ImPlot3DSpec_SetProp_FloatPtr((ImPlot3DSpec*)(NativePtr), prop, native_v);
            }
        }
        public void SetProp(ImPlot3DProp prop, Vector4 v)
        {
            ImPlot3DNative.ImPlot3DSpec_SetProp_Vec4((ImPlot3DSpec*)(NativePtr), prop, v);
        }
    }
}
