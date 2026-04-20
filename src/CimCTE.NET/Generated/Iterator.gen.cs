using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace CimCTENET
{
    public unsafe partial struct Iterator
    {
    }
    public unsafe partial struct IteratorPtr
    {
        public Iterator* NativePtr { get; }
        public IteratorPtr(Iterator* nativePtr) => NativePtr = nativePtr;
        public IteratorPtr(IntPtr nativePtr) => NativePtr = (Iterator*)nativePtr;
        public static implicit operator IteratorPtr(Iterator* nativePtr) => new IteratorPtr(nativePtr);
        public static implicit operator Iterator* (IteratorPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator IteratorPtr(IntPtr nativePtr) => new IteratorPtr(nativePtr);
        public void Destroy()
        {
            CimCTENative.Iterator_destroy((Iterator*)(NativePtr));
        }
    }
}
