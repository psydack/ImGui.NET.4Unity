using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using ImGuiNET;

namespace ImNodesRNET
{
    public static unsafe partial class ImNodesR
    {
        public static void AutoPositionNode(IntPtr node_id)
        {
            void* native_node_id = (void*)node_id.ToPointer();
            ImNodesRNative.ImNodes_AutoPositionNode(native_node_id);
        }
        public static void BeginCanvas(ref CanvasState canvas)
        {
            fixed (CanvasState* native_canvas = &canvas)
            {
                ImNodesRNative.ImNodes_BeginCanvas(native_canvas);
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool BeginInputSlot(ReadOnlySpan<char> title, int kind)
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
            byte ret = ImNodesRNative.ImNodes_BeginInputSlot(native_title, kind);
            if (title_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_title);
            }
            return ret != 0;
        }
#endif
        public static bool BeginInputSlot(string title, int kind)
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
            byte ret = ImNodesRNative.ImNodes_BeginInputSlot(native_title, kind);
            if (title_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_title);
            }
            return ret != 0;
        }
        public static bool BeginNode(IntPtr node_id, ref Vector2 pos, ref bool selected)
        {
            void* native_node_id = (void*)node_id.ToPointer();
            byte native_selected_val = selected ? (byte)1 : (byte)0;
            byte* native_selected = &native_selected_val;
            fixed (Vector2* native_pos = &pos)
            {
                byte ret = ImNodesRNative.ImNodes_BeginNode(native_node_id, native_pos, native_selected);
                selected = native_selected_val != 0;
                return ret != 0;
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool BeginOutputSlot(ReadOnlySpan<char> title, int kind)
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
            byte ret = ImNodesRNative.ImNodes_BeginOutputSlot(native_title, kind);
            if (title_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_title);
            }
            return ret != 0;
        }
#endif
        public static bool BeginOutputSlot(string title, int kind)
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
            byte ret = ImNodesRNative.ImNodes_BeginOutputSlot(native_title, kind);
            if (title_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_title);
            }
            return ret != 0;
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool BeginSlot(ReadOnlySpan<char> title, int kind)
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
            byte ret = ImNodesRNative.ImNodes_BeginSlot(native_title, kind);
            if (title_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_title);
            }
            return ret != 0;
        }
#endif
        public static bool BeginSlot(string title, int kind)
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
            byte ret = ImNodesRNative.ImNodes_BeginSlot(native_title, kind);
            if (title_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_title);
            }
            return ret != 0;
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool Connection(IntPtr input_node, ReadOnlySpan<char> input_slot, IntPtr output_node, ReadOnlySpan<char> output_slot)
        {
            void* native_input_node = (void*)input_node.ToPointer();
            byte* native_input_slot;
            int input_slot_byteCount = 0;
            if (input_slot != null)
            {
                input_slot_byteCount = Encoding.UTF8.GetByteCount(input_slot);
                if (input_slot_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_input_slot = Util.Allocate(input_slot_byteCount + 1);
                }
                else
                {
                    byte* native_input_slot_stackBytes = stackalloc byte[input_slot_byteCount + 1];
                    native_input_slot = native_input_slot_stackBytes;
                }
                int native_input_slot_offset = Util.GetUtf8(input_slot, native_input_slot, input_slot_byteCount);
                native_input_slot[native_input_slot_offset] = 0;
            }
            else { native_input_slot = null; }
            void* native_output_node = (void*)output_node.ToPointer();
            byte* native_output_slot;
            int output_slot_byteCount = 0;
            if (output_slot != null)
            {
                output_slot_byteCount = Encoding.UTF8.GetByteCount(output_slot);
                if (output_slot_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_output_slot = Util.Allocate(output_slot_byteCount + 1);
                }
                else
                {
                    byte* native_output_slot_stackBytes = stackalloc byte[output_slot_byteCount + 1];
                    native_output_slot = native_output_slot_stackBytes;
                }
                int native_output_slot_offset = Util.GetUtf8(output_slot, native_output_slot, output_slot_byteCount);
                native_output_slot[native_output_slot_offset] = 0;
            }
            else { native_output_slot = null; }
            byte ret = ImNodesRNative.ImNodes_Connection(native_input_node, native_input_slot, native_output_node, native_output_slot);
            if (input_slot_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_input_slot);
            }
            if (output_slot_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_output_slot);
            }
            return ret != 0;
        }
