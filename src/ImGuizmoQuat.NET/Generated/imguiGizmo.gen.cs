using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImGuizmoQuatNET
{
    public unsafe partial struct imguiGizmo
    {
        public Vector4 qtV;
        public Vector4 qtV2;
        public Vector3 posPanDolly;
        public int buttonPanDolly;
        public Vector3 axesVecModifier;
        public int drawMode;
        public int axesOriginType;
        public byte showFullAxes;
    }
    public unsafe partial struct imguiGizmoPtr
    {
        public imguiGizmo* NativePtr { get; }
        public imguiGizmoPtr(imguiGizmo* nativePtr) => NativePtr = nativePtr;
        public imguiGizmoPtr(IntPtr nativePtr) => NativePtr = (imguiGizmo*)nativePtr;
        public static implicit operator imguiGizmoPtr(imguiGizmo* nativePtr) => new imguiGizmoPtr(nativePtr);
        public static implicit operator imguiGizmo* (imguiGizmoPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator imguiGizmoPtr(IntPtr nativePtr) => new imguiGizmoPtr(nativePtr);
        public ref Vector4 qtV => ref Unsafe.AsRef<Vector4>(&NativePtr->qtV);
        public ref Vector4 qtV2 => ref Unsafe.AsRef<Vector4>(&NativePtr->qtV2);
        public ref Vector3 posPanDolly => ref Unsafe.AsRef<Vector3>(&NativePtr->posPanDolly);
        public ref int buttonPanDolly => ref Unsafe.AsRef<int>(&NativePtr->buttonPanDolly);
        public ref Vector3 axesVecModifier => ref Unsafe.AsRef<Vector3>(&NativePtr->axesVecModifier);
        public ref int drawMode => ref Unsafe.AsRef<int>(&NativePtr->drawMode);
        public ref int axesOriginType => ref Unsafe.AsRef<int>(&NativePtr->axesOriginType);
        public ref bool showFullAxes => ref Unsafe.AsRef<bool>(&NativePtr->showFullAxes);
        public void buildCone(float x0, float x1, float radius, int slices)
        {
            ImGuizmoQuatNative.imguiGizmo_buildCone(x0, x1, radius, slices);
        }
        public void buildCube(float size)
        {
            ImGuizmoQuatNative.imguiGizmo_buildCube(size);
        }
        public void buildCylinder(float x0, float x1, float radius, int slices)
        {
            ImGuizmoQuatNative.imguiGizmo_buildCylinder(x0, x1, radius, slices);
        }
        public void buildPlane(float size)
        {
            float thickness = 0.04f;
            ImGuizmoQuatNative.imguiGizmo_buildPlane(size, thickness);
        }
        public void buildPlane(float size, float thickness)
        {
            ImGuizmoQuatNative.imguiGizmo_buildPlane(size, thickness);
        }
        public void buildPolygon(Vector3 size, ref ImVector vtx, ref ImVector norm)
        {
            fixed (ImVector* native_vtx = &vtx)
            {
                fixed (ImVector* native_norm = &norm)
                {
                    ImGuizmoQuatNative.imguiGizmo_buildPolygon(size, native_vtx, native_norm);
                }
            }
        }
        public void buildSphere(float radius, int tessFactor)
        {
            ImGuizmoQuatNative.imguiGizmo_buildSphere(radius, tessFactor);
        }
        public Vector3 checkTowards(Vector3 v)
        {
            Vector3 ret = ImGuizmoQuatNative.imguiGizmo_checkTowards_vec3((imguiGizmo*)(NativePtr), v);
            return ret;
        }
        public Vector4 checkTowards(Vector4 v)
        {
            Vector4 ret = ImGuizmoQuatNative.imguiGizmo_checkTowards_vec4((imguiGizmo*)(NativePtr), v);
            return ret;
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public bool drawFunc(ReadOnlySpan<char> label, float size)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImGuizmoQuatNative.imguiGizmo_drawFunc((imguiGizmo*)(NativePtr), native_label, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
#endif
        public bool drawFunc(string label, float size)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            byte ret = ImGuizmoQuatNative.imguiGizmo_drawFunc((imguiGizmo*)(NativePtr), native_label, size);
            if (label_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_label);
            }
            return ret != 0;
        }
        public void flipRotOnX()
        {
            byte b = 1;
            ImGuizmoQuatNative.imguiGizmo_flipRotOnX(b);
        }
        public void flipRotOnX(bool b)
        {
            byte native_b = b ? (byte)1 : (byte)0;
            ImGuizmoQuatNative.imguiGizmo_flipRotOnX(native_b);
        }
        public void flipRotOnY()
        {
            byte b = 1;
            ImGuizmoQuatNative.imguiGizmo_flipRotOnY(b);
        }
        public void flipRotOnY(bool b)
        {
            byte native_b = b ? (byte)1 : (byte)0;
            ImGuizmoQuatNative.imguiGizmo_flipRotOnY(native_b);
        }
        public void flipRotOnZ()
        {
            byte b = 1;
            ImGuizmoQuatNative.imguiGizmo_flipRotOnZ(b);
        }
        public void flipRotOnZ(bool b)
        {
            byte native_b = b ? (byte)1 : (byte)0;
            ImGuizmoQuatNative.imguiGizmo_flipRotOnZ(native_b);
        }
        public float getDollyScale()
        {
            float ret = ImGuizmoQuatNative.imguiGizmo_getDollyScale();
            return ret;
        }
        public float getDollyWheelScale()
        {
            float ret = ImGuizmoQuatNative.imguiGizmo_getDollyWheelScale();
            return ret;
        }
        public bool getFlipDolly()
        {
            byte ret = ImGuizmoQuatNative.imguiGizmo_getFlipDolly();
            return ret != 0;
        }
        public bool getFlipPanX()
        {
            byte ret = ImGuizmoQuatNative.imguiGizmo_getFlipPanX();
            return ret != 0;
        }
        public bool getFlipPanY()
        {
            byte ret = ImGuizmoQuatNative.imguiGizmo_getFlipPanY();
            return ret != 0;
        }
        public bool getFlipRotOnX()
        {
            byte ret = ImGuizmoQuatNative.imguiGizmo_getFlipRotOnX();
            return ret != 0;
        }
        public bool getFlipRotOnY()
        {
            byte ret = ImGuizmoQuatNative.imguiGizmo_getFlipRotOnY();
            return ret != 0;
        }
        public bool getFlipRotOnZ()
        {
            byte ret = ImGuizmoQuatNative.imguiGizmo_getFlipRotOnZ();
            return ret != 0;
        }
        public float getGizmoFeelingRot()
        {
            float ret = ImGuizmoQuatNative.imguiGizmo_getGizmoFeelingRot();
            return ret;
        }
        public float getPanScale()
        {
            float ret = ImGuizmoQuatNative.imguiGizmo_getPanScale();
            return ret;
        }
        public bool getReverseX()
        {
            byte ret = ImGuizmoQuatNative.imguiGizmo_getReverseX();
            return ret != 0;
        }
        public bool getReverseY()
        {
            byte ret = ImGuizmoQuatNative.imguiGizmo_getReverseY();
            return ret != 0;
        }
        public bool getReverseZ()
        {
            byte ret = ImGuizmoQuatNative.imguiGizmo_getReverseZ();
            return ret != 0;
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public bool getTransforms(ref Vector4 q, ReadOnlySpan<char> label, ref Vector3 vDir, float size)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (Vector4* native_q = &q)
            {
                fixed (Vector3* native_vDir = &vDir)
                {
                    byte ret = ImGuizmoQuatNative.imguiGizmo_getTransforms_vec3Ptr((imguiGizmo*)(NativePtr), native_q, native_label, native_vDir, size);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    return ret != 0;
                }
            }
        }
#endif
        public bool getTransforms(ref Vector4 q, string label, ref Vector3 vDir, float size)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (Vector4* native_q = &q)
            {
                fixed (Vector3* native_vDir = &vDir)
                {
                    byte ret = ImGuizmoQuatNative.imguiGizmo_getTransforms_vec3Ptr((imguiGizmo*)(NativePtr), native_q, native_label, native_vDir, size);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    return ret != 0;
                }
            }
        }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
        public bool getTransforms(ref Vector4 q, ReadOnlySpan<char> label, ref Vector4 axis_angle, float size)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (Vector4* native_q = &q)
            {
                fixed (Vector4* native_axis_angle = &axis_angle)
                {
                    byte ret = ImGuizmoQuatNative.imguiGizmo_getTransforms_vec4Ptr((imguiGizmo*)(NativePtr), native_q, native_label, native_axis_angle, size);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    return ret != 0;
                }
            }
        }
#endif
        public bool getTransforms(ref Vector4 q, string label, ref Vector4 axis_angle, float size)
        {
            byte* native_label;
            int label_byteCount = 0;
            if (label != null)
            {
                label_byteCount = Encoding.UTF8.GetByteCount(label);
                if (label_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_label = Util.Allocate(label_byteCount + 1);
                }
                else
                {
                    byte* native_label_stackBytes = stackalloc byte[label_byteCount + 1];
                    native_label = native_label_stackBytes;
                }
                int native_label_offset = Util.GetUtf8(label, native_label, label_byteCount);
                native_label[native_label_offset] = 0;
            }
            else { native_label = null; }
            fixed (Vector4* native_q = &q)
            {
                fixed (Vector4* native_axis_angle = &axis_angle)
                {
                    byte ret = ImGuizmoQuatNative.imguiGizmo_getTransforms_vec4Ptr((imguiGizmo*)(NativePtr), native_q, native_label, native_axis_angle, size);
                    if (label_byteCount > Util.StackAllocationSizeLimit)
                    {
                        Util.Free(native_label);
                    }
                    return ret != 0;
                }
            }
        }
        public void modeSettings(uint mode)
        {
            ImGuizmoQuatNative.imguiGizmo_modeSettings((imguiGizmo*)(NativePtr), mode);
        }
        public void resizeAxesOf(Vector3 newSize)
        {
            ImGuizmoQuatNative.imguiGizmo_resizeAxesOf(newSize);
        }
        public void resizeSolidOf(float newSize)
        {
            ImGuizmoQuatNative.imguiGizmo_resizeSolidOf(newSize);
        }
        public void restoreAxesSize()
        {
            ImGuizmoQuatNative.imguiGizmo_restoreAxesSize();
        }
        public void restoreDirectionColor()
        {
            ImGuizmoQuatNative.imguiGizmo_restoreDirectionColor();
        }
        public void restoreSolidSize()
        {
            ImGuizmoQuatNative.imguiGizmo_restoreSolidSize();
        }
        public void restoreSphereColors()
        {
            ImGuizmoQuatNative.imguiGizmo_restoreSphereColors();
        }
        public void reverseX()
        {
            byte b = 1;
            ImGuizmoQuatNative.imguiGizmo_reverseX(b);
        }
        public void reverseX(bool b)
        {
            byte native_b = b ? (byte)1 : (byte)0;
            ImGuizmoQuatNative.imguiGizmo_reverseX(native_b);
        }
        public void reverseY()
        {
            byte b = 1;
            ImGuizmoQuatNative.imguiGizmo_reverseY(b);
        }
        public void reverseY(bool b)
        {
            byte native_b = b ? (byte)1 : (byte)0;
            ImGuizmoQuatNative.imguiGizmo_reverseY(native_b);
        }
        public void reverseZ()
        {
            byte b = 1;
            ImGuizmoQuatNative.imguiGizmo_reverseZ(b);
        }
        public void reverseZ(bool b)
        {
            byte native_b = b ? (byte)1 : (byte)0;
            ImGuizmoQuatNative.imguiGizmo_reverseZ(native_b);
        }
        public void setDirectionColor(uint dColor, uint pColor)
        {
            ImGuizmoQuatNative.imguiGizmo_setDirectionColor_U32U32(dColor, pColor);
        }
        public void setDirectionColor(Vector4 dColor, Vector4 pColor)
        {
            ImGuizmoQuatNative.imguiGizmo_setDirectionColor_Vec4Vec4(dColor, pColor);
        }
        public void setDirectionColor(uint color)
        {
            ImGuizmoQuatNative.imguiGizmo_setDirectionColor_U32(color);
        }
        public void setDirectionColor(Vector4 color)
        {
            ImGuizmoQuatNative.imguiGizmo_setDirectionColor_Vec4(color);
        }
        public void setDollyModifier(int v)
        {
            ImGuizmoQuatNative.imguiGizmo_setDollyModifier(v);
        }
        public void setDollyScale(float scale)
        {
            ImGuizmoQuatNative.imguiGizmo_setDollyScale(scale);
        }
        public void setDollyWheelScale(float scale)
        {
            ImGuizmoQuatNative.imguiGizmo_setDollyWheelScale(scale);
        }
        public void setDualMode(uint mode)
        {
            ImGuizmoQuatNative.imguiGizmo_setDualMode((imguiGizmo*)(NativePtr), mode);
        }
        public void setFlipDolly(bool b)
        {
            byte native_b = b ? (byte)1 : (byte)0;
            ImGuizmoQuatNative.imguiGizmo_setFlipDolly(native_b);
        }
        public void setFlipPanX(bool b)
        {
            byte native_b = b ? (byte)1 : (byte)0;
            ImGuizmoQuatNative.imguiGizmo_setFlipPanX(native_b);
        }
        public void setFlipPanY(bool b)
        {
            byte native_b = b ? (byte)1 : (byte)0;
            ImGuizmoQuatNative.imguiGizmo_setFlipPanY(native_b);
        }
        public void setGizmoFeelingRot(float f)
        {
            ImGuizmoQuatNative.imguiGizmo_setGizmoFeelingRot(f);
        }
        public void setPanModifier(int v)
        {
            ImGuizmoQuatNative.imguiGizmo_setPanModifier(v);
        }
        public void setPanScale(float scale)
        {
            ImGuizmoQuatNative.imguiGizmo_setPanScale(scale);
        }
        public void setSphereColors(Vector4 a, Vector4 b)
        {
            ImGuizmoQuatNative.imguiGizmo_setSphereColors_Vec4(a, b);
        }
        public void setSphereColors(uint a, uint b)
        {
            ImGuizmoQuatNative.imguiGizmo_setSphereColors_U32(a, b);
        }
    }
}
