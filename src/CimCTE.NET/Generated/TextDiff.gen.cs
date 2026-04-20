using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace CimCTENET
{
    public unsafe partial struct TextDiff
    {
        public TextEditor _TextEditor;
    }
    public unsafe partial struct TextDiffPtr
    {
        public TextDiff* NativePtr { get; }
        public TextDiffPtr(TextDiff* nativePtr) => NativePtr = nativePtr;
        public TextDiffPtr(IntPtr nativePtr) => NativePtr = (TextDiff*)nativePtr;
        public static implicit operator TextDiffPtr(TextDiff* nativePtr) => new TextDiffPtr(nativePtr);
        public static implicit operator TextDiff* (TextDiffPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator TextDiffPtr(IntPtr nativePtr) => new TextDiffPtr(nativePtr);
        public ref TextEditor _TextEditor => ref Unsafe.AsRef<TextEditor>(&NativePtr->_TextEditor);
        public void Destroy()
        {
            CimCTENative.TextDiff_destroy((TextDiff*)(NativePtr));
        }
        public bool GetSideBySideMode()
        {
            byte ret = CimCTENative.TextDiff_GetSideBySideMode((TextDiff*)(NativePtr));
            return ret != 0;
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public void Render(ReadOnlySpan<char> title)
        {
            byte* native_title;
            int title_byteCount = 0;
            if (title != null)
            {
                title_byteCount = Encoding.UTF8.GetByteCount(title);
                if (title_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_title = Util.Allocate(title_byteCount + 1);
                }
                else
                {
                    byte* native_title_stackBytes = stackalloc byte[title_byteCount + 1];
                    native_title = native_title_stackBytes;
                }
                int native_title_offset = Util.GetUtf8(title, native_title, title_byteCount);
                native_title[native_title_offset] = 0;
            }
            else { native_title = null; }
            Vector2 size = new Vector2();
            byte border = 0;
            CimCTENative.TextDiff_Render((TextDiff*)(NativePtr), native_title, size, border);
            if (title_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_title);
            }
        }
#endif
        public void Render(string title)
        {
            byte* native_title;
            int title_byteCount = 0;
            if (title != null)
            {
                title_byteCount = Encoding.UTF8.GetByteCount(title);
                if (title_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_title = Util.Allocate(title_byteCount + 1);
                }
                else
                {
                    byte* native_title_stackBytes = stackalloc byte[title_byteCount + 1];
                    native_title = native_title_stackBytes;
                }
                int native_title_offset = Util.GetUtf8(title, native_title, title_byteCount);
                native_title[native_title_offset] = 0;
            }
            else { native_title = null; }
            Vector2 size = new Vector2();
            byte border = 0;
            CimCTENative.TextDiff_Render((TextDiff*)(NativePtr), native_title, size, border);
            if (title_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_title);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public void Render(ReadOnlySpan<char> title, Vector2 size)
        {
            byte* native_title;
            int title_byteCount = 0;
            if (title != null)
            {
                title_byteCount = Encoding.UTF8.GetByteCount(title);
                if (title_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_title = Util.Allocate(title_byteCount + 1);
                }
                else
                {
                    byte* native_title_stackBytes = stackalloc byte[title_byteCount + 1];
                    native_title = native_title_stackBytes;
                }
                int native_title_offset = Util.GetUtf8(title, native_title, title_byteCount);
                native_title[native_title_offset] = 0;
            }
            else { native_title = null; }
            byte border = 0;
            CimCTENative.TextDiff_Render((TextDiff*)(NativePtr), native_title, size, border);
            if (title_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_title);
            }
        }
#endif
        public void Render(string title, Vector2 size)
        {
            byte* native_title;
            int title_byteCount = 0;
            if (title != null)
            {
                title_byteCount = Encoding.UTF8.GetByteCount(title);
                if (title_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_title = Util.Allocate(title_byteCount + 1);
                }
                else
                {
                    byte* native_title_stackBytes = stackalloc byte[title_byteCount + 1];
                    native_title = native_title_stackBytes;
                }
                int native_title_offset = Util.GetUtf8(title, native_title, title_byteCount);
                native_title[native_title_offset] = 0;
            }
            else { native_title = null; }
            byte border = 0;
            CimCTENative.TextDiff_Render((TextDiff*)(NativePtr), native_title, size, border);
            if (title_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_title);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public void Render(ReadOnlySpan<char> title, Vector2 size, bool border)
        {
            byte* native_title;
            int title_byteCount = 0;
            if (title != null)
            {
                title_byteCount = Encoding.UTF8.GetByteCount(title);
                if (title_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_title = Util.Allocate(title_byteCount + 1);
                }
                else
                {
                    byte* native_title_stackBytes = stackalloc byte[title_byteCount + 1];
                    native_title = native_title_stackBytes;
                }
                int native_title_offset = Util.GetUtf8(title, native_title, title_byteCount);
                native_title[native_title_offset] = 0;
            }
            else { native_title = null; }
            byte native_border = border ? (byte)1 : (byte)0;
            CimCTENative.TextDiff_Render((TextDiff*)(NativePtr), native_title, size, native_border);
            if (title_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_title);
            }
        }
#endif
        public void Render(string title, Vector2 size, bool border)
        {
            byte* native_title;
            int title_byteCount = 0;
            if (title != null)
            {
                title_byteCount = Encoding.UTF8.GetByteCount(title);
                if (title_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_title = Util.Allocate(title_byteCount + 1);
                }
                else
                {
                    byte* native_title_stackBytes = stackalloc byte[title_byteCount + 1];
                    native_title = native_title_stackBytes;
                }
                int native_title_offset = Util.GetUtf8(title, native_title, title_byteCount);
                native_title[native_title_offset] = 0;
            }
            else { native_title = null; }
            byte native_border = border ? (byte)1 : (byte)0;
            CimCTENative.TextDiff_Render((TextDiff*)(NativePtr), native_title, size, native_border);
            if (title_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_title);
            }
        }
        public void SetColors(uint ac, uint dc)
        {
            CimCTENative.TextDiff_SetColors((TextDiff*)(NativePtr), ac, dc);
        }
        public void SetLanguage(ref Language l)
        {
            fixed (Language* native_l = &l)
            {
                CimCTENative.TextDiff_SetLanguage((TextDiff*)(NativePtr), native_l);
            }
        }
        public void SetSideBySideMode(bool flag)
        {
            byte native_flag = flag ? (byte)1 : (byte)0;
            CimCTENative.TextDiff_SetSideBySideMode((TextDiff*)(NativePtr), native_flag);
        }
        public void SetText(IntPtr left, IntPtr right)
        {
            CimCTENative.TextDiff_SetText((TextDiff*)(NativePtr), left, right);
        }
    }
}