#endif
        public static bool Connection(IntPtr input_node, string input_slot, IntPtr output_node, string output_slot)
        {
            void* native_input_node = (void*)input_node.ToPointer();
            byte* native_input_slot;
            int input_slot_byteCount = 0;
            if (input_slot != null)
            {
                input_slot_byteCount = Encoding.UTF8.GetByteCount(input_slot);
                if (input_slot_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_input_slot = Util.Allocate(input_slot_byteCount + 1);
                }
                else
                {
                    byte* native_input_slot_stackBytes = stackalloc byte[input_slot_byteCount + 1];
                    native_input_slot = native_input_slot_stackBytes;
                }
                int native_input_slot_offset = Util.GetUtf8(input_slot, native_input_slot, input_slot_byteCount);
                native_input_slot[native_input_slot_offset] = 0;
            }
            else { native_input_slot = null; }
            void* native_output_node = (void*)output_node.ToPointer();
            byte* native_output_slot;
            int output_slot_byteCount = 0;
            if (output_slot != null)
            {
                output_slot_byteCount = Encoding.UTF8.GetByteCount(output_slot);
                if (output_slot_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_output_slot = Util.Allocate(output_slot_byteCount + 1);
                }
                else
                {
                    byte* native_output_slot_stackBytes = stackalloc byte[output_slot_byteCount + 1];
                    native_output_slot = native_output_slot_stackBytes;
                }
                int native_output_slot_offset = Util.GetUtf8(output_slot, native_output_slot, output_slot_byteCount);
                native_output_slot[native_output_slot_offset] = 0;
            }
            else { native_output_slot = null; }
            byte ret = ImNodesRNative.ImNodes_Connection(native_input_node, native_input_slot, native_output_node, native_output_slot);
            if (input_slot_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_input_slot);
            }
            if (output_slot_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_output_slot);
            }
            return ret != 0;
        }
        public static void EndCanvas()
        {
            ImNodesRNative.ImNodes_EndCanvas();
        }
        public static void EndNode()
        {
            ImNodesRNative.ImNodes_EndNode();
        }
        public static void EndSlot()
        {
            ImNodesRNative.ImNodes_EndSlot();
        }
        public static void BeginCanvas()
        {
            ImNodesRNative.ImNodes_Ez_BeginCanvas();
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool BeginNode(IntPtr node_id, ReadOnlySpan<char> title, ref Vector2 pos, ref bool selected)
        {
            void* native_node_id = (void*)node_id.ToPointer();
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
            byte native_selected_val = selected ? (byte)1 : (byte)0;
            byte* native_selected = &native_selected_val;
            fixed (Vector2* native_pos = &pos)
            {
                byte ret = ImNodesRNative.ImNodes_Ez_BeginNode(native_node_id, native_title, native_pos, native_selected);
                if (title_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_title);
                }
                selected = native_selected_val != 0;
                return ret != 0;
            }
        }
