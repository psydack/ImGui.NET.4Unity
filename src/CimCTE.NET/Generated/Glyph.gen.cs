using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace CimCTENET
{
    public unsafe partial struct Glyph
    {
        public ushort codepoint;
        public Color color;
    }
    public unsafe partial struct GlyphPtr
    {
        public Glyph* NativePtr { get; }
        public GlyphPtr(Glyph* nativePtr) => NativePtr = nativePtr;
        public GlyphPtr(IntPtr nativePtr) => NativePtr = (Glyph*)nativePtr;
        public static implicit operator GlyphPtr(Glyph* nativePtr) => new GlyphPtr(nativePtr);
        public static implicit operator Glyph* (GlyphPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator GlyphPtr(IntPtr nativePtr) => new GlyphPtr(nativePtr);
        public ref ushort codepoint => ref Unsafe.AsRef<ushort>(&NativePtr->codepoint);
        public ref Color color => ref Unsafe.AsRef<Color>(&NativePtr->color);
        public void Destroy()
        {
            CimCTENative.Glyph_destroy((Glyph*)(NativePtr));
        }
    }
}
