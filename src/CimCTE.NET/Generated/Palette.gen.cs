using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace CimCTENET
{
    public unsafe partial struct Palette
    {
    }
    public unsafe partial struct PalettePtr
    {
        public Palette* NativePtr { get; }
        public PalettePtr(Palette* nativePtr) => NativePtr = nativePtr;
        public PalettePtr(IntPtr nativePtr) => NativePtr = (Palette*)nativePtr;
        public static implicit operator PalettePtr(Palette* nativePtr) => new PalettePtr(nativePtr);
        public static implicit operator Palette* (PalettePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator PalettePtr(IntPtr nativePtr) => new PalettePtr(nativePtr);
        public uint get(Color color)
        {
            uint ret = CimCTENative.Palette_get((Palette*)(NativePtr), color);
            return ret;
        }
    }
}
