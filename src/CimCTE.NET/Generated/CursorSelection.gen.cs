using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace CimCTENET
{
    public unsafe partial struct CursorSelection
    {
        public CursorPosition start;
        public CursorPosition end;
    }
    public unsafe partial struct CursorSelectionPtr
    {
        public CursorSelection* NativePtr { get; }
        public CursorSelectionPtr(CursorSelection* nativePtr) => NativePtr = nativePtr;
        public CursorSelectionPtr(IntPtr nativePtr) => NativePtr = (CursorSelection*)nativePtr;
        public static implicit operator CursorSelectionPtr(CursorSelection* nativePtr) => new CursorSelectionPtr(nativePtr);
        public static implicit operator CursorSelection* (CursorSelectionPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator CursorSelectionPtr(IntPtr nativePtr) => new CursorSelectionPtr(nativePtr);
        public ref CursorPosition start => ref Unsafe.AsRef<CursorPosition>(&NativePtr->start);
        public ref CursorPosition end => ref Unsafe.AsRef<CursorPosition>(&NativePtr->end);
        public void Destroy()
        {
            CimCTENative.CursorSelection_destroy((CursorSelection*)(NativePtr));
        }
    }
}
