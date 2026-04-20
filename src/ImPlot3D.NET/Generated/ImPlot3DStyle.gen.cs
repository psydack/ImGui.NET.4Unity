using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlot3DNET
{
    public unsafe partial struct ImPlot3DStyle
    {
        public float LineWeight;
        public int Marker;
        public float MarkerSize;
        public float FillAlpha;
        public Vector2 PlotDefaultSize;
        public Vector2 PlotMinSize;
        public Vector2 PlotPadding;
        public Vector2 LabelPadding;
        public float ViewScaleFactor;
        public Vector2 LegendPadding;
        public Vector2 LegendInnerPadding;
        public Vector2 LegendSpacing;
        public Vector4 Colors_0;
        public Vector4 Colors_1;
        public Vector4 Colors_2;
        public Vector4 Colors_3;
        public Vector4 Colors_4;
        public Vector4 Colors_5;
        public Vector4 Colors_6;
        public Vector4 Colors_7;
        public Vector4 Colors_8;
        public Vector4 Colors_9;
        public Vector4 Colors_10;
        public Vector4 Colors_11;
        public Vector4 Colors_12;
        public Vector4 Colors_13;
        public ImPlot3DColormap Colormap;
    }
    public unsafe partial struct ImPlot3DStylePtr
    {
        public ImPlot3DStyle* NativePtr { get; }
        public ImPlot3DStylePtr(ImPlot3DStyle* nativePtr) => NativePtr = nativePtr;
        public ImPlot3DStylePtr(IntPtr nativePtr) => NativePtr = (ImPlot3DStyle*)nativePtr;
        public static implicit operator ImPlot3DStylePtr(ImPlot3DStyle* nativePtr) => new ImPlot3DStylePtr(nativePtr);
        public static implicit operator ImPlot3DStyle* (ImPlot3DStylePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlot3DStylePtr(IntPtr nativePtr) => new ImPlot3DStylePtr(nativePtr);
        public ref float LineWeight => ref Unsafe.AsRef<float>(&NativePtr->LineWeight);
        public ref int Marker => ref Unsafe.AsRef<int>(&NativePtr->Marker);
        public ref float MarkerSize => ref Unsafe.AsRef<float>(&NativePtr->MarkerSize);
        public ref float FillAlpha => ref Unsafe.AsRef<float>(&NativePtr->FillAlpha);
        public ref Vector2 PlotDefaultSize => ref Unsafe.AsRef<Vector2>(&NativePtr->PlotDefaultSize);
        public ref Vector2 PlotMinSize => ref Unsafe.AsRef<Vector2>(&NativePtr->PlotMinSize);
        public ref Vector2 PlotPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->PlotPadding);
        public ref Vector2 LabelPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->LabelPadding);
        public ref float ViewScaleFactor => ref Unsafe.AsRef<float>(&NativePtr->ViewScaleFactor);
        public ref Vector2 LegendPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->LegendPadding);
        public ref Vector2 LegendInnerPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->LegendInnerPadding);
        public ref Vector2 LegendSpacing => ref Unsafe.AsRef<Vector2>(&NativePtr->LegendSpacing);
        public RangeAccessor<Vector4> Colors => new RangeAccessor<Vector4>(&NativePtr->Colors_0, 14);
        public ref ImPlot3DColormap Colormap => ref Unsafe.AsRef<ImPlot3DColormap>(&NativePtr->Colormap);
        public void Destroy()
        {
            ImPlot3DNative.ImPlot3DStyle_destroy((ImPlot3DStyle*)(NativePtr));
        }
        public Vector4 GetColor(ImPlot3DCol idx)
        {
            Vector4 ret = ImPlot3DNative.ImPlot3DStyle_GetColor((ImPlot3DStyle*)(NativePtr), idx);
            return ret;
        }
        public void SetColor(ImPlot3DCol idx, Vector4 col)
        {
            ImPlot3DNative.ImPlot3DStyle_SetColor((ImPlot3DStyle*)(NativePtr), idx, col);
        }
    }
}
