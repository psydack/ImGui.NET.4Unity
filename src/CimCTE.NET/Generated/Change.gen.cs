using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace CimCTENET
{
    public unsafe partial struct Change
    {
    }
    public unsafe partial struct ChangePtr
    {
        public Change* NativePtr { get; }
        public ChangePtr(Change* nativePtr) => NativePtr = nativePtr;
        public ChangePtr(IntPtr nativePtr) => NativePtr = (Change*)nativePtr;
        public static implicit operator ChangePtr(Change* nativePtr) => new ChangePtr(nativePtr);
        public static implicit operator Change* (ChangePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ChangePtr(IntPtr nativePtr) => new ChangePtr(nativePtr);
    }
}
