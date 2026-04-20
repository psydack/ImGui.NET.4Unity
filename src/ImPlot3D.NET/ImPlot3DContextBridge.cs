using System;
using System.Runtime.InteropServices;

namespace ImPlot3DNET
{
    public static unsafe partial class ImPlot3DNative
    {
        [DllImport("cimplot3d", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImPlot3D_SetImGuiContext(IntPtr ctx);
    }

    public static unsafe partial class ImPlot3D
    {
        public static void SetImGuiContext(IntPtr ctx)
        {
            ImPlot3DNative.ImPlot3D_SetImGuiContext(ctx);
        }
    }
}
