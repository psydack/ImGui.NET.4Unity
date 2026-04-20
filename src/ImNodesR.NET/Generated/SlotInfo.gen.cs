using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImNodesRNET
{
    public unsafe partial struct SlotInfo
    {
        public byte* title;
        public int kind;
    }
    public unsafe partial struct SlotInfoPtr
    {
        public SlotInfo* NativePtr { get; }
        public SlotInfoPtr(SlotInfo* nativePtr) => NativePtr = nativePtr;
        public SlotInfoPtr(IntPtr nativePtr) => NativePtr = (SlotInfo*)nativePtr;
        public static implicit operator SlotInfoPtr(SlotInfo* nativePtr) => new SlotInfoPtr(nativePtr);
        public static implicit operator SlotInfo* (SlotInfoPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator SlotInfoPtr(IntPtr nativePtr) => new SlotInfoPtr(nativePtr);
        public IntPtr title { get => (IntPtr)NativePtr->title; set => NativePtr->title = (byte*)value; }
        public ref int kind => ref Unsafe.AsRef<int>(&NativePtr->kind);
    }
}
