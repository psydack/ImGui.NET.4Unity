using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace CimCTENET
{
    public unsafe partial struct Trie
    {
    }
    public unsafe partial struct TriePtr
    {
        public Trie* NativePtr { get; }
        public TriePtr(Trie* nativePtr) => NativePtr = nativePtr;
        public TriePtr(IntPtr nativePtr) => NativePtr = (Trie*)nativePtr;
        public static implicit operator TriePtr(Trie* nativePtr) => new TriePtr(nativePtr);
        public static implicit operator Trie* (TriePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator TriePtr(IntPtr nativePtr) => new TriePtr(nativePtr);
        public void clear()
        {
            CimCTENative.Trie_clear((Trie*)(NativePtr));
        }
        public void Destroy()
        {
            CimCTENative.Trie_destroy((Trie*)(NativePtr));
        }
        public void findSuggestions(IntPtr suggestions, IntPtr searchTerm)
        {
            uint limit = 20;
            uint maxSkippedLetters = 2;
            CimCTENative.Trie_findSuggestions((Trie*)(NativePtr), suggestions, searchTerm, limit, maxSkippedLetters);
        }
        public void findSuggestions(IntPtr suggestions, IntPtr searchTerm, uint limit)
        {
            uint maxSkippedLetters = 2;
            CimCTENative.Trie_findSuggestions((Trie*)(NativePtr), suggestions, searchTerm, limit, maxSkippedLetters);
        }
        public void findSuggestions(IntPtr suggestions, IntPtr searchTerm, uint limit, uint maxSkippedLetters)
        {
            CimCTENative.Trie_findSuggestions((Trie*)(NativePtr), suggestions, searchTerm, limit, maxSkippedLetters);
        }
        public void insert(IntPtr word)
        {
            CimCTENative.Trie_insert((Trie*)(NativePtr), word);
        }
    }
}
