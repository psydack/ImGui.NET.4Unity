using System;
using System.Numerics;
using System.Runtime.InteropServices;
using ImGuiNET;

namespace ImNodesRNET
{
    public static unsafe partial class ImNodesRNative
    {
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern CanvasState* CanvasState_CanvasState();
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern void CanvasState_destroy(CanvasState* self);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_AutoPositionNode(void* node_id);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_BeginCanvas(CanvasState* canvas);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_BeginInputSlot(byte* title, int kind);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_BeginNode(void* node_id, Vector2* pos, byte* selected);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_BeginOutputSlot(byte* title, int kind);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_BeginSlot(byte* title, int kind);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_Connection(void* input_node, byte* input_slot, void* output_node, byte* output_slot);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_EndCanvas();
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_EndNode();
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_EndSlot();
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_Ez_BeginCanvas();
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_Ez_BeginNode(void* node_id, byte* title, Vector2* pos, byte* selected);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_Ez_Connection(void* input_node, byte* input_slot, void* output_node, byte* output_slot);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ImNodes_Ez_CreateContext();
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_Ez_EndCanvas();
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_Ez_EndNode();
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_Ez_FreeContext(IntPtr ctx);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern CanvasState* ImNodes_Ez_GetState();
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_Ez_InputSlots(SlotInfo* slots, int snum);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_Ez_OutputSlots(SlotInfo* slots, int snum);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_Ez_PopStyleColor(int count);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_Ez_PopStyleVar(int count);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_Ez_PushStyleColor_U32(ImNodesStyleCol idx, uint col);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_Ez_PushStyleColor_Vec4(ImNodesStyleCol idx, Vector4 col);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_Ez_PushStyleVar_Float(ImNodesStyleVar idx, float val);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_Ez_PushStyleVar_Vec2(ImNodesStyleVar idx, Vector2 val);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodes_Ez_SetContext(IntPtr ctx);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern CanvasState* ImNodes_GetCurrentCanvas();
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_GetNewConnection(void** input_node, byte** input_slot_title, void** output_node, byte** output_slot_title);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_GetPendingConnection(void** node_id, byte** slot_title, int* slot_kind);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImNodes_InputSlotKind(int kind);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_IsConnectingCompatibleSlot();
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_IsInputSlotKind(int kind);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_IsNodeHovered();
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_IsOutputSlotKind(int kind);
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImNodes_IsSlotCurveHovered();
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImNodes_OutputSlotKind(int kind);
    }
}
