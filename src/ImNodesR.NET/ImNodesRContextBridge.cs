using System;
using System.Runtime.InteropServices;

namespace ImNodesRNET
{
    public static unsafe partial class ImNodesRNative
    {
        [DllImport("cimnodes_r", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImNodesR_SetImGuiContext(IntPtr ctx);
    }

    public static unsafe partial class ImNodesR
    {
        public static void SetImGuiContext(IntPtr ctx)
        {
            ImNodesRNative.ImNodesR_SetImGuiContext(ctx);
        }
    }
}
