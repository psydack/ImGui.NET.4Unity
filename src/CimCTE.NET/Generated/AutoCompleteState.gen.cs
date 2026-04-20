using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace CimCTENET
{
    public unsafe partial struct AutoCompleteState
    {
    }
    public unsafe partial struct AutoCompleteStatePtr
    {
        public AutoCompleteState* NativePtr { get; }
        public AutoCompleteStatePtr(AutoCompleteState* nativePtr) => NativePtr = nativePtr;
        public AutoCompleteStatePtr(IntPtr nativePtr) => NativePtr = (AutoCompleteState*)nativePtr;
        public static implicit operator AutoCompleteStatePtr(AutoCompleteState* nativePtr) => new AutoCompleteStatePtr(nativePtr);
        public static implicit operator AutoCompleteState* (AutoCompleteStatePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator AutoCompleteStatePtr(IntPtr nativePtr) => new AutoCompleteStatePtr(nativePtr);
    }
}
