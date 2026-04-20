using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace CimCTENET
{
    public unsafe partial struct TextEditor
    {
    }
    public unsafe partial struct TextEditorPtr
    {
        public TextEditor* NativePtr { get; }
        public TextEditorPtr(TextEditor* nativePtr) => NativePtr = nativePtr;
        public TextEditorPtr(IntPtr nativePtr) => NativePtr = (TextEditor*)nativePtr;
        public static implicit operator TextEditorPtr(TextEditor* nativePtr) => new TextEditorPtr(nativePtr);
        public static implicit operator TextEditor* (TextEditorPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator TextEditorPtr(IntPtr nativePtr) => new TextEditorPtr(nativePtr);
        public void AddMarker(int line, uint lineNumberColor, uint textColor, IntPtr lineNumberTooltip, IntPtr textTooltip)
        {
            CimCTENative.TextEditor_AddMarker((TextEditor*)(NativePtr), line, lineNumberColor, textColor, lineNumberTooltip, textTooltip);
        }
        public void AddNextOccurrence()
        {
            CimCTENative.TextEditor_AddNextOccurrence((TextEditor*)(NativePtr));
        }
        public bool AllCursorsHaveSelection()
        {
            byte ret = CimCTENative.TextEditor_AllCursorsHaveSelection((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public bool AnyCursorHasSelection()
        {
            byte ret = CimCTENative.TextEditor_AnyCursorHasSelection((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public bool CanRedo()
        {
            byte ret = CimCTENative.TextEditor_CanRedo((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public bool CanUndo()
        {
            byte ret = CimCTENative.TextEditor_CanUndo((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public void ClearCursors()
        {
            CimCTENative.TextEditor_ClearCursors((TextEditor*)(NativePtr));
        }
        public void ClearLineDecorator()
        {
            CimCTENative.TextEditor_ClearLineDecorator((TextEditor*)(NativePtr));
        }
        public void ClearLineNumberContextMenuCallback()
        {
            CimCTENative.TextEditor_ClearLineNumberContextMenuCallback((TextEditor*)(NativePtr));
        }
        public void ClearMarkers()
        {
            CimCTENative.TextEditor_ClearMarkers((TextEditor*)(NativePtr));
        }
        public void ClearText()
        {
            CimCTENative.TextEditor_ClearText((TextEditor*)(NativePtr));
        }
        public void ClearTextContextMenuCallback()
        {
            CimCTENative.TextEditor_ClearTextContextMenuCallback((TextEditor*)(NativePtr));
        }
        public void CloseFindReplaceWindow()
        {
            CimCTENative.TextEditor_CloseFindReplaceWindow((TextEditor*)(NativePtr));
        }
        public void Copy()
        {
            CimCTENative.TextEditor_Copy((TextEditor*)(NativePtr));
        }
        public bool CurrentCursorHasSelection()
        {
            byte ret = CimCTENative.TextEditor_CurrentCursorHasSelection((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public void Cut()
        {
            CimCTENative.TextEditor_Cut((TextEditor*)(NativePtr));
        }
        public void DeindentLines()
        {
            CimCTENative.TextEditor_DeindentLines((TextEditor*)(NativePtr));
        }
        public void Destroy()
        {
            CimCTENative.TextEditor_destroy((TextEditor*)(NativePtr));
        }
        public void FilterLines(IntPtr filter)
        {
            CimCTENative.TextEditor_FilterLines((TextEditor*)(NativePtr), filter);
        }
        public void FilterSelections(IntPtr filter)
        {
            CimCTENative.TextEditor_FilterSelections((TextEditor*)(NativePtr), filter);
        }
        public void FindAll()
        {
            CimCTENative.TextEditor_FindAll((TextEditor*)(NativePtr));
        }
        public void FindNext()
        {
            CimCTENative.TextEditor_FindNext((TextEditor*)(NativePtr));
        }
        public void GetCurrentCursor(ref int line, ref int column)
        {
            fixed (int* native_line = &line)
            {
                fixed (int* native_column = &column)
                {
                    CimCTENative.TextEditor_GetCurrentCursor((TextEditor*)(NativePtr), native_line, native_column);
                }
            }
        }
        public CursorPosition GetCurrentCursorPosition()
        {
            CursorPosition ret = CimCTENative.TextEditor_GetCurrentCursorPosition((TextEditor*)(NativePtr));
            return ret;
        }
        public void GetCursor(ref int line, ref int column, uint cursor)
        {
            fixed (int* native_line = &line)
            {
                fixed (int* native_column = &column)
                {
                    CimCTENative.TextEditor_GetCursor_size_t((TextEditor*)(NativePtr), native_line, native_column, cursor);
                }
            }
        }
        public void GetCursor(ref int startLine, ref int startColumn, ref int endLine, ref int endColumn, uint cursor)
        {
            fixed (int* native_startLine = &startLine)
            {
                fixed (int* native_startColumn = &startColumn)
                {
                    fixed (int* native_endLine = &endLine)
                    {
                        fixed (int* native_endColumn = &endColumn)
                        {
                            CimCTENative.TextEditor_GetCursor_IntPtr((TextEditor*)(NativePtr), native_startLine, native_startColumn, native_endLine, native_endColumn, cursor);
                        }
                    }
                }
            }
        }
        public CursorPosition GetCursorPosition(uint cursor)
        {
            CursorPosition ret = CimCTENative.TextEditor_GetCursorPosition((TextEditor*)(NativePtr), cursor);
            return ret;
        }
        public CursorSelection GetCursorSelection(uint cursor)
        {
            CursorSelection ret = CimCTENative.TextEditor_GetCursorSelection((TextEditor*)(NativePtr), cursor);
            return ret;
        }
        public string GetCursorText(uint cursor)
        {
            byte* ret = CimCTENative.TextEditor_GetCursorText((TextEditor*)(NativePtr), cursor);
            return Util.StringFromPtr(ret);
        }
        public IntPtr GetDarkPalette()
        {
            IntPtr ret = CimCTENative.TextEditor_GetDarkPalette();
            return ret;
        }
        public IntPtr GetDefaultPalette()
        {
            IntPtr ret = CimCTENative.TextEditor_GetDefaultPalette();
            return ret;
        }
        public int GetFirstVisibleColumn()
        {
            int ret = CimCTENative.TextEditor_GetFirstVisibleColumn((TextEditor*)(NativePtr));
            return ret;
        }
        public int GetFirstVisibleLine()
        {
            int ret = CimCTENative.TextEditor_GetFirstVisibleLine((TextEditor*)(NativePtr));
            return ret;
        }
        public float GetGlyphWidth()
        {
            float ret = CimCTENative.TextEditor_GetGlyphWidth((TextEditor*)(NativePtr));
            return ret;
        }
        public IntPtr GetLanguage()
        {
            IntPtr ret = CimCTENative.TextEditor_GetLanguage((TextEditor*)(NativePtr));
            return ret;
        }
        public string GetLanguageName()
        {
            byte* ret = CimCTENative.TextEditor_GetLanguageName((TextEditor*)(NativePtr));
            return Util.StringFromPtr(ret);
        }
        public int GetLastVisibleColumn()
        {
            int ret = CimCTENative.TextEditor_GetLastVisibleColumn((TextEditor*)(NativePtr));
            return ret;
        }
        public int GetLastVisibleLine()
        {
            int ret = CimCTENative.TextEditor_GetLastVisibleLine((TextEditor*)(NativePtr));
            return ret;
        }
        public IntPtr GetLightPalette()
        {
            IntPtr ret = CimCTENative.TextEditor_GetLightPalette();
            return ret;
        }
        public int GetLineCount()
        {
            int ret = CimCTENative.TextEditor_GetLineCount((TextEditor*)(NativePtr));
            return ret;
        }
        public float GetLineHeight()
        {
            float ret = CimCTENative.TextEditor_GetLineHeight((TextEditor*)(NativePtr));
            return ret;
        }
        public float GetLineSpacing()
        {
            float ret = CimCTENative.TextEditor_GetLineSpacing((TextEditor*)(NativePtr));
            return ret;
        }
        public string GetLineText(int line)
        {
            byte* ret = CimCTENative.TextEditor_GetLineText((TextEditor*)(NativePtr), line);
            return Util.StringFromPtr(ret);
        }
        public void GetMainCursor(ref int line, ref int column)
        {
            fixed (int* native_line = &line)
            {
                fixed (int* native_column = &column)
                {
                    CimCTENative.TextEditor_GetMainCursor((TextEditor*)(NativePtr), native_line, native_column);
                }
            }
        }
        public CursorPosition GetMainCursorPosition()
        {
            CursorPosition ret = CimCTENative.TextEditor_GetMainCursorPosition((TextEditor*)(NativePtr));
            return ret;
        }
        public CursorSelection GetMainCursorSelection()
        {
            CursorSelection ret = CimCTENative.TextEditor_GetMainCursorSelection((TextEditor*)(NativePtr));
            return ret;
        }
        public uint GetNumberOfCursors()
        {
            uint ret = CimCTENative.TextEditor_GetNumberOfCursors((TextEditor*)(NativePtr));
            return ret;
        }
        public IntPtr GetPalette()
        {
            IntPtr ret = CimCTENative.TextEditor_GetPalette((TextEditor*)(NativePtr));
            return ret;
        }
        public string GetSectionText(int startLine, int startColumn, int endLine, int endColumn)
        {
            byte* ret = CimCTENative.TextEditor_GetSectionText((TextEditor*)(NativePtr), startLine, startColumn, endLine, endColumn);
            return Util.StringFromPtr(ret);
        }
        public int GetTabSize()
        {
            int ret = CimCTENative.TextEditor_GetTabSize((TextEditor*)(NativePtr));
            return ret;
        }
        public string GetText()
        {
            byte* ret = CimCTENative.TextEditor_GetText((TextEditor*)(NativePtr));
            return Util.StringFromPtr(ret);
        }
        public uint GetUndoIndex()
        {
            uint ret = CimCTENative.TextEditor_GetUndoIndex((TextEditor*)(NativePtr));
            return ret;
        }
        public IntPtr GetUserData(int line)
        {
            void* ret = CimCTENative.TextEditor_GetUserData((TextEditor*)(NativePtr), line);
            return (IntPtr)ret;
        }
        public string GetWordAtScreenPos(Vector2 screenPos)
        {
            byte* ret = CimCTENative.TextEditor_GetWordAtScreenPos((TextEditor*)(NativePtr), screenPos);
            return Util.StringFromPtr(ret);
        }
        public void GrowSelectionsToCurlyBrackets()
        {
            CimCTENative.TextEditor_GrowSelectionsToCurlyBrackets((TextEditor*)(NativePtr));
        }
        public bool HasFindString()
        {
            byte ret = CimCTENative.TextEditor_HasFindString((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public bool HasLanguage()
        {
            byte ret = CimCTENative.TextEditor_HasLanguage((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public bool HasLineDecorator()
        {
            byte ret = CimCTENative.TextEditor_HasLineDecorator((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public bool HasLineNumberContextMenuCallback()
        {
            byte ret = CimCTENative.TextEditor_HasLineNumberContextMenuCallback((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public bool HasMarkers()
        {
            byte ret = CimCTENative.TextEditor_HasMarkers((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public bool HasTextContextMenuCallback()
        {
            byte ret = CimCTENative.TextEditor_HasTextContextMenuCallback((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public void IndentLines()
        {
            CimCTENative.TextEditor_IndentLines((TextEditor*)(NativePtr));
        }
        public bool IsAutoIndentEnabled()
        {
            byte ret = CimCTENative.TextEditor_IsAutoIndentEnabled((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public bool IsCompletingPairedGlyphs()
        {
            byte ret = CimCTENative.TextEditor_IsCompletingPairedGlyphs((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public bool IsEmpty()
        {
            byte ret = CimCTENative.TextEditor_IsEmpty((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public bool IsInsertSpacesOnTabs()
        {
            byte ret = CimCTENative.TextEditor_IsInsertSpacesOnTabs((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public bool IsMiddleMousePanMode()
        {
            byte ret = CimCTENative.TextEditor_IsMiddleMousePanMode((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public bool IsOverwriteEnabled()
        {
            byte ret = CimCTENative.TextEditor_IsOverwriteEnabled((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public bool IsReadOnlyEnabled()
        {
            byte ret = CimCTENative.TextEditor_IsReadOnlyEnabled((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public bool IsShowingMatchingBrackets()
        {
            byte ret = CimCTENative.TextEditor_IsShowingMatchingBrackets((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public bool IsShowLineNumbersEnabled()
        {
            byte ret = CimCTENative.TextEditor_IsShowLineNumbersEnabled((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public bool IsShowPanScrollIndicatorEnabled()
        {
            byte ret = CimCTENative.TextEditor_IsShowPanScrollIndicatorEnabled((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public bool IsShowScrollbarMiniMapEnabled()
        {
            byte ret = CimCTENative.TextEditor_IsShowScrollbarMiniMapEnabled((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public bool IsShowSpacesEnabled()
        {
            byte ret = CimCTENative.TextEditor_IsShowSpacesEnabled((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public bool IsShowTabsEnabled()
        {
            byte ret = CimCTENative.TextEditor_IsShowTabsEnabled((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public bool IsShowWhitespacesEnabled()
        {
            byte ret = CimCTENative.TextEditor_IsShowWhitespacesEnabled((TextEditor*)(NativePtr));
            return ret != 0;
        }
        public void IterateIdentifiers(IntPtr callback)
        {
            CimCTENative.TextEditor_IterateIdentifiers((TextEditor*)(NativePtr), callback);
        }
        public void IterateUserData(IntPtr callback)
        {
            CimCTENative.TextEditor_IterateUserData((TextEditor*)(NativePtr), callback);
        }
        public void MoveDownLines()
        {
            CimCTENative.TextEditor_MoveDownLines((TextEditor*)(NativePtr));
        }
        public void MoveUpLines()
        {
            CimCTENative.TextEditor_MoveUpLines((TextEditor*)(NativePtr));
        }
        public void OpenFindReplaceWindow()
        {
            CimCTENative.TextEditor_OpenFindReplaceWindow((TextEditor*)(NativePtr));
        }
        public void Paste()
        {
            CimCTENative.TextEditor_Paste((TextEditor*)(NativePtr));
        }
        public void Redo()
        {
            CimCTENative.TextEditor_Redo((TextEditor*)(NativePtr));
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
            CimCTENative.TextEditor_Render((TextEditor*)(NativePtr), native_title, size, border);
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
            CimCTENative.TextEditor_Render((TextEditor*)(NativePtr), native_title, size, border);
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
            CimCTENative.TextEditor_Render((TextEditor*)(NativePtr), native_title, size, border);
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
            CimCTENative.TextEditor_Render((TextEditor*)(NativePtr), native_title, size, border);
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
            CimCTENative.TextEditor_Render((TextEditor*)(NativePtr), native_title, size, native_border);
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
            CimCTENative.TextEditor_Render((TextEditor*)(NativePtr), native_title, size, native_border);
            if (title_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_title);
            }
        }
        public void ReplaceSectionText(int startLine, int startColumn, int endLine, int endColumn, IntPtr text)
        {
            CimCTENative.TextEditor_ReplaceSectionText((TextEditor*)(NativePtr), startLine, startColumn, endLine, endColumn, text);
        }
        public void ReplaceTextInAllCursors(IntPtr text)
        {
            CimCTENative.TextEditor_ReplaceTextInAllCursors((TextEditor*)(NativePtr), text);
        }
        public void ReplaceTextInCurrentCursor(IntPtr text)
        {
            CimCTENative.TextEditor_ReplaceTextInCurrentCursor((TextEditor*)(NativePtr), text);
        }
        public void ScrollToLine(int line, Scroll alignment)
        {
            CimCTENative.TextEditor_ScrollToLine((TextEditor*)(NativePtr), line, alignment);
        }
        public void SelectAll()
        {
            CimCTENative.TextEditor_SelectAll((TextEditor*)(NativePtr));
        }
        public void SelectAllOccurrences()
        {
            CimCTENative.TextEditor_SelectAllOccurrences((TextEditor*)(NativePtr));
        }
        public void SelectAllOccurrencesOf(IntPtr text)
        {
            byte caseSensitive = 1;
            byte wholeWord = 0;
            CimCTENative.TextEditor_SelectAllOccurrencesOf((TextEditor*)(NativePtr), text, caseSensitive, wholeWord);
        }
        public void SelectAllOccurrencesOf(IntPtr text, bool caseSensitive)
        {
            byte native_caseSensitive = caseSensitive ? (byte)1 : (byte)0;
            byte wholeWord = 0;
            CimCTENative.TextEditor_SelectAllOccurrencesOf((TextEditor*)(NativePtr), text, native_caseSensitive, wholeWord);
        }
        public void SelectAllOccurrencesOf(IntPtr text, bool caseSensitive, bool wholeWord)
        {
            byte native_caseSensitive = caseSensitive ? (byte)1 : (byte)0;
            byte native_wholeWord = wholeWord ? (byte)1 : (byte)0;
            CimCTENative.TextEditor_SelectAllOccurrencesOf((TextEditor*)(NativePtr), text, native_caseSensitive, native_wholeWord);
        }
        public void SelectFirstOccurrenceOf(IntPtr text)
        {
            byte caseSensitive = 1;
            byte wholeWord = 0;
            CimCTENative.TextEditor_SelectFirstOccurrenceOf((TextEditor*)(NativePtr), text, caseSensitive, wholeWord);
        }
        public void SelectFirstOccurrenceOf(IntPtr text, bool caseSensitive)
        {
            byte native_caseSensitive = caseSensitive ? (byte)1 : (byte)0;
            byte wholeWord = 0;
            CimCTENative.TextEditor_SelectFirstOccurrenceOf((TextEditor*)(NativePtr), text, native_caseSensitive, wholeWord);
        }
        public void SelectFirstOccurrenceOf(IntPtr text, bool caseSensitive, bool wholeWord)
        {
            byte native_caseSensitive = caseSensitive ? (byte)1 : (byte)0;
            byte native_wholeWord = wholeWord ? (byte)1 : (byte)0;
            CimCTENative.TextEditor_SelectFirstOccurrenceOf((TextEditor*)(NativePtr), text, native_caseSensitive, native_wholeWord);
        }
        public void SelectionToLowerCase()
        {
            CimCTENative.TextEditor_SelectionToLowerCase((TextEditor*)(NativePtr));
        }
        public void SelectionToUpperCase()
        {
            CimCTENative.TextEditor_SelectionToUpperCase((TextEditor*)(NativePtr));
        }
        public void SelectLine(int line)
        {
            CimCTENative.TextEditor_SelectLine((TextEditor*)(NativePtr), line);
        }
        public void SelectLines(int start, int end)
        {
            CimCTENative.TextEditor_SelectLines((TextEditor*)(NativePtr), start, end);
        }
        public void SelectNextOccurrenceOf(IntPtr text)
        {
            byte caseSensitive = 1;
            byte wholeWord = 0;
            CimCTENative.TextEditor_SelectNextOccurrenceOf((TextEditor*)(NativePtr), text, caseSensitive, wholeWord);
        }
        public void SelectNextOccurrenceOf(IntPtr text, bool caseSensitive)
        {
            byte native_caseSensitive = caseSensitive ? (byte)1 : (byte)0;
            byte wholeWord = 0;
            CimCTENative.TextEditor_SelectNextOccurrenceOf((TextEditor*)(NativePtr), text, native_caseSensitive, wholeWord);
        }
        public void SelectNextOccurrenceOf(IntPtr text, bool caseSensitive, bool wholeWord)
        {
            byte native_caseSensitive = caseSensitive ? (byte)1 : (byte)0;
            byte native_wholeWord = wholeWord ? (byte)1 : (byte)0;
            CimCTENative.TextEditor_SelectNextOccurrenceOf((TextEditor*)(NativePtr), text, native_caseSensitive, native_wholeWord);
        }
        public void SelectRegion(int startLine, int startColumn, int endLine, int endColumn)
        {
            CimCTENative.TextEditor_SelectRegion((TextEditor*)(NativePtr), startLine, startColumn, endLine, endColumn);
        }
        public void SelectToBrackets()
        {
            byte includeBrackets = 1;
            CimCTENative.TextEditor_SelectToBrackets((TextEditor*)(NativePtr), includeBrackets);
        }
        public void SelectToBrackets(bool includeBrackets)
        {
            byte native_includeBrackets = includeBrackets ? (byte)1 : (byte)0;
            CimCTENative.TextEditor_SelectToBrackets((TextEditor*)(NativePtr), native_includeBrackets);
        }
        public void SetAutoCompleteConfig(ref AutoCompleteConfig config)
        {
            fixed (AutoCompleteConfig* native_config = &config)
            {
                CimCTENative.TextEditor_SetAutoCompleteConfig((TextEditor*)(NativePtr), native_config);
            }
        }
        public void SetAutoCompleteSuggestions(IntPtr suggestions)
        {
            CimCTENative.TextEditor_SetAutoCompleteSuggestions((TextEditor*)(NativePtr), suggestions);
        }
        public void SetAutoIndentEnabled(bool value)
        {
            byte native_value = value ? (byte)1 : (byte)0;
            CimCTENative.TextEditor_SetAutoIndentEnabled((TextEditor*)(NativePtr), native_value);
        }
        public void SetChangeCallback(IntPtr callback)
        {
            int delay = 0;
            CimCTENative.TextEditor_SetChangeCallback((TextEditor*)(NativePtr), callback, delay);
        }
        public void SetChangeCallback(IntPtr callback, int delay)
        {
            CimCTENative.TextEditor_SetChangeCallback((TextEditor*)(NativePtr), callback, delay);
        }
        public void SetCompletePairedGlyphs(bool value)
        {
            byte native_value = value ? (byte)1 : (byte)0;
            CimCTENative.TextEditor_SetCompletePairedGlyphs((TextEditor*)(NativePtr), native_value);
        }
        public void SetCursor(int line, int column)
        {
            CimCTENative.TextEditor_SetCursor((TextEditor*)(NativePtr), line, column);
        }
        public void SetDefaultPalette(ref Palette aValue)
        {
            fixed (Palette* native_aValue = &aValue)
            {
                CimCTENative.TextEditor_SetDefaultPalette(native_aValue);
            }
        }
        public void SetDeletor(IntPtr callback)
        {
            CimCTENative.TextEditor_SetDeletor((TextEditor*)(NativePtr), callback);
        }
        public void SetFindAllButtonLabel(IntPtr label)
        {
            CimCTENative.TextEditor_SetFindAllButtonLabel((TextEditor*)(NativePtr), label);
        }
        public void SetFindButtonLabel(IntPtr label)
        {
            CimCTENative.TextEditor_SetFindButtonLabel((TextEditor*)(NativePtr), label);
        }
        public void SetFocus()
        {
            CimCTENative.TextEditor_SetFocus((TextEditor*)(NativePtr));
        }
        public void SetInsertor(IntPtr callback)
        {
            CimCTENative.TextEditor_SetInsertor((TextEditor*)(NativePtr), callback);
        }
        public void SetInsertSpacesOnTabs(bool value)
        {
            byte native_value = value ? (byte)1 : (byte)0;
            CimCTENative.TextEditor_SetInsertSpacesOnTabs((TextEditor*)(NativePtr), native_value);
        }
        public void SetLanguage(ref Language l)
        {
            fixed (Language* native_l = &l)
            {
                CimCTENative.TextEditor_SetLanguage((TextEditor*)(NativePtr), native_l);
            }
        }
        public void SetLineDecorator(float width, IntPtr callback)
        {
            CimCTENative.TextEditor_SetLineDecorator((TextEditor*)(NativePtr), width, callback);
        }
        public void SetLineNumberContextMenuCallback(IntPtr callback)
        {
            CimCTENative.TextEditor_SetLineNumberContextMenuCallback((TextEditor*)(NativePtr), callback);
        }
        public void SetLineSpacing(float value)
        {
            CimCTENative.TextEditor_SetLineSpacing((TextEditor*)(NativePtr), value);
        }
        public void SetMiddleMousePanMode()
        {
            CimCTENative.TextEditor_SetMiddleMousePanMode((TextEditor*)(NativePtr));
        }
        public void SetMiddleMouseScrollMode()
        {
            CimCTENative.TextEditor_SetMiddleMouseScrollMode((TextEditor*)(NativePtr));
        }
        public void SetOverwriteEnabled(bool value)
        {
            byte native_value = value ? (byte)1 : (byte)0;
            CimCTENative.TextEditor_SetOverwriteEnabled((TextEditor*)(NativePtr), native_value);
        }
        public void SetPalette(ref Palette newPalette)
        {
            fixed (Palette* native_newPalette = &newPalette)
            {
                CimCTENative.TextEditor_SetPalette((TextEditor*)(NativePtr), native_newPalette);
            }
        }
        public void SetReadOnlyEnabled(bool value)
        {
            byte native_value = value ? (byte)1 : (byte)0;
            CimCTENative.TextEditor_SetReadOnlyEnabled((TextEditor*)(NativePtr), native_value);
        }
        public void SetReplaceAllButtonLabel(IntPtr label)
        {
            CimCTENative.TextEditor_SetReplaceAllButtonLabel((TextEditor*)(NativePtr), label);
        }
        public void SetReplaceButtonLabel(IntPtr label)
        {
            CimCTENative.TextEditor_SetReplaceButtonLabel((TextEditor*)(NativePtr), label);
        }
        public void SetShowLineNumbersEnabled(bool value)
        {
            byte native_value = value ? (byte)1 : (byte)0;
            CimCTENative.TextEditor_SetShowLineNumbersEnabled((TextEditor*)(NativePtr), native_value);
        }
        public void SetShowMatchingBrackets(bool value)
        {
            byte native_value = value ? (byte)1 : (byte)0;
            CimCTENative.TextEditor_SetShowMatchingBrackets((TextEditor*)(NativePtr), native_value);
        }
        public void SetShowPanScrollIndicatorEnabled(bool value)
        {
            byte native_value = value ? (byte)1 : (byte)0;
            CimCTENative.TextEditor_SetShowPanScrollIndicatorEnabled((TextEditor*)(NativePtr), native_value);
        }
        public void SetShowScrollbarMiniMapEnabled(bool value)
        {
            byte native_value = value ? (byte)1 : (byte)0;
            CimCTENative.TextEditor_SetShowScrollbarMiniMapEnabled((TextEditor*)(NativePtr), native_value);
        }
        public void SetShowSpacesEnabled(bool value)
        {
            byte native_value = value ? (byte)1 : (byte)0;
            CimCTENative.TextEditor_SetShowSpacesEnabled((TextEditor*)(NativePtr), native_value);
        }
        public void SetShowTabsEnabled(bool value)
        {
            byte native_value = value ? (byte)1 : (byte)0;
            CimCTENative.TextEditor_SetShowTabsEnabled((TextEditor*)(NativePtr), native_value);
        }
        public void SetShowWhitespacesEnabled(bool value)
        {
            byte native_value = value ? (byte)1 : (byte)0;
            CimCTENative.TextEditor_SetShowWhitespacesEnabled((TextEditor*)(NativePtr), native_value);
        }
        public void SetTabSize(int value)
        {
            CimCTENative.TextEditor_SetTabSize((TextEditor*)(NativePtr), value);
        }
        public void SetText(IntPtr text)
        {
            CimCTENative.TextEditor_SetText((TextEditor*)(NativePtr), text);
        }
        public void SetTextContextMenuCallback(IntPtr callback)
        {
            CimCTENative.TextEditor_SetTextContextMenuCallback((TextEditor*)(NativePtr), callback);
        }
        public void SetUserData(int line, IntPtr data)
        {
            void* native_data = (void*)data.ToPointer();
            CimCTENative.TextEditor_SetUserData((TextEditor*)(NativePtr), line, native_data);
        }
        public void ShrinkSelectionsToCurlyBrackets()
        {
            CimCTENative.TextEditor_ShrinkSelectionsToCurlyBrackets((TextEditor*)(NativePtr));
        }
        public void SpacesToTabs()
        {
            CimCTENative.TextEditor_SpacesToTabs((TextEditor*)(NativePtr));
        }
        public void StripTrailingWhitespaces()
        {
            CimCTENative.TextEditor_StripTrailingWhitespaces((TextEditor*)(NativePtr));
        }
        public void TabsToSpaces()
        {
            CimCTENative.TextEditor_TabsToSpaces((TextEditor*)(NativePtr));
        }
        public void ToggleComments()
        {
            CimCTENative.TextEditor_ToggleComments((TextEditor*)(NativePtr));
        }
        public void Undo()
        {
            CimCTENative.TextEditor_Undo((TextEditor*)(NativePtr));
        }
    }
}
