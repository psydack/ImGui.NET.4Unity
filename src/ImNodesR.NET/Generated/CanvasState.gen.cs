using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImNodesRNET
{
    public unsafe partial struct CanvasState
    {
        public float Zoom;
        public Vector2 Offset;
        public ImColor Colors_0;
        public ImColor Colors_1;
        public ImColor Colors_2;
        public ImColor Colors_3;
        public ImColor Colors_4;
        public ImColor Colors_5;
        public ImColor Colors_6;
        public ImColor Colors_7;
        public CanvasStyle Style;
        public IntPtr _Impl;
    }
    public unsafe partial struct CanvasStatePtr
    {
        public CanvasState* NativePtr { get; }
        public CanvasStatePtr(CanvasState* nativePtr) => NativePtr = nativePtr;
        public CanvasStatePtr(IntPtr nativePtr) => NativePtr = (CanvasState*)nativePtr;
        public static implicit operator CanvasStatePtr(CanvasState* nativePtr) => new CanvasStatePtr(nativePtr);
        public static implicit operator CanvasState* (CanvasStatePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator CanvasStatePtr(IntPtr nativePtr) => new CanvasStatePtr(nativePtr);
        public ref float Zoom => ref Unsafe.AsRef<float>(&NativePtr->Zoom);
        public ref Vector2 Offset => ref Unsafe.AsRef<Vector2>(&NativePtr->Offset);
        public RangeAccessor<ImColor> Colors => new RangeAccessor<ImColor>(&NativePtr->Colors_0, 8);
        public ref CanvasStyle Style => ref Unsafe.AsRef<CanvasStyle>(&NativePtr->Style);
        public ref IntPtr _Impl => ref Unsafe.AsRef<IntPtr>(&NativePtr->_Impl);
        public void Destroy()
        {
            ImNodesRNative.CanvasState_destroy((CanvasState*)(NativePtr));
        }
    }
}
