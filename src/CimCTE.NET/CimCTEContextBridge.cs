using System;
using System.Runtime.InteropServices;

namespace CimCTENET
{
    public static unsafe partial class CimCTENative
    {
        [DllImport("cimCTE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void CimCTE_SetImGuiContext(IntPtr ctx);
    }

    public static unsafe partial class CimCTE
    {
        public static void SetImGuiContext(IntPtr ctx)
        {
            CimCTENative.CimCTE_SetImGuiContext(ctx);
        }
    }
}
