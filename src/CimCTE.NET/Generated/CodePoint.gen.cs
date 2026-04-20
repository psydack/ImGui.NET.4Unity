using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace CimCTENET
{
    public unsafe partial struct CodePoint
    {
    }
    public unsafe partial struct CodePointPtr
    {
        public CodePoint* NativePtr { get; }
        public CodePointPtr(CodePoint* nativePtr) => NativePtr = nativePtr;
        public CodePointPtr(IntPtr nativePtr) => NativePtr = (CodePoint*)nativePtr;
        public static implicit operator CodePointPtr(CodePoint* nativePtr) => new CodePointPtr(nativePtr);
        public static implicit operator CodePoint* (CodePointPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator CodePointPtr(IntPtr nativePtr) => new CodePointPtr(nativePtr);
        public bool isBracketCloser(ushort ch)
        {
            byte ret = CimCTENative.CodePoint_isBracketCloser(ch);
            return ret != 0;
        }
        public bool isBracketOpener(ushort ch)
        {
            byte ret = CimCTENative.CodePoint_isBracketOpener(ch);
            return ret != 0;
        }
        public bool isLetter(ushort codepoint)
        {
            byte ret = CimCTENative.CodePoint_isLetter(codepoint);
            return ret != 0;
        }
        public bool isLower(ushort codepoint)
        {
            byte ret = CimCTENative.CodePoint_isLower(codepoint);
            return ret != 0;
        }
        public bool isMatchingBrackets(ushort open, ushort close)
        {
            byte ret = CimCTENative.CodePoint_isMatchingBrackets(open, close);
            return ret != 0;
        }
        public bool isMatchingPair(ushort open, ushort close)
        {
            byte ret = CimCTENative.CodePoint_isMatchingPair(open, close);
            return ret != 0;
        }
        public bool isNumber(ushort codepoint)
        {
            byte ret = CimCTENative.CodePoint_isNumber(codepoint);
            return ret != 0;
        }
        public bool isPairCloser(ushort ch)
        {
            byte ret = CimCTENative.CodePoint_isPairCloser(ch);
            return ret != 0;
        }
        public bool isPairOpener(ushort ch)
        {
            byte ret = CimCTENative.CodePoint_isPairOpener(ch);
            return ret != 0;
        }
        public bool isUpper(ushort codepoint)
        {
            byte ret = CimCTENative.CodePoint_isUpper(codepoint);
            return ret != 0;
        }
        public bool isWhiteSpace(ushort codepoint)
        {
            byte ret = CimCTENative.CodePoint_isWhiteSpace(codepoint);
            return ret != 0;
        }
        public bool isWord(ushort codepoint)
        {
            byte ret = CimCTENative.CodePoint_isWord(codepoint);
            return ret != 0;
        }
        public bool isXidContinue(ushort codepoint)
        {
            byte ret = CimCTENative.CodePoint_isXidContinue(codepoint);
            return ret != 0;
        }
        public bool isXidStart(ushort codepoint)
        {
            byte ret = CimCTENative.CodePoint_isXidStart(codepoint);
            return ret != 0;
        }
        public IntPtr read(IntPtr i, IntPtr end, IntPtr codepoint)
        {
            ushort* native_codepoint = (ushort*)codepoint.ToPointer();
            IntPtr ret = CimCTENative.CodePoint_read(i, end, native_codepoint);
            return ret;
        }
        public IntPtr skipBOM(IntPtr i, IntPtr end)
        {
            IntPtr ret = CimCTENative.CodePoint_skipBOM(i, end);
            return ret;
        }
        public ushort toLower(ushort codepoint)
        {
            ushort ret = CimCTENative.CodePoint_toLower(codepoint);
            return ret;
        }
        public ushort toPairCloser(ushort ch)
        {
            ushort ret = CimCTENative.CodePoint_toPairCloser(ch);
            return ret;
        }
        public ushort toPairOpener(ushort ch)
        {
            ushort ret = CimCTENative.CodePoint_toPairOpener(ch);
            return ret;
        }
        public ushort toUpper(ushort codepoint)
        {
            ushort ret = CimCTENative.CodePoint_toUpper(codepoint);
            return ret;
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public uint write(ReadOnlySpan<char> i, ushort codepoint)
        {
            byte* native_i;
            int i_byteCount = 0;
            if (i != null)
            {
                i_byteCount = Encoding.UTF8.GetByteCount(i);
                if (i_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_i = Util.Allocate(i_byteCount + 1);
                }
                else
                {
                    byte* native_i_stackBytes = stackalloc byte[i_byteCount + 1];
                    native_i = native_i_stackBytes;
                }
                int native_i_offset = Util.GetUtf8(i, native_i, i_byteCount);
                native_i[native_i_offset] = 0;
            }
            else { native_i = null; }
            uint ret = CimCTENative.CodePoint_write(native_i, codepoint);
            if (i_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_i);
            }
            return ret;
        }
#endif
        public uint write(string i, ushort codepoint)
        {
            byte* native_i;
            int i_byteCount = 0;
            if (i != null)
            {
                i_byteCount = Encoding.UTF8.GetByteCount(i);
                if (i_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_i = Util.Allocate(i_byteCount + 1);
                }
                else
                {
                    byte* native_i_stackBytes = stackalloc byte[i_byteCount + 1];
                    native_i = native_i_stackBytes;
                }
                int native_i_offset = Util.GetUtf8(i, native_i, i_byteCount);
                native_i[native_i_offset] = 0;
            }
            else { native_i = null; }
            uint ret = CimCTENative.CodePoint_write(native_i, codepoint);
            if (i_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_i);
            }
            return ret;
        }
    }
}
