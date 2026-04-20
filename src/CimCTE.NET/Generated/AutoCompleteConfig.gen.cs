using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace CimCTENET
{
    public unsafe partial struct AutoCompleteConfig
    {
    }
    public unsafe partial struct AutoCompleteConfigPtr
    {
        public AutoCompleteConfig* NativePtr { get; }
        public AutoCompleteConfigPtr(AutoCompleteConfig* nativePtr) => NativePtr = nativePtr;
        public AutoCompleteConfigPtr(IntPtr nativePtr) => NativePtr = (AutoCompleteConfig*)nativePtr;
        public static implicit operator AutoCompleteConfigPtr(AutoCompleteConfig* nativePtr) => new AutoCompleteConfigPtr(nativePtr);
        public static implicit operator AutoCompleteConfig* (AutoCompleteConfigPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator AutoCompleteConfigPtr(IntPtr nativePtr) => new AutoCompleteConfigPtr(nativePtr);
    }
}
