using System;
using System.Runtime.InteropServices;

namespace ImGuizmoQuatNET
{
    public static unsafe partial class ImGuizmoQuatNative
    {
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmoQuat_SetImGuiContext(IntPtr ctx);
    }

    public static unsafe partial class ImGuizmoQuat
    {
        public static void SetImGuiContext(IntPtr ctx)
        {
            ImGuizmoQuatNative.ImGuizmoQuat_SetImGuiContext(ctx);
        }
    }
}
