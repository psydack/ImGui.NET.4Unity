using System;
using System.Numerics;
using System.Runtime.InteropServices;
using ImGuiNET;

namespace CimCTENET
{
    public static unsafe partial class CimCTENative
    {
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte CodePoint_isBracketCloser(ushort ch);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte CodePoint_isBracketOpener(ushort ch);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte CodePoint_isLetter(ushort codepoint);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte CodePoint_isLower(ushort codepoint);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte CodePoint_isMatchingBrackets(ushort open, ushort close);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte CodePoint_isMatchingPair(ushort open, ushort close);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte CodePoint_isNumber(ushort codepoint);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte CodePoint_isPairCloser(ushort ch);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte CodePoint_isPairOpener(ushort ch);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte CodePoint_isUpper(ushort codepoint);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte CodePoint_isWhiteSpace(ushort codepoint);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte CodePoint_isWord(ushort codepoint);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte CodePoint_isXidContinue(ushort codepoint);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte CodePoint_isXidStart(ushort codepoint);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr CodePoint_read(IntPtr i, IntPtr end, ushort* codepoint);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr CodePoint_skipBOM(IntPtr i, IntPtr end);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort CodePoint_toLower(ushort codepoint);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort CodePoint_toPairCloser(ushort ch);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort CodePoint_toPairOpener(ushort ch);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort CodePoint_toUpper(ushort codepoint);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint CodePoint_write(byte* i, ushort codepoint);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern CursorPosition* CursorPosition_CursorPosition_Nil();
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern CursorPosition* CursorPosition_CursorPosition_Int(int l, int c);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void CursorPosition_destroy(CursorPosition* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern CursorSelection* CursorSelection_CursorSelection_Nil();
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern CursorSelection* CursorSelection_CursorSelection_CursorPosition(CursorPosition s, CursorPosition e);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void CursorSelection_destroy(CursorSelection* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Glyph_destroy(Glyph* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern Glyph* Glyph_Glyph_Nil();
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern Glyph* Glyph_Glyph_Wchar(ushort cp);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern Glyph* Glyph_Glyph_WcharColor(ushort cp, Color col);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Iterator_destroy(Iterator* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern Iterator* Iterator_Iterator_Nil();
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern Iterator* Iterator_Iterator_GlyphPtr(Glyph* g);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Language_AngelScript();
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Language_C();
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Language_Cpp();
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Language_Cs();
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Language_Glsl();
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Language_Hlsl();
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Language_Json();
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Language_Lua();
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Language_Markdown();
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Language_Python();
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Language_Sql();
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint Palette_get(Palette* self, Color color);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextDiff_destroy(TextDiff* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextDiff_GetSideBySideMode(TextDiff* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextDiff_Render(TextDiff* self, byte* title, Vector2 size, byte border);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextDiff_SetColors(TextDiff* self, uint ac, uint dc);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextDiff_SetLanguage(TextDiff* self, Language* l);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextDiff_SetSideBySideMode(TextDiff* self, byte flag);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextDiff_SetText(TextDiff* self, IntPtr left, IntPtr right);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern TextDiff* TextDiff_TextDiff();
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_AddMarker(TextEditor* self, int line, uint lineNumberColor, uint textColor, IntPtr lineNumberTooltip, IntPtr textTooltip);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_AddNextOccurrence(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_AllCursorsHaveSelection(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_AnyCursorHasSelection(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_CanRedo(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_CanUndo(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_ClearCursors(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_ClearLineDecorator(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_ClearLineNumberContextMenuCallback(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_ClearMarkers(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_ClearText(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_ClearTextContextMenuCallback(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_CloseFindReplaceWindow(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_Copy(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_CurrentCursorHasSelection(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_Cut(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_DeindentLines(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_destroy(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_FilterLines(TextEditor* self, IntPtr filter);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_FilterSelections(TextEditor* self, IntPtr filter);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_FindAll(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_FindNext(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_GetCurrentCursor(TextEditor* self, int* line, int* column);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern CursorPosition TextEditor_GetCurrentCursorPosition(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_GetCursor_size_t(TextEditor* self, int* line, int* column, uint cursor);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_GetCursor_IntPtr(TextEditor* self, int* startLine, int* startColumn, int* endLine, int* endColumn, uint cursor);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern CursorPosition TextEditor_GetCursorPosition(TextEditor* self, uint cursor);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern CursorSelection TextEditor_GetCursorSelection(TextEditor* self, uint cursor);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* TextEditor_GetCursorText(TextEditor* self, uint cursor);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr TextEditor_GetDarkPalette();
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr TextEditor_GetDefaultPalette();
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TextEditor_GetFirstVisibleColumn(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TextEditor_GetFirstVisibleLine(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern float TextEditor_GetGlyphWidth(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr TextEditor_GetLanguage(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* TextEditor_GetLanguageName(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TextEditor_GetLastVisibleColumn(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TextEditor_GetLastVisibleLine(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr TextEditor_GetLightPalette();
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TextEditor_GetLineCount(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern float TextEditor_GetLineHeight(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern float TextEditor_GetLineSpacing(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* TextEditor_GetLineText(TextEditor* self, int line);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_GetMainCursor(TextEditor* self, int* line, int* column);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern CursorPosition TextEditor_GetMainCursorPosition(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern CursorSelection TextEditor_GetMainCursorSelection(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint TextEditor_GetNumberOfCursors(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr TextEditor_GetPalette(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* TextEditor_GetSectionText(TextEditor* self, int startLine, int startColumn, int endLine, int endColumn);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TextEditor_GetTabSize(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* TextEditor_GetText(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint TextEditor_GetUndoIndex(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* TextEditor_GetUserData(TextEditor* self, int line);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* TextEditor_GetWordAtScreenPos(TextEditor* self, Vector2 screenPos);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_GrowSelectionsToCurlyBrackets(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_HasFindString(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_HasLanguage(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_HasLineDecorator(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_HasLineNumberContextMenuCallback(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_HasMarkers(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_HasTextContextMenuCallback(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_IndentLines(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_IsAutoIndentEnabled(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_IsCompletingPairedGlyphs(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_IsEmpty(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_IsInsertSpacesOnTabs(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_IsMiddleMousePanMode(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_IsOverwriteEnabled(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_IsReadOnlyEnabled(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_IsShowingMatchingBrackets(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_IsShowLineNumbersEnabled(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_IsShowPanScrollIndicatorEnabled(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_IsShowScrollbarMiniMapEnabled(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_IsShowSpacesEnabled(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_IsShowTabsEnabled(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte TextEditor_IsShowWhitespacesEnabled(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_IterateIdentifiers(TextEditor* self, IntPtr callback);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_IterateUserData(TextEditor* self, IntPtr callback);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_MoveDownLines(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_MoveUpLines(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_OpenFindReplaceWindow(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_Paste(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_Redo(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_Render(TextEditor* self, byte* title, Vector2 size, byte border);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_ReplaceSectionText(TextEditor* self, int startLine, int startColumn, int endLine, int endColumn, IntPtr text);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_ReplaceTextInAllCursors(TextEditor* self, IntPtr text);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_ReplaceTextInCurrentCursor(TextEditor* self, IntPtr text);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_ScrollToLine(TextEditor* self, int line, Scroll alignment);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SelectAll(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SelectAllOccurrences(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SelectAllOccurrencesOf(TextEditor* self, IntPtr text, byte caseSensitive, byte wholeWord);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SelectFirstOccurrenceOf(TextEditor* self, IntPtr text, byte caseSensitive, byte wholeWord);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SelectionToLowerCase(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SelectionToUpperCase(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SelectLine(TextEditor* self, int line);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SelectLines(TextEditor* self, int start, int end);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SelectNextOccurrenceOf(TextEditor* self, IntPtr text, byte caseSensitive, byte wholeWord);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SelectRegion(TextEditor* self, int startLine, int startColumn, int endLine, int endColumn);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SelectToBrackets(TextEditor* self, byte includeBrackets);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetAutoCompleteConfig(TextEditor* self, AutoCompleteConfig* config);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetAutoCompleteSuggestions(TextEditor* self, IntPtr suggestions);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetAutoIndentEnabled(TextEditor* self, byte value);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetChangeCallback(TextEditor* self, IntPtr callback, int delay);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetCompletePairedGlyphs(TextEditor* self, byte value);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetCursor(TextEditor* self, int line, int column);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetDefaultPalette(Palette* aValue);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetDeletor(TextEditor* self, IntPtr callback);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetFindAllButtonLabel(TextEditor* self, IntPtr label);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetFindButtonLabel(TextEditor* self, IntPtr label);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetFocus(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetInsertor(TextEditor* self, IntPtr callback);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetInsertSpacesOnTabs(TextEditor* self, byte value);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetLanguage(TextEditor* self, Language* l);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetLineDecorator(TextEditor* self, float width, IntPtr callback);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetLineNumberContextMenuCallback(TextEditor* self, IntPtr callback);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetLineSpacing(TextEditor* self, float value);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetMiddleMousePanMode(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetMiddleMouseScrollMode(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetOverwriteEnabled(TextEditor* self, byte value);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetPalette(TextEditor* self, Palette* newPalette);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetReadOnlyEnabled(TextEditor* self, byte value);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetReplaceAllButtonLabel(TextEditor* self, IntPtr label);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetReplaceButtonLabel(TextEditor* self, IntPtr label);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetShowLineNumbersEnabled(TextEditor* self, byte value);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetShowMatchingBrackets(TextEditor* self, byte value);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetShowPanScrollIndicatorEnabled(TextEditor* self, byte value);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetShowScrollbarMiniMapEnabled(TextEditor* self, byte value);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetShowSpacesEnabled(TextEditor* self, byte value);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetShowTabsEnabled(TextEditor* self, byte value);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetShowWhitespacesEnabled(TextEditor* self, byte value);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetTabSize(TextEditor* self, int value);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetText(TextEditor* self, IntPtr text);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetTextContextMenuCallback(TextEditor* self, IntPtr callback);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SetUserData(TextEditor* self, int line, void* data);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_ShrinkSelectionsToCurlyBrackets(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_SpacesToTabs(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_StripTrailingWhitespaces(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_TabsToSpaces(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern TextEditor* TextEditor_TextEditor();
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_ToggleComments(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void TextEditor_Undo(TextEditor* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Trie_clear(Trie* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Trie_destroy(Trie* self);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Trie_findSuggestions(Trie* self, IntPtr suggestions, IntPtr searchTerm, uint limit, uint maxSkippedLetters);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Trie_insert(Trie* self, IntPtr word);
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern Trie* Trie_Trie();
    }
}