#endif
        public static bool BeginNode(IntPtr node_id, string title, ref Vector2 pos, ref bool selected)
        {
            void* native_node_id = (void*)node_id.ToPointer();
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
            byte native_selected_val = selected ? (byte)1 : (byte)0;
            byte* native_selected = &native_selected_val;
            fixed (Vector2* native_pos = &pos)
            {
                byte ret = ImNodesRNative.ImNodes_Ez_BeginNode(native_node_id, native_title, native_pos, native_selected);
                if (title_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_title);
                }
                selected = native_selected_val != 0;
                return ret != 0;
            }
        }
        public static IntPtr CreateContext()
        {
            IntPtr ret = ImNodesRNative.ImNodes_Ez_CreateContext();
            return ret;
        }
        public static void FreeContext(IntPtr ctx)
        {
            ImNodesRNative.ImNodes_Ez_FreeContext(ctx);
        }
        public static CanvasState* GetState()
        {
            CanvasState* ret = ImNodesRNative.ImNodes_Ez_GetState();
            return ret;
        }
        public static void InputSlots(ref SlotInfo slots, int snum)
        {
            fixed (SlotInfo* native_slots = &slots)
            {
                ImNodesRNative.ImNodes_Ez_InputSlots(native_slots, snum);
            }
        }
        public static void OutputSlots(ref SlotInfo slots, int snum)
        {
            fixed (SlotInfo* native_slots = &slots)
            {
                ImNodesRNative.ImNodes_Ez_OutputSlots(native_slots, snum);
            }
        }
        public static void PopStyleColor(int count)
        {
            ImNodesRNative.ImNodes_Ez_PopStyleColor(count);
        }
        public static void PopStyleVar()
        {
            int count = 1;
            ImNodesRNative.ImNodes_Ez_PopStyleVar(count);
        }
        public static void PopStyleVar(int count)
        {
            ImNodesRNative.ImNodes_Ez_PopStyleVar(count);
        }
        public static void PushStyleColor(ImNodesStyleCol idx, uint col)
        {
            ImNodesRNative.ImNodes_Ez_PushStyleColor_U32(idx, col);
        }
        public static void PushStyleColor(ImNodesStyleCol idx, Vector4 col)
        {
            ImNodesRNative.ImNodes_Ez_PushStyleColor_Vec4(idx, col);
        }
        public static void PushStyleVar(ImNodesStyleVar idx, float val)
        {
            ImNodesRNative.ImNodes_Ez_PushStyleVar_Float(idx, val);
        }
        public static void PushStyleVar(ImNodesStyleVar idx, Vector2 val)
        {
            ImNodesRNative.ImNodes_Ez_PushStyleVar_Vec2(idx, val);
        }
        public static void SetContext(IntPtr ctx)
        {
            ImNodesRNative.ImNodes_Ez_SetContext(ctx);
        }
        public static CanvasState* GetCurrentCanvas()
        {
            CanvasState* ret = ImNodesRNative.ImNodes_GetCurrentCanvas();
            return ret;
        }
        public static bool GetNewConnection(ref void* input_node, ref byte* input_slot_title, ref void* output_node, ref byte* output_slot_title)
        {
            fixed (void** native_input_node = &input_node)
            {
                fixed (byte** native_input_slot_title = &input_slot_title)
                {
                    fixed (void** native_output_node = &output_node)
                    {
                        fixed (byte** native_output_slot_title = &output_slot_title)
                        {
                            byte ret = ImNodesRNative.ImNodes_GetNewConnection(native_input_node, native_input_slot_title, native_output_node, native_output_slot_title);
                            return ret != 0;
                        }
                    }
                }
            }
        }
        public static bool GetPendingConnection(ref void* node_id, ref byte* slot_title, ref int slot_kind)
        {
            fixed (void** native_node_id = &node_id)
            {
                fixed (byte** native_slot_title = &slot_title)
                {
                    fixed (int* native_slot_kind = &slot_kind)
                    {
                        byte ret = ImNodesRNative.ImNodes_GetPendingConnection(native_node_id, native_slot_title, native_slot_kind);
                        return ret != 0;
                    }
                }
            }
        }
        public static int InputSlotKind(int kind)
        {
            int ret = ImNodesRNative.ImNodes_InputSlotKind(kind);
            return ret;
        }
        public static bool IsConnectingCompatibleSlot()
        {
            byte ret = ImNodesRNative.ImNodes_IsConnectingCompatibleSlot();
            return ret != 0;
        }
        public static bool IsInputSlotKind(int kind)
        {
            byte ret = ImNodesRNative.ImNodes_IsInputSlotKind(kind);
            return ret != 0;
        }
        public static bool IsNodeHovered()
        {
            byte ret = ImNodesRNative.ImNodes_IsNodeHovered();
            return ret != 0;
        }
        public static bool IsOutputSlotKind(int kind)
        {
            byte ret = ImNodesRNative.ImNodes_IsOutputSlotKind(kind);
            return ret != 0;
        }
        public static bool IsSlotCurveHovered()
        {
            byte ret = ImNodesRNative.ImNodes_IsSlotCurveHovered();
            return ret != 0;
        }
        public static int OutputSlotKind(int kind)
        {
            int ret = ImNodesRNative.ImNodes_OutputSlotKind(kind);
            return ret;
        }
    }
}
