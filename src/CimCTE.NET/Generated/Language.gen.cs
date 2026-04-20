using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace CimCTENET
{
    public unsafe partial struct Language
    {
    }
    public unsafe partial struct LanguagePtr
    {
        public Language* NativePtr { get; }
        public LanguagePtr(Language* nativePtr) => NativePtr = nativePtr;
        public LanguagePtr(IntPtr nativePtr) => NativePtr = (Language*)nativePtr;
        public static implicit operator LanguagePtr(Language* nativePtr) => new LanguagePtr(nativePtr);
        public static implicit operator Language* (LanguagePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator LanguagePtr(IntPtr nativePtr) => new LanguagePtr(nativePtr);
        public IntPtr AngelScript()
        {
            IntPtr ret = CimCTENative.Language_AngelScript();
            return ret;
        }
        public IntPtr C()
        {
            IntPtr ret = CimCTENative.Language_C();
            return ret;
        }
        public IntPtr Cpp()
        {
            IntPtr ret = CimCTENative.Language_Cpp();
            return ret;
        }
        public IntPtr Cs()
        {
            IntPtr ret = CimCTENative.Language_Cs();
            return ret;
        }
        public IntPtr Glsl()
        {
            IntPtr ret = CimCTENative.Language_Glsl();
            return ret;
        }
        public IntPtr Hlsl()
        {
            IntPtr ret = CimCTENative.Language_Hlsl();
            return ret;
        }
        public IntPtr Json()
        {
            IntPtr ret = CimCTENative.Language_Json();
            return ret;
        }
        public IntPtr Lua()
        {
            IntPtr ret = CimCTENative.Language_Lua();
            return ret;
        }
        public IntPtr Markdown()
        {
            IntPtr ret = CimCTENative.Language_Markdown();
            return ret;
        }
        public IntPtr Python()
        {
            IntPtr ret = CimCTENative.Language_Python();
            return ret;
        }
        public IntPtr Sql()
        {
            IntPtr ret = CimCTENative.Language_Sql();
            return ret;
        }
    }
}
