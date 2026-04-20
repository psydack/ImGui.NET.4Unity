using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace CimCTENET
{
    public unsafe partial struct CursorPosition
    {
        public int line;
        public int column;
    }
    public unsafe partial struct CursorPositionPtr
    {
        public CursorPosition* NativePtr { get; }
        public CursorPositionPtr(CursorPosition* nativePtr) => NativePtr = nativePtr;
        public CursorPositionPtr(IntPtr nativePtr) => NativePtr = (CursorPosition*)nativePtr;
        public static implicit operator CursorPositionPtr(CursorPosition* nativePtr) => new CursorPositionPtr(nativePtr);
        public static implicit operator CursorPosition* (CursorPositionPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator CursorPositionPtr(IntPtr nativePtr) => new CursorPositionPtr(nativePtr);
        public ref int line => ref Unsafe.AsRef<int>(&NativePtr->line);
        public ref int column => ref Unsafe.AsRef<int>(&NativePtr->column);
        public void Destroy()
        {
            CimCTENative.CursorPosition_destroy((CursorPosition*)(NativePtr));
        }
    }
}
