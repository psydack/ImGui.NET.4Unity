using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotSpec
    {
        public Vector4 LineColor;
        public uint* LineColors;
        public float LineWeight;
        public Vector4 FillColor;
        public uint* FillColors;
        public float FillAlpha;
        public ImPlotMarker Marker;
        public float MarkerSize;
        public float* MarkerSizes;
        public Vector4 MarkerLineColor;
        public uint* MarkerLineColors;
        public Vector4 MarkerFillColor;
        public uint* MarkerFillColors;
        public float Size;
        public int Offset;
        public int Stride;
        public ImPlotItemFlags Flags;
    }
    public unsafe partial struct ImPlotSpecPtr
    {
        public ImPlotSpec* NativePtr { get; }
        public ImPlotSpecPtr(ImPlotSpec* nativePtr) => NativePtr = nativePtr;
        public ImPlotSpecPtr(IntPtr nativePtr) => NativePtr = (ImPlotSpec*)nativePtr;
        public static implicit operator ImPlotSpecPtr(ImPlotSpec* nativePtr) => new ImPlotSpecPtr(nativePtr);
        public static implicit operator ImPlotSpec* (ImPlotSpecPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotSpecPtr(IntPtr nativePtr) => new ImPlotSpecPtr(nativePtr);
        public ref Vector4 LineColor => ref Unsafe.AsRef<Vector4>(&NativePtr->LineColor);
        public IntPtr LineColors { get => (IntPtr)NativePtr->LineColors; set => NativePtr->LineColors = (uint*)value; }
        public ref float LineWeight => ref Unsafe.AsRef<float>(&NativePtr->LineWeight);
        public ref Vector4 FillColor => ref Unsafe.AsRef<Vector4>(&NativePtr->FillColor);
        public IntPtr FillColors { get => (IntPtr)NativePtr->FillColors; set => NativePtr->FillColors = (uint*)value; }
        public ref float FillAlpha => ref Unsafe.AsRef<float>(&NativePtr->FillAlpha);
        public ref ImPlotMarker Marker => ref Unsafe.AsRef<ImPlotMarker>(&NativePtr->Marker);
        public ref float MarkerSize => ref Unsafe.AsRef<float>(&NativePtr->MarkerSize);
        public IntPtr MarkerSizes { get => (IntPtr)NativePtr->MarkerSizes; set => NativePtr->MarkerSizes = (float*)value; }
        public ref Vector4 MarkerLineColor => ref Unsafe.AsRef<Vector4>(&NativePtr->MarkerLineColor);
        public IntPtr MarkerLineColors { get => (IntPtr)NativePtr->MarkerLineColors; set => NativePtr->MarkerLineColors = (uint*)value; }
        public ref Vector4 MarkerFillColor => ref Unsafe.AsRef<Vector4>(&NativePtr->MarkerFillColor);
        public IntPtr MarkerFillColors { get => (IntPtr)NativePtr->MarkerFillColors; set => NativePtr->MarkerFillColors = (uint*)value; }
        public ref float Size => ref Unsafe.AsRef<float>(&NativePtr->Size);
        public ref int Offset => ref Unsafe.AsRef<int>(&NativePtr->Offset);
        public ref int Stride => ref Unsafe.AsRef<int>(&NativePtr->Stride);
        public ref ImPlotItemFlags Flags => ref Unsafe.AsRef<ImPlotItemFlags>(&NativePtr->Flags);
        public void Destroy()
        {
            ImPlotNative.ImPlotSpec_destroy((ImPlotSpec*)(NativePtr));
        }
        public void SetProp(ImPlotProp prop, float v)
        {
            ImPlotNative.ImPlotSpec_SetProp_Float((ImPlotSpec*)(NativePtr), prop, v);
        }
        public void SetProp(ImPlotProp prop, double v)
        {
            ImPlotNative.ImPlotSpec_SetProp_double((ImPlotSpec*)(NativePtr), prop, v);
        }
        public void SetProp(ImPlotProp prop, sbyte v)
        {
            ImPlotNative.ImPlotSpec_SetProp_S8((ImPlotSpec*)(NativePtr), prop, v);
        }
        public void SetProp(ImPlotProp prop, byte v)
        {
            ImPlotNative.ImPlotSpec_SetProp_U8((ImPlotSpec*)(NativePtr), prop, v);
        }
        public void SetProp(ImPlotProp prop, short v)
        {
            ImPlotNative.ImPlotSpec_SetProp_S16((ImPlotSpec*)(NativePtr), prop, v);
        }
        public void SetProp(ImPlotProp prop, ushort v)
        {
            ImPlotNative.ImPlotSpec_SetProp_U16((ImPlotSpec*)(NativePtr), prop, v);
        }
        public void SetProp(ImPlotProp prop, int v)
        {
            ImPlotNative.ImPlotSpec_SetProp_S32((ImPlotSpec*)(NativePtr), prop, v);
        }
        public void SetProp(ImPlotProp prop, uint v)
        {
            ImPlotNative.ImPlotSpec_SetProp_U32((ImPlotSpec*)(NativePtr), prop, v);
        }
        public void SetProp(ImPlotProp prop, long v)
        {
            ImPlotNative.ImPlotSpec_SetProp_S64((ImPlotSpec*)(NativePtr), prop, v);
        }
        public void SetProp(ImPlotProp prop, ulong v)
        {
            ImPlotNative.ImPlotSpec_SetProp_U64((ImPlotSpec*)(NativePtr), prop, v);
        }
        public void SetProp(ImPlotProp prop, ref uint v)
        {
            fixed (uint* native_v = &v)
            {
                ImPlotNative.ImPlotSpec_SetProp_U32Ptr((ImPlotSpec*)(NativePtr), prop, native_v);
            }
        }
        public void SetProp(ImPlotProp prop, ref float v)
        {
            fixed (float* native_v = &v)
            {
                ImPlotNative.ImPlotSpec_SetProp_FloatPtr((ImPlotSpec*)(NativePtr), prop, native_v);
            }
        }
        public void SetProp(ImPlotProp prop, Vector4 v)
        {
            ImPlotNative.ImPlotSpec_SetProp_Vec4((ImPlotSpec*)(NativePtr), prop, v);
        }
    }
}
