using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace CimCTENET
{
    public unsafe partial struct Decorator
    {
        public int line;
        public float width;
        public float height;
        public Vector2 glyphSize;
        public void* userData;
    }
    public unsafe partial struct DecoratorPtr
    {
        public Decorator* NativePtr { get; }
        public DecoratorPtr(Decorator* nativePtr) => NativePtr = nativePtr;
        public DecoratorPtr(IntPtr nativePtr) => NativePtr = (Decorator*)nativePtr;
        public static implicit operator DecoratorPtr(Decorator* nativePtr) => new DecoratorPtr(nativePtr);
        public static implicit operator Decorator* (DecoratorPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator DecoratorPtr(IntPtr nativePtr) => new DecoratorPtr(nativePtr);
        public ref int line => ref Unsafe.AsRef<int>(&NativePtr->line);
        public ref float width => ref Unsafe.AsRef<float>(&NativePtr->width);
        public ref float height => ref Unsafe.AsRef<float>(&NativePtr->height);
        public ref Vector2 glyphSize => ref Unsafe.AsRef<Vector2>(&NativePtr->glyphSize);
        public IntPtr userData { get => (IntPtr)NativePtr->userData; set => NativePtr->userData = (void*)value; }
    }
}
