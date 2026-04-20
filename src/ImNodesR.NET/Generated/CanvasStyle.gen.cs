using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImNodesRNET
{
    public unsafe partial struct CanvasStyle
    {
        public float CurveThickness;
        public float ConnectionIndent;
        public float GridSpacing;
        public float CurveStrength;
        public float NodeRounding;
        public Vector2 NodeSpacing;
    }
    public unsafe partial struct CanvasStylePtr
    {
        public CanvasStyle* NativePtr { get; }
        public CanvasStylePtr(CanvasStyle* nativePtr) => NativePtr = nativePtr;
        public CanvasStylePtr(IntPtr nativePtr) => NativePtr = (CanvasStyle*)nativePtr;
        public static implicit operator CanvasStylePtr(CanvasStyle* nativePtr) => new CanvasStylePtr(nativePtr);
        public static implicit operator CanvasStyle* (CanvasStylePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator CanvasStylePtr(IntPtr nativePtr) => new CanvasStylePtr(nativePtr);
        public ref float CurveThickness => ref Unsafe.AsRef<float>(&NativePtr->CurveThickness);
        public ref float ConnectionIndent => ref Unsafe.AsRef<float>(&NativePtr->ConnectionIndent);
        public ref float GridSpacing => ref Unsafe.AsRef<float>(&NativePtr->GridSpacing);
        public ref float CurveStrength => ref Unsafe.AsRef<float>(&NativePtr->CurveStrength);
        public ref float NodeRounding => ref Unsafe.AsRef<float>(&NativePtr->NodeRounding);
        public ref Vector2 NodeSpacing => ref Unsafe.AsRef<Vector2>(&NativePtr->NodeSpacing);
    }
}
