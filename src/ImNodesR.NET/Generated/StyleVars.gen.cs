using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImNodesRNET
{
    public unsafe partial struct StyleVars
    {
        public float SlotRadius;
        public Vector2 ItemSpacing;
        public StyleVarsColors Colors;
    }
    public unsafe partial struct StyleVarsPtr
    {
        public StyleVars* NativePtr { get; }
        public StyleVarsPtr(StyleVars* nativePtr) => NativePtr = nativePtr;
        public StyleVarsPtr(IntPtr nativePtr) => NativePtr = (StyleVars*)nativePtr;
        public static implicit operator StyleVarsPtr(StyleVars* nativePtr) => new StyleVarsPtr(nativePtr);
        public static implicit operator StyleVars* (StyleVarsPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator StyleVarsPtr(IntPtr nativePtr) => new StyleVarsPtr(nativePtr);
        public ref float SlotRadius => ref Unsafe.AsRef<float>(&NativePtr->SlotRadius);
        public ref Vector2 ItemSpacing => ref Unsafe.AsRef<Vector2>(&NativePtr->ItemSpacing);
        public ref StyleVarsColors Colors => ref Unsafe.AsRef<StyleVarsColors>(&NativePtr->Colors);
    }
}
