using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using ImGuiNET;

namespace ImGuizmoQuatNET
{
    public static unsafe partial class ImGuizmoQuat
    {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector4 q)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            float sz = ImGui.GetFrameHeightWithSpacing() * 4 - (ImGui.GetStyle().ItemSpacing.Y * 2);
            uint flag = 257;
            fixed (Vector4* native_q = &q)
            {
                byte ret = ImGuizmoQuatNative.iggizmo3D_quatPtrFloat(native_t, native_q, sz, flag);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_t);
                }
                return ret != 0;
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector4 q)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            float sz = ImGui.GetFrameHeightWithSpacing() * 4 - (ImGui.GetStyle().ItemSpacing.Y * 2);
            uint flag = 257;
            fixed (Vector4* native_q = &q)
            {
                byte ret = ImGuizmoQuatNative.iggizmo3D_quatPtrFloat(native_t, native_q, sz, flag);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_t);
                }
                return ret != 0;
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector4 q, float sz)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            uint flag = 257;
            fixed (Vector4* native_q = &q)
            {
                byte ret = ImGuizmoQuatNative.iggizmo3D_quatPtrFloat(native_t, native_q, sz, flag);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_t);
                }
                return ret != 0;
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector4 q, float sz)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            uint flag = 257;
            fixed (Vector4* native_q = &q)
            {
                byte ret = ImGuizmoQuatNative.iggizmo3D_quatPtrFloat(native_t, native_q, sz, flag);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_t);
                }
                return ret != 0;
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector4 q, float sz, uint flag)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            fixed (Vector4* native_q = &q)
            {
                byte ret = ImGuizmoQuatNative.iggizmo3D_quatPtrFloat(native_t, native_q, sz, flag);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_t);
                }
                return ret != 0;
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector4 q, float sz, uint flag)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            fixed (Vector4* native_q = &q)
            {
                byte ret = ImGuizmoQuatNative.iggizmo3D_quatPtrFloat(native_t, native_q, sz, flag);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_t);
                }
                return ret != 0;
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector3 v)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            float sz = ImGui.GetFrameHeightWithSpacing() * 4 - (ImGui.GetStyle().ItemSpacing.Y * 2);
            uint flag = 2;
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrFloat(native_t, native_v, sz, flag);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_t);
                }
                return ret != 0;
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector3 v)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            float sz = ImGui.GetFrameHeightWithSpacing() * 4 - (ImGui.GetStyle().ItemSpacing.Y * 2);
            uint flag = 2;
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrFloat(native_t, native_v, sz, flag);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_t);
                }
                return ret != 0;
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector3 v, float sz)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            uint flag = 2;
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrFloat(native_t, native_v, sz, flag);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_t);
                }
                return ret != 0;
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector3 v, float sz)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            uint flag = 2;
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrFloat(native_t, native_v, sz, flag);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_t);
                }
                return ret != 0;
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector3 v, float sz, uint flag)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrFloat(native_t, native_v, sz, flag);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_t);
                }
                return ret != 0;
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector3 v, float sz, uint flag)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            fixed (Vector3* native_v = &v)
            {
                byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrFloat(native_t, native_v, sz, flag);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    Util.Free(native_t);
                }
                return ret != 0;
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector4 q, ref Vector4 ql)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            float sz = ImGui.GetFrameHeightWithSpacing() * 4 - (ImGui.GetStyle().ItemSpacing.Y * 2);
            uint flag = 264;
            fixed (Vector4* native_q = &q)
            {
                fixed (Vector4* native_ql = &ql)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_quatPtrquatPtr(native_t, native_q, native_ql, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector4 q, ref Vector4 ql)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            float sz = ImGui.GetFrameHeightWithSpacing() * 4 - (ImGui.GetStyle().ItemSpacing.Y * 2);
            uint flag = 264;
            fixed (Vector4* native_q = &q)
            {
                fixed (Vector4* native_ql = &ql)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_quatPtrquatPtr(native_t, native_q, native_ql, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector4 q, ref Vector4 ql, float sz)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            uint flag = 264;
            fixed (Vector4* native_q = &q)
            {
                fixed (Vector4* native_ql = &ql)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_quatPtrquatPtr(native_t, native_q, native_ql, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector4 q, ref Vector4 ql, float sz)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            uint flag = 264;
            fixed (Vector4* native_q = &q)
            {
                fixed (Vector4* native_ql = &ql)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_quatPtrquatPtr(native_t, native_q, native_ql, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector4 q, ref Vector4 ql, float sz, uint flag)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            fixed (Vector4* native_q = &q)
            {
                fixed (Vector4* native_ql = &ql)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_quatPtrquatPtr(native_t, native_q, native_ql, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector4 q, ref Vector4 ql, float sz, uint flag)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            fixed (Vector4* native_q = &q)
            {
                fixed (Vector4* native_ql = &ql)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_quatPtrquatPtr(native_t, native_q, native_ql, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector4 q, ref Vector3 v)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            float sz = ImGui.GetFrameHeightWithSpacing() * 4 - (ImGui.GetStyle().ItemSpacing.Y * 2);
            uint flag = 264;
            fixed (Vector4* native_q = &q)
            {
                fixed (Vector3* native_v = &v)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_quatPtrvec3Ptr(native_t, native_q, native_v, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector4 q, ref Vector3 v)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            float sz = ImGui.GetFrameHeightWithSpacing() * 4 - (ImGui.GetStyle().ItemSpacing.Y * 2);
            uint flag = 264;
            fixed (Vector4* native_q = &q)
            {
                fixed (Vector3* native_v = &v)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_quatPtrvec3Ptr(native_t, native_q, native_v, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector4 q, ref Vector3 v, float sz)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            uint flag = 264;
            fixed (Vector4* native_q = &q)
            {
                fixed (Vector3* native_v = &v)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_quatPtrvec3Ptr(native_t, native_q, native_v, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector4 q, ref Vector3 v, float sz)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            uint flag = 264;
            fixed (Vector4* native_q = &q)
            {
                fixed (Vector3* native_v = &v)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_quatPtrvec3Ptr(native_t, native_q, native_v, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector4 q, ref Vector3 v, float sz, uint flag)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            fixed (Vector4* native_q = &q)
            {
                fixed (Vector3* native_v = &v)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_quatPtrvec3Ptr(native_t, native_q, native_v, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector4 q, ref Vector3 v, float sz, uint flag)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            fixed (Vector4* native_q = &q)
            {
                fixed (Vector3* native_v = &v)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_quatPtrvec3Ptr(native_t, native_q, native_v, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector3 vm, ref Vector4 q)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            float sz = ImGui.GetFrameHeightWithSpacing() * 4 - (ImGui.GetStyle().ItemSpacing.Y * 2);
            uint flag = 257;
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector4* native_q = &q)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrquatPtrFloat(native_t, native_vm, native_q, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector3 vm, ref Vector4 q)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            float sz = ImGui.GetFrameHeightWithSpacing() * 4 - (ImGui.GetStyle().ItemSpacing.Y * 2);
            uint flag = 257;
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector4* native_q = &q)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrquatPtrFloat(native_t, native_vm, native_q, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector3 vm, ref Vector4 q, float sz)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            uint flag = 257;
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector4* native_q = &q)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrquatPtrFloat(native_t, native_vm, native_q, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector3 vm, ref Vector4 q, float sz)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            uint flag = 257;
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector4* native_q = &q)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrquatPtrFloat(native_t, native_vm, native_q, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector3 vm, ref Vector4 q, float sz, uint flag)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector4* native_q = &q)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrquatPtrFloat(native_t, native_vm, native_q, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector3 vm, ref Vector4 q, float sz, uint flag)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector4* native_q = &q)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrquatPtrFloat(native_t, native_vm, native_q, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector3 vm, ref Vector3 v)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            float sz = ImGui.GetFrameHeightWithSpacing() * 4 - (ImGui.GetStyle().ItemSpacing.Y * 2);
            uint flag = 2;
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector3* native_v = &v)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_vec3Ptrvec3Ptr(native_t, native_vm, native_v, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector3 vm, ref Vector3 v)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            float sz = ImGui.GetFrameHeightWithSpacing() * 4 - (ImGui.GetStyle().ItemSpacing.Y * 2);
            uint flag = 2;
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector3* native_v = &v)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_vec3Ptrvec3Ptr(native_t, native_vm, native_v, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector3 vm, ref Vector3 v, float sz)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            uint flag = 2;
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector3* native_v = &v)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_vec3Ptrvec3Ptr(native_t, native_vm, native_v, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector3 vm, ref Vector3 v, float sz)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            uint flag = 2;
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector3* native_v = &v)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_vec3Ptrvec3Ptr(native_t, native_vm, native_v, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector3 vm, ref Vector3 v, float sz, uint flag)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector3* native_v = &v)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_vec3Ptrvec3Ptr(native_t, native_vm, native_v, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector3 vm, ref Vector3 v, float sz, uint flag)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector3* native_v = &v)
                {
                    byte ret = ImGuizmoQuatNative.iggizmo3D_vec3Ptrvec3Ptr(native_t, native_vm, native_v, sz, flag);
                    if (t_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_t);
                    }
                    return ret != 0;
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector3 vm, ref Vector4 q, ref Vector4 ql)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            float sz = ImGui.GetFrameHeightWithSpacing() * 4 - (ImGui.GetStyle().ItemSpacing.Y * 2);
            uint flag = 264;
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector4* native_q = &q)
                {
                    fixed (Vector4* native_ql = &ql)
                    {
                        byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrquatPtrquatPtr(native_t, native_vm, native_q, native_ql, sz, flag);
                        if (t_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_t);
                        }
                        return ret != 0;
                    }
                }
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector3 vm, ref Vector4 q, ref Vector4 ql)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            float sz = ImGui.GetFrameHeightWithSpacing() * 4 - (ImGui.GetStyle().ItemSpacing.Y * 2);
            uint flag = 264;
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector4* native_q = &q)
                {
                    fixed (Vector4* native_ql = &ql)
                    {
                        byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrquatPtrquatPtr(native_t, native_vm, native_q, native_ql, sz, flag);
                        if (t_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_t);
                        }
                        return ret != 0;
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector3 vm, ref Vector4 q, ref Vector4 ql, float sz)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            uint flag = 264;
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector4* native_q = &q)
                {
                    fixed (Vector4* native_ql = &ql)
                    {
                        byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrquatPtrquatPtr(native_t, native_vm, native_q, native_ql, sz, flag);
                        if (t_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_t);
                        }
                        return ret != 0;
                    }
                }
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector3 vm, ref Vector4 q, ref Vector4 ql, float sz)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            uint flag = 264;
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector4* native_q = &q)
                {
                    fixed (Vector4* native_ql = &ql)
                    {
                        byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrquatPtrquatPtr(native_t, native_vm, native_q, native_ql, sz, flag);
                        if (t_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_t);
                        }
                        return ret != 0;
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector3 vm, ref Vector4 q, ref Vector4 ql, float sz, uint flag)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector4* native_q = &q)
                {
                    fixed (Vector4* native_ql = &ql)
                    {
                        byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrquatPtrquatPtr(native_t, native_vm, native_q, native_ql, sz, flag);
                        if (t_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_t);
                        }
                        return ret != 0;
                    }
                }
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector3 vm, ref Vector4 q, ref Vector4 ql, float sz, uint flag)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector4* native_q = &q)
                {
                    fixed (Vector4* native_ql = &ql)
                    {
                        byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrquatPtrquatPtr(native_t, native_vm, native_q, native_ql, sz, flag);
                        if (t_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_t);
                        }
                        return ret != 0;
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector3 vm, ref Vector4 q, ref Vector3 v)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            float sz = ImGui.GetFrameHeightWithSpacing() * 4 - (ImGui.GetStyle().ItemSpacing.Y * 2);
            uint flag = 264;
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector4* native_q = &q)
                {
                    fixed (Vector3* native_v = &v)
                    {
                        byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrquatPtrvec3Ptr(native_t, native_vm, native_q, native_v, sz, flag);
                        if (t_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_t);
                        }
                        return ret != 0;
                    }
                }
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector3 vm, ref Vector4 q, ref Vector3 v)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            float sz = ImGui.GetFrameHeightWithSpacing() * 4 - (ImGui.GetStyle().ItemSpacing.Y * 2);
            uint flag = 264;
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector4* native_q = &q)
                {
                    fixed (Vector3* native_v = &v)
                    {
                        byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrquatPtrvec3Ptr(native_t, native_vm, native_q, native_v, sz, flag);
                        if (t_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_t);
                        }
                        return ret != 0;
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector3 vm, ref Vector4 q, ref Vector3 v, float sz)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            uint flag = 264;
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector4* native_q = &q)
                {
                    fixed (Vector3* native_v = &v)
                    {
                        byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrquatPtrvec3Ptr(native_t, native_vm, native_q, native_v, sz, flag);
                        if (t_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_t);
                        }
                        return ret != 0;
                    }
                }
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector3 vm, ref Vector4 q, ref Vector3 v, float sz)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            uint flag = 264;
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector4* native_q = &q)
                {
                    fixed (Vector3* native_v = &v)
                    {
                        byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrquatPtrvec3Ptr(native_t, native_vm, native_q, native_v, sz, flag);
                        if (t_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_t);
                        }
                        return ret != 0;
                    }
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public static bool gizmo3D(ReadOnlySpan<char> t, ref Vector3 vm, ref Vector4 q, ref Vector3 v, float sz, uint flag)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector4* native_q = &q)
                {
                    fixed (Vector3* native_v = &v)
                    {
                        byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrquatPtrvec3Ptr(native_t, native_vm, native_q, native_v, sz, flag);
                        if (t_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_t);
                        }
                        return ret != 0;
                    }
                }
            }
        }
#endif
        public static bool gizmo3D(string t, ref Vector3 vm, ref Vector4 q, ref Vector3 v, float sz, uint flag)
        {
            byte* native_t;
            int t_byteCount = 0;
            if (t != null)
            {
                t_byteCount = Encoding.UTF8.GetByteCount(t);
                if (t_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_t = Util.Allocate(t_byteCount + 1);
                }
                else
                {
                    byte* native_t_stackBytes = stackalloc byte[t_byteCount + 1];
                    native_t = native_t_stackBytes;
                }
                int native_t_offset = Util.GetUtf8(t, native_t, t_byteCount);
                native_t[native_t_offset] = 0;
            }
            else { native_t = null; }
            fixed (Vector3* native_vm = &vm)
            {
                fixed (Vector4* native_q = &q)
                {
                    fixed (Vector3* native_v = &v)
                    {
                        byte ret = ImGuizmoQuatNative.iggizmo3D_vec3PtrquatPtrvec3Ptr(native_t, native_vm, native_q, native_v, sz, flag);
                        if (t_byteCount > Util.StackAllocationSizeLimit)
                        {
                            Util.Free(native_t);
                        }
                        return ret != 0;
                    }
                }
            }
        }
    }
}
