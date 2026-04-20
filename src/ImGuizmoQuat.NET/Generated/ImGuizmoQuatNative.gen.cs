using System;
using System.Numerics;
using System.Runtime.InteropServices;
using ImGuiNET;

namespace ImGuizmoQuatNET
{
    public static unsafe partial class ImGuizmoQuatNative
    {
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte iggizmo3D_quatPtrFloat(byte* t, Vector4* q, float sz, uint flag);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte iggizmo3D_vec4Ptr(byte* t, Vector4* v, float sz, uint flag);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte iggizmo3D_vec3PtrFloat(byte* t, Vector3* v, float sz, uint flag);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte iggizmo3D_quatPtrquatPtr(byte* t, Vector4* q, Vector4* ql, float sz, uint flag);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte iggizmo3D_quatPtrvec4Ptr(byte* t, Vector4* q, Vector4* v, float sz, uint flag);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte iggizmo3D_quatPtrvec3Ptr(byte* t, Vector4* q, Vector3* v, float sz, uint flag);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte iggizmo3D_vec3PtrquatPtrFloat(byte* t, Vector3* vm, Vector4* q, float sz, uint flag);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte iggizmo3D_vec3Ptrvec4Ptr(byte* t, Vector3* vm, Vector4* v, float sz, uint flag);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte iggizmo3D_vec3Ptrvec3Ptr(byte* t, Vector3* vm, Vector3* v, float sz, uint flag);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte iggizmo3D_vec3PtrquatPtrquatPtr(byte* t, Vector3* vm, Vector4* q, Vector4* ql, float sz, uint flag);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte iggizmo3D_vec3PtrquatPtrvec4Ptr(byte* t, Vector3* vm, Vector4* q, Vector4* v, float sz, uint flag);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte iggizmo3D_vec3PtrquatPtrvec3Ptr(byte* t, Vector3* vm, Vector4* q, Vector3* v, float sz, uint flag);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_buildCone(float x0, float x1, float radius, int slices);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_buildCube(float size);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_buildCylinder(float x0, float x1, float radius, int slices);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_buildPlane(float size, float thickness);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_buildPolygon(Vector3 size, ImVector* vtx, ImVector* norm);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_buildSphere(float radius, int tessFactor);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector3 imguiGizmo_checkTowards_vec3(imguiGizmo* self, Vector3 v);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4 imguiGizmo_checkTowards_vec4(imguiGizmo* self, Vector4 v);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4 imguiGizmo_checkTowards_quat(imguiGizmo* self, Vector4 q);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte imguiGizmo_drawFunc(imguiGizmo* self, byte* label, float size);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_flipRotOnX(byte b);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_flipRotOnY(byte b);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_flipRotOnZ(byte b);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern float imguiGizmo_getDollyScale();
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern float imguiGizmo_getDollyWheelScale();
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte imguiGizmo_getFlipDolly();
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte imguiGizmo_getFlipPanX();
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte imguiGizmo_getFlipPanY();
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte imguiGizmo_getFlipRotOnX();
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte imguiGizmo_getFlipRotOnY();
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte imguiGizmo_getFlipRotOnZ();
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern float imguiGizmo_getGizmoFeelingRot();
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern float imguiGizmo_getPanScale();
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte imguiGizmo_getReverseX();
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte imguiGizmo_getReverseY();
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte imguiGizmo_getReverseZ();
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte imguiGizmo_getTransforms_vec3Ptr(imguiGizmo* self, Vector4* q, byte* label, Vector3* vDir, float size);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte imguiGizmo_getTransforms_vec4Ptr(imguiGizmo* self, Vector4* q, byte* label, Vector4* axis_angle, float size);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_modeSettings(imguiGizmo* self, uint mode);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_resizeAxesOf(Vector3 newSize);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_resizeSolidOf(float newSize);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_restoreAxesSize();
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_restoreDirectionColor();
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_restoreSolidSize();
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_restoreSphereColors();
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_reverseX(byte b);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_reverseY(byte b);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_reverseZ(byte b);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_setDirectionColor_U32U32(uint dColor, uint pColor);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_setDirectionColor_Vec4Vec4(Vector4 dColor, Vector4 pColor);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_setDirectionColor_U32(uint color);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_setDirectionColor_Vec4(Vector4 color);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_setDollyModifier(int v);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_setDollyScale(float scale);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_setDollyWheelScale(float scale);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_setDualMode(imguiGizmo* self, uint mode);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_setFlipDolly(byte b);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_setFlipPanX(byte b);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_setFlipPanY(byte b);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_setGizmoFeelingRot(float f);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_setPanModifier(int v);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_setPanScale(float scale);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_setSphereColors_Vec4(Vector4 a, Vector4 b);
        [DllImport("cimguizmo_quat", CallingConvention = CallingConvention.Cdecl)]
        public static extern void imguiGizmo_setSphereColors_U32(uint a, uint b);
    }
}
