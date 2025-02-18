﻿#if USE_HOT && UNITY_STANDALONE_WIN
namespace AutoIL
{
    using ILRuntime.Runtime.Enviorment;

    static class ILRegType
    {
        static public void RegisterFunctionDelegate(AppDomain appdomain)
        {
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Reflection.AssemblyName, System.Reflection.Assembly>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Reflection.Assembly, System.String, System.Boolean, System.Type>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Type, System.Object, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Reflection.MemberInfo, System.Object, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Object, System.ResolveEventArgs, System.Reflection.Module>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Threading.Tasks.Task>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Exception, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.AsyncCallback, System.Object, System.IAsyncResult>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Object, System.Threading.Tasks.Task>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.IAsyncResult, System.Threading.Tasks.Task>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Threading.Tasks.Task[], System.Threading.Tasks.Task>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Threading.Tasks.Task, System.Threading.Tasks.Task>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Object, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.IAsyncResult, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Threading.Tasks.Task[], System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Threading.Tasks.Task, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Object>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Int32, System.Object>();
            appdomain.DelegateManager.RegisterFunctionDelegate<ILRuntime.CLR.TypeSystem.IType, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<ILRuntime.CLR.TypeSystem.IType, ILRuntime.CLR.TypeSystem.IType, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<ILRuntime.CLR.Method.IMethod, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<ILRuntime.CLR.Method.IMethod, ILRuntime.CLR.Method.IMethod, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Object, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<ILRuntime.CLR.Method.ILMethod, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<ILRuntime.CLR.Method.ILMethod, ILRuntime.CLR.Method.ILMethod, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<ILRuntime.Runtime.Intepreter.ILTypeInstance, ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Component, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Component, UnityEngine.Component, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.GameObject[], System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.GameObject[], UnityEngine.GameObject[], System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.GameObject, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.GameObject, UnityEngine.GameObject, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Single, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Single, System.Single, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Vector4, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Vector4, UnityEngine.Vector4, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Matrix4x4, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Matrix4x4, UnityEngine.Matrix4x4, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Camera.RenderRequest, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Camera.RenderRequest, UnityEngine.Camera.RenderRequest, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Rendering.SphericalHarmonicsL2, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Rendering.SphericalHarmonicsL2, UnityEngine.Rendering.SphericalHarmonicsL2, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.String, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.String, System.String, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Int32, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Int32, System.Int32, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Color, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Color, UnityEngine.Color, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Material, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Material, UnityEngine.Material, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Rendering.ReflectionProbeBlendInfo, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Rendering.ReflectionProbeBlendInfo, UnityEngine.Rendering.ReflectionProbeBlendInfo, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Vector3, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Vector3, UnityEngine.Vector3, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Color32, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Color32, UnityEngine.Color32, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Vector2, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Vector2, UnityEngine.Vector2, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Rendering.VertexAttributeDescriptor, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Rendering.VertexAttributeDescriptor, UnityEngine.Rendering.VertexAttributeDescriptor, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Mesh, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Mesh, UnityEngine.Mesh, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.UInt16, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.UInt16, System.UInt16, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Rendering.SubMeshDescriptor, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Rendering.SubMeshDescriptor, UnityEngine.Rendering.SubMeshDescriptor, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.BoneWeight, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.BoneWeight, UnityEngine.BoneWeight, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Collections.Generic.List<System.String>, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Collections.Generic.List<System.String>, System.Collections.Generic.List<System.String>, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Collections.Generic.List<System.Int32>, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Collections.Generic.List<System.Int32>, System.Collections.Generic.List<System.Int32>, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Object, System.Object, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Rect, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Rect, UnityEngine.Rect, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Reflection.FieldInfo, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Reflection.FieldInfo, System.Reflection.FieldInfo, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<wxb.Nested.AnyBase, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<wxb.Nested.AnyBase, wxb.Nested.AnyBase, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Object, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Object, UnityEngine.Object, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Type, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.Type, System.Type, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.EventSystems.RaycastResult, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.EventSystems.RaycastResult, UnityEngine.EventSystems.RaycastResult, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UIVertex, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UIVertex, UnityEngine.UIVertex, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.AnimatorClipInfo, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.AnimatorClipInfo, UnityEngine.AnimatorClipInfo, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UI.Selectable, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UI.Selectable, UnityEngine.UI.Selectable, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UI.RectMask2D, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UI.RectMask2D, UnityEngine.UI.RectMask2D, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UICharInfo, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UICharInfo, UnityEngine.UICharInfo, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UILineInfo, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UILineInfo, UnityEngine.UILineInfo, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UI.Dropdown.OptionData, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UI.Dropdown.OptionData, UnityEngine.UI.Dropdown.OptionData, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Sprite, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Sprite, UnityEngine.Sprite, System.Int32>();
            appdomain.DelegateManager.RegisterFunctionDelegate<System.String, System.Int32, System.Char, System.Char>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.UI.ILayoutElement, System.Single>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.EventSystems.EventTrigger.Entry, System.Boolean>();
            appdomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.EventSystems.EventTrigger.Entry, UnityEngine.EventSystems.EventTrigger.Entry, System.Int32>();

        }

        static public void RegisterDelegateConvertor(AppDomain appdomain)
        {
            appdomain.DelegateManager.RegisterDelegateConvertor<System.AsyncCallback>((act) =>
            {
                return new System.AsyncCallback((ar) =>
                {
                    ((System.Action<System.IAsyncResult>)act)(ar);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Reflection.TypeFilter>((act) =>
            {
                return new System.Reflection.TypeFilter((m, filterCriteria) =>
                {
                    return ((System.Func<System.Type, System.Object, System.Boolean>)act)(m, filterCriteria);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Reflection.MemberFilter>((act) =>
            {
                return new System.Reflection.MemberFilter((m, filterCriteria) =>
                {
                    return ((System.Func<System.Reflection.MemberInfo, System.Object, System.Boolean>)act)(m, filterCriteria);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Reflection.ModuleResolveEventHandler>((act) =>
            {
                return new System.Reflection.ModuleResolveEventHandler((sender, e) =>
                {
                    return ((System.Func<System.Object, System.ResolveEventArgs, System.Reflection.Module>)act)(sender, e);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Action>((act) =>
            {
                return new System.Action(() =>
                {
                    ((System.Action)act)();
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Font.FontTextureRebuildCallback>((act) =>
            {
                return new UnityEngine.Font.FontTextureRebuildCallback(() =>
                {
                    ((System.Action)act)();
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction>((act) =>
            {
                return new UnityEngine.Events.UnityAction(() =>
                {
                    ((System.Action)act)();
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Canvas.WillRenderCanvases>((act) =>
            {
                return new UnityEngine.Canvas.WillRenderCanvases(() =>
                {
                    ((System.Action)act)();
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.EventHandler<System.Threading.Tasks.UnobservedTaskExceptionEventArgs>>((act) =>
            {
                return new System.EventHandler<System.Threading.Tasks.UnobservedTaskExceptionEventArgs>((sender, e) =>
                {
                    ((System.Action<System.Object, System.Threading.Tasks.UnobservedTaskExceptionEventArgs>)act)(sender, e);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<ILRuntime.Runtime.Intepreter.ILTypeInstance>>((act) =>
            {
                return new System.Predicate<ILRuntime.Runtime.Intepreter.ILTypeInstance>((obj) =>
                {
                    return ((System.Func<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<ILRuntime.Runtime.Enviorment.CLRCreateDefaultInstanceDelegate>((act) =>
            {
                return new ILRuntime.Runtime.Enviorment.CLRCreateDefaultInstanceDelegate(() =>
                {
                    return ((System.Func<System.Object>)act)();
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<ILRuntime.Runtime.Enviorment.CLRCreateArrayInstanceDelegate>((act) =>
            {
                return new ILRuntime.Runtime.Enviorment.CLRCreateArrayInstanceDelegate((size) =>
                {
                    return ((System.Func<System.Int32, System.Object>)act)(size);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<ILRuntime.CLR.TypeSystem.IType>>((act) =>
            {
                return new System.Predicate<ILRuntime.CLR.TypeSystem.IType>((obj) =>
                {
                    return ((System.Func<ILRuntime.CLR.TypeSystem.IType, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<ILRuntime.CLR.TypeSystem.IType>>((act) =>
            {
                return new System.Comparison<ILRuntime.CLR.TypeSystem.IType>((x, y) =>
                {
                    return ((System.Func<ILRuntime.CLR.TypeSystem.IType, ILRuntime.CLR.TypeSystem.IType, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<System.String>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<System.String>((arg0) =>
                {
                    ((System.Action<System.String>)act)(arg0);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<ILRuntime.CLR.Method.IMethod>>((act) =>
            {
                return new System.Predicate<ILRuntime.CLR.Method.IMethod>((obj) =>
                {
                    return ((System.Func<ILRuntime.CLR.Method.IMethod, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<ILRuntime.CLR.Method.IMethod>>((act) =>
            {
                return new System.Comparison<ILRuntime.CLR.Method.IMethod>((x, y) =>
                {
                    return ((System.Func<ILRuntime.CLR.Method.IMethod, ILRuntime.CLR.Method.IMethod, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<System.Object>>((act) =>
            {
                return new System.Predicate<System.Object>((obj) =>
                {
                    return ((System.Func<System.Object, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<ILRuntime.CLR.Method.ILMethod>>((act) =>
            {
                return new System.Predicate<ILRuntime.CLR.Method.ILMethod>((obj) =>
                {
                    return ((System.Func<ILRuntime.CLR.Method.ILMethod, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<ILRuntime.CLR.Method.ILMethod>>((act) =>
            {
                return new System.Comparison<ILRuntime.CLR.Method.ILMethod>((x, y) =>
                {
                    return ((System.Func<ILRuntime.CLR.Method.ILMethod, ILRuntime.CLR.Method.ILMethod, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<ILRuntime.Runtime.Intepreter.ILTypeInstance>>((act) =>
            {
                return new System.Comparison<ILRuntime.Runtime.Intepreter.ILTypeInstance>((x, y) =>
                {
                    return ((System.Func<ILRuntime.Runtime.Intepreter.ILTypeInstance, ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Component>>((act) =>
            {
                return new System.Predicate<UnityEngine.Component>((obj) =>
                {
                    return ((System.Func<UnityEngine.Component, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Component>>((act) =>
            {
                return new System.Comparison<UnityEngine.Component>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Component, UnityEngine.Component, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.GameObject[]>>((act) =>
            {
                return new System.Predicate<UnityEngine.GameObject[]>((obj) =>
                {
                    return ((System.Func<UnityEngine.GameObject[], System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.GameObject[]>>((act) =>
            {
                return new System.Comparison<UnityEngine.GameObject[]>((x, y) =>
                {
                    return ((System.Func<UnityEngine.GameObject[], UnityEngine.GameObject[], System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.GameObject>>((act) =>
            {
                return new System.Predicate<UnityEngine.GameObject>((obj) =>
                {
                    return ((System.Func<UnityEngine.GameObject, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.GameObject>>((act) =>
            {
                return new System.Comparison<UnityEngine.GameObject>((x, y) =>
                {
                    return ((System.Func<UnityEngine.GameObject, UnityEngine.GameObject, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<System.Single>>((act) =>
            {
                return new System.Predicate<System.Single>((obj) =>
                {
                    return ((System.Func<System.Single, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<System.Single>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<System.Single>((arg0) =>
                {
                    ((System.Action<System.Single>)act)(arg0);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<System.Single>>((act) =>
            {
                return new System.Comparison<System.Single>((x, y) =>
                {
                    return ((System.Func<System.Single, System.Single, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Vector4>>((act) =>
            {
                return new System.Predicate<UnityEngine.Vector4>((obj) =>
                {
                    return ((System.Func<UnityEngine.Vector4, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Vector4>>((act) =>
            {
                return new System.Comparison<UnityEngine.Vector4>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Vector4, UnityEngine.Vector4, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Matrix4x4>>((act) =>
            {
                return new System.Predicate<UnityEngine.Matrix4x4>((obj) =>
                {
                    return ((System.Func<UnityEngine.Matrix4x4, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Matrix4x4>>((act) =>
            {
                return new System.Comparison<UnityEngine.Matrix4x4>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Matrix4x4, UnityEngine.Matrix4x4, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Camera.RenderRequest>>((act) =>
            {
                return new System.Predicate<UnityEngine.Camera.RenderRequest>((obj) =>
                {
                    return ((System.Func<UnityEngine.Camera.RenderRequest, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Camera.RenderRequest>>((act) =>
            {
                return new System.Comparison<UnityEngine.Camera.RenderRequest>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Camera.RenderRequest, UnityEngine.Camera.RenderRequest, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Rendering.SphericalHarmonicsL2>>((act) =>
            {
                return new System.Predicate<UnityEngine.Rendering.SphericalHarmonicsL2>((obj) =>
                {
                    return ((System.Func<UnityEngine.Rendering.SphericalHarmonicsL2, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Rendering.SphericalHarmonicsL2>>((act) =>
            {
                return new System.Comparison<UnityEngine.Rendering.SphericalHarmonicsL2>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Rendering.SphericalHarmonicsL2, UnityEngine.Rendering.SphericalHarmonicsL2, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<System.String>>((act) =>
            {
                return new System.Predicate<System.String>((obj) =>
                {
                    return ((System.Func<System.String, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<System.String>>((act) =>
            {
                return new System.Comparison<System.String>((x, y) =>
                {
                    return ((System.Func<System.String, System.String, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<System.Int32>>((act) =>
            {
                return new System.Predicate<System.Int32>((obj) =>
                {
                    return ((System.Func<System.Int32, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.GUI.WindowFunction>((act) =>
            {
                return new UnityEngine.GUI.WindowFunction((id) =>
                {
                    ((System.Action<System.Int32>)act)(id);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<System.Int32>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<System.Int32>((arg0) =>
                {
                    ((System.Action<System.Int32>)act)(arg0);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<System.Int32>>((act) =>
            {
                return new System.Comparison<System.Int32>((x, y) =>
                {
                    return ((System.Func<System.Int32, System.Int32, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Color>>((act) =>
            {
                return new System.Predicate<UnityEngine.Color>((obj) =>
                {
                    return ((System.Func<UnityEngine.Color, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Color>>((act) =>
            {
                return new System.Comparison<UnityEngine.Color>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Color, UnityEngine.Color, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Material>>((act) =>
            {
                return new System.Predicate<UnityEngine.Material>((obj) =>
                {
                    return ((System.Func<UnityEngine.Material, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Material>>((act) =>
            {
                return new System.Comparison<UnityEngine.Material>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Material, UnityEngine.Material, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Rendering.ReflectionProbeBlendInfo>>((act) =>
            {
                return new System.Predicate<UnityEngine.Rendering.ReflectionProbeBlendInfo>((obj) =>
                {
                    return ((System.Func<UnityEngine.Rendering.ReflectionProbeBlendInfo, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Rendering.ReflectionProbeBlendInfo>>((act) =>
            {
                return new System.Comparison<UnityEngine.Rendering.ReflectionProbeBlendInfo>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Rendering.ReflectionProbeBlendInfo, UnityEngine.Rendering.ReflectionProbeBlendInfo, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Vector3>>((act) =>
            {
                return new System.Predicate<UnityEngine.Vector3>((obj) =>
                {
                    return ((System.Func<UnityEngine.Vector3, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Vector3>>((act) =>
            {
                return new System.Comparison<UnityEngine.Vector3>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Vector3, UnityEngine.Vector3, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Color32>>((act) =>
            {
                return new System.Predicate<UnityEngine.Color32>((obj) =>
                {
                    return ((System.Func<UnityEngine.Color32, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Color32>>((act) =>
            {
                return new System.Comparison<UnityEngine.Color32>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Color32, UnityEngine.Color32, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Vector2>>((act) =>
            {
                return new System.Predicate<UnityEngine.Vector2>((obj) =>
                {
                    return ((System.Func<UnityEngine.Vector2, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<UnityEngine.Vector2>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<UnityEngine.Vector2>((arg0) =>
                {
                    ((System.Action<UnityEngine.Vector2>)act)(arg0);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Vector2>>((act) =>
            {
                return new System.Comparison<UnityEngine.Vector2>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Vector2, UnityEngine.Vector2, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Rendering.VertexAttributeDescriptor>>((act) =>
            {
                return new System.Predicate<UnityEngine.Rendering.VertexAttributeDescriptor>((obj) =>
                {
                    return ((System.Func<UnityEngine.Rendering.VertexAttributeDescriptor, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Rendering.VertexAttributeDescriptor>>((act) =>
            {
                return new System.Comparison<UnityEngine.Rendering.VertexAttributeDescriptor>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Rendering.VertexAttributeDescriptor, UnityEngine.Rendering.VertexAttributeDescriptor, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Mesh>>((act) =>
            {
                return new System.Predicate<UnityEngine.Mesh>((obj) =>
                {
                    return ((System.Func<UnityEngine.Mesh, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Mesh>>((act) =>
            {
                return new System.Comparison<UnityEngine.Mesh>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Mesh, UnityEngine.Mesh, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<System.UInt16>>((act) =>
            {
                return new System.Predicate<System.UInt16>((obj) =>
                {
                    return ((System.Func<System.UInt16, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<System.UInt16>>((act) =>
            {
                return new System.Comparison<System.UInt16>((x, y) =>
                {
                    return ((System.Func<System.UInt16, System.UInt16, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Rendering.SubMeshDescriptor>>((act) =>
            {
                return new System.Predicate<UnityEngine.Rendering.SubMeshDescriptor>((obj) =>
                {
                    return ((System.Func<UnityEngine.Rendering.SubMeshDescriptor, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Rendering.SubMeshDescriptor>>((act) =>
            {
                return new System.Comparison<UnityEngine.Rendering.SubMeshDescriptor>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Rendering.SubMeshDescriptor, UnityEngine.Rendering.SubMeshDescriptor, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.BoneWeight>>((act) =>
            {
                return new System.Predicate<UnityEngine.BoneWeight>((obj) =>
                {
                    return ((System.Func<UnityEngine.BoneWeight, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.BoneWeight>>((act) =>
            {
                return new System.Comparison<UnityEngine.BoneWeight>((x, y) =>
                {
                    return ((System.Func<UnityEngine.BoneWeight, UnityEngine.BoneWeight, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Camera.CameraCallback>((act) =>
            {
                return new UnityEngine.Camera.CameraCallback((cam) =>
                {
                    ((System.Action<UnityEngine.Camera>)act)(cam);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<System.Collections.Generic.List<System.String>>>((act) =>
            {
                return new System.Predicate<System.Collections.Generic.List<System.String>>((obj) =>
                {
                    return ((System.Func<System.Collections.Generic.List<System.String>, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<System.Collections.Generic.List<System.String>>>((act) =>
            {
                return new System.Comparison<System.Collections.Generic.List<System.String>>((x, y) =>
                {
                    return ((System.Func<System.Collections.Generic.List<System.String>, System.Collections.Generic.List<System.String>, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<System.Collections.Generic.List<System.Int32>>>((act) =>
            {
                return new System.Predicate<System.Collections.Generic.List<System.Int32>>((obj) =>
                {
                    return ((System.Func<System.Collections.Generic.List<System.Int32>, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<System.Collections.Generic.List<System.Int32>>>((act) =>
            {
                return new System.Comparison<System.Collections.Generic.List<System.Int32>>((x, y) =>
                {
                    return ((System.Func<System.Collections.Generic.List<System.Int32>, System.Collections.Generic.List<System.Int32>, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<System.Object>>((act) =>
            {
                return new System.Comparison<System.Object>((x, y) =>
                {
                    return ((System.Func<System.Object, System.Object, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Rect>>((act) =>
            {
                return new System.Predicate<UnityEngine.Rect>((obj) =>
                {
                    return ((System.Func<UnityEngine.Rect, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Rect>>((act) =>
            {
                return new System.Comparison<UnityEngine.Rect>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Rect, UnityEngine.Rect, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<System.Reflection.FieldInfo>>((act) =>
            {
                return new System.Predicate<System.Reflection.FieldInfo>((obj) =>
                {
                    return ((System.Func<System.Reflection.FieldInfo, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<System.Reflection.FieldInfo>>((act) =>
            {
                return new System.Comparison<System.Reflection.FieldInfo>((x, y) =>
                {
                    return ((System.Func<System.Reflection.FieldInfo, System.Reflection.FieldInfo, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<wxb.Nested.AnyBase>>((act) =>
            {
                return new System.Predicate<wxb.Nested.AnyBase>((obj) =>
                {
                    return ((System.Func<wxb.Nested.AnyBase, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<wxb.Nested.AnyBase>>((act) =>
            {
                return new System.Comparison<wxb.Nested.AnyBase>((x, y) =>
                {
                    return ((System.Func<wxb.Nested.AnyBase, wxb.Nested.AnyBase, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Object>>((act) =>
            {
                return new System.Predicate<UnityEngine.Object>((obj) =>
                {
                    return ((System.Func<UnityEngine.Object, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Object>>((act) =>
            {
                return new System.Comparison<UnityEngine.Object>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Object, UnityEngine.Object, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<System.Type>>((act) =>
            {
                return new System.Predicate<System.Type>((obj) =>
                {
                    return ((System.Func<System.Type, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<System.Type>>((act) =>
            {
                return new System.Comparison<System.Type>((x, y) =>
                {
                    return ((System.Func<System.Type, System.Type, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.EventSystems.RaycastResult>>((act) =>
            {
                return new System.Predicate<UnityEngine.EventSystems.RaycastResult>((obj) =>
                {
                    return ((System.Func<UnityEngine.EventSystems.RaycastResult, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.EventSystems.RaycastResult>>((act) =>
            {
                return new System.Comparison<UnityEngine.EventSystems.RaycastResult>((x, y) =>
                {
                    return ((System.Func<UnityEngine.EventSystems.RaycastResult, UnityEngine.EventSystems.RaycastResult, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.RectTransform.ReapplyDrivenProperties>((act) =>
            {
                return new UnityEngine.RectTransform.ReapplyDrivenProperties((driven) =>
                {
                    ((System.Action<UnityEngine.RectTransform>)act)(driven);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.UIVertex>>((act) =>
            {
                return new System.Predicate<UnityEngine.UIVertex>((obj) =>
                {
                    return ((System.Func<UnityEngine.UIVertex, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.UIVertex>>((act) =>
            {
                return new System.Comparison<UnityEngine.UIVertex>((x, y) =>
                {
                    return ((System.Func<UnityEngine.UIVertex, UnityEngine.UIVertex, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<System.Boolean>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<System.Boolean>((arg0) =>
                {
                    ((System.Action<System.Boolean>)act)(arg0);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.AnimatorClipInfo>>((act) =>
            {
                return new System.Predicate<UnityEngine.AnimatorClipInfo>((obj) =>
                {
                    return ((System.Func<UnityEngine.AnimatorClipInfo, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.AnimatorClipInfo>>((act) =>
            {
                return new System.Comparison<UnityEngine.AnimatorClipInfo>((x, y) =>
                {
                    return ((System.Func<UnityEngine.AnimatorClipInfo, UnityEngine.AnimatorClipInfo, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.UI.Selectable>>((act) =>
            {
                return new System.Predicate<UnityEngine.UI.Selectable>((obj) =>
                {
                    return ((System.Func<UnityEngine.UI.Selectable, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.UI.Selectable>>((act) =>
            {
                return new System.Comparison<UnityEngine.UI.Selectable>((x, y) =>
                {
                    return ((System.Func<UnityEngine.UI.Selectable, UnityEngine.UI.Selectable, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.UI.RectMask2D>>((act) =>
            {
                return new System.Predicate<UnityEngine.UI.RectMask2D>((obj) =>
                {
                    return ((System.Func<UnityEngine.UI.RectMask2D, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.UI.RectMask2D>>((act) =>
            {
                return new System.Comparison<UnityEngine.UI.RectMask2D>((x, y) =>
                {
                    return ((System.Func<UnityEngine.UI.RectMask2D, UnityEngine.UI.RectMask2D, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.UICharInfo>>((act) =>
            {
                return new System.Predicate<UnityEngine.UICharInfo>((obj) =>
                {
                    return ((System.Func<UnityEngine.UICharInfo, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.UICharInfo>>((act) =>
            {
                return new System.Comparison<UnityEngine.UICharInfo>((x, y) =>
                {
                    return ((System.Func<UnityEngine.UICharInfo, UnityEngine.UICharInfo, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.UILineInfo>>((act) =>
            {
                return new System.Predicate<UnityEngine.UILineInfo>((obj) =>
                {
                    return ((System.Func<UnityEngine.UILineInfo, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.UILineInfo>>((act) =>
            {
                return new System.Comparison<UnityEngine.UILineInfo>((x, y) =>
                {
                    return ((System.Func<UnityEngine.UILineInfo, UnityEngine.UILineInfo, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.UI.Dropdown.OptionData>>((act) =>
            {
                return new System.Predicate<UnityEngine.UI.Dropdown.OptionData>((obj) =>
                {
                    return ((System.Func<UnityEngine.UI.Dropdown.OptionData, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.UI.Dropdown.OptionData>>((act) =>
            {
                return new System.Comparison<UnityEngine.UI.Dropdown.OptionData>((x, y) =>
                {
                    return ((System.Func<UnityEngine.UI.Dropdown.OptionData, UnityEngine.UI.Dropdown.OptionData, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.Sprite>>((act) =>
            {
                return new System.Predicate<UnityEngine.Sprite>((obj) =>
                {
                    return ((System.Func<UnityEngine.Sprite, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.Sprite>>((act) =>
            {
                return new System.Comparison<UnityEngine.Sprite>((x, y) =>
                {
                    return ((System.Func<UnityEngine.Sprite, UnityEngine.Sprite, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.UI.InputField.OnValidateInput>((act) =>
            {
                return new UnityEngine.UI.InputField.OnValidateInput((text, charIndex, addedChar) =>
                {
                    return ((System.Func<System.String, System.Int32, System.Char, System.Char>)act)(text, charIndex, addedChar);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Predicate<UnityEngine.EventSystems.EventTrigger.Entry>>((act) =>
            {
                return new System.Predicate<UnityEngine.EventSystems.EventTrigger.Entry>((obj) =>
                {
                    return ((System.Func<UnityEngine.EventSystems.EventTrigger.Entry, System.Boolean>)act)(obj);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<System.Comparison<UnityEngine.EventSystems.EventTrigger.Entry>>((act) =>
            {
                return new System.Comparison<UnityEngine.EventSystems.EventTrigger.Entry>((x, y) =>
                {
                    return ((System.Func<UnityEngine.EventSystems.EventTrigger.Entry, UnityEngine.EventSystems.EventTrigger.Entry, System.Int32>)act)(x, y);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData>>((act) =>
            {
                return new UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData>((arg0) =>
                {
                    ((System.Action<UnityEngine.EventSystems.BaseEventData>)act)(arg0);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IDropHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });

            appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler>>((act) =>
            {
                return new UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler>((handler, eventData) =>
                {
                    ((System.Action<UnityEngine.EventSystems.ICancelHandler, UnityEngine.EventSystems.BaseEventData>)act)(handler, eventData);
                });
            });


        }

        static public void RegisterMethodDelegate(AppDomain appdomain)
        {
            appdomain.DelegateManager.RegisterMethodDelegate<System.IAsyncResult>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Object>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Threading.Tasks.Task>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Threading.Tasks.Task, System.Object>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Object, System.Threading.Tasks.UnobservedTaskExceptionEventArgs>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Threading.Tasks.Task[]>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Threading.Tasks.Task<System.Threading.Tasks.Task>>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Threading.Tasks.Task<System.Threading.Tasks.Task>, System.Object>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Threading.Tasks.Task<System.Int32>>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Threading.Tasks.Task<System.Int32>, System.Object>();
            appdomain.DelegateManager.RegisterMethodDelegate<ILRuntime.Runtime.Intepreter.ILTypeInstance>();
            appdomain.DelegateManager.RegisterMethodDelegate<ILRuntime.Runtime.Intepreter.ILTypeInstance, System.Boolean>();
            appdomain.DelegateManager.RegisterMethodDelegate<ILRuntime.CLR.TypeSystem.IType>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.String>();
            appdomain.DelegateManager.RegisterMethodDelegate<ILRuntime.CLR.Method.IMethod>();
            appdomain.DelegateManager.RegisterMethodDelegate<ILRuntime.CLR.Method.ILMethod>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Component>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.GameObject[]>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.GameObject>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Single>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Vector4>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Matrix4x4>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Camera.RenderRequest>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Rendering.AsyncGPUReadbackRequest>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Rendering.SphericalHarmonicsL2>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Int32>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Color>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Material>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Rendering.ReflectionProbeBlendInfo>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Vector3>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Color32>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Vector2>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Rendering.VertexAttributeDescriptor>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Mesh>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.UInt16>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Rendering.SubMeshDescriptor>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.BoneWeight>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Camera>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Collections.Generic.List<System.String>>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Collections.Generic.List<System.Int32>>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Font>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Rect>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Type>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, System.Int32>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, System.Boolean>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, System.Single[], System.Int32>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, UnityEngine.Collision>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, UnityEngine.Collision2D>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, UnityEngine.ControllerColliderHit>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, System.Single>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, UnityEngine.Joint2D>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, UnityEngine.GameObject>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, UnityEngine.RenderTexture, UnityEngine.RenderTexture>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, UnityEngine.Collider>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.BehaviourAction, UnityEngine.Collider2D>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Reflection.FieldInfo>();
            appdomain.DelegateManager.RegisterMethodDelegate<wxb.Nested.AnyBase>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Object>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.RaycastResult>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.RectTransform>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.UIVertex>();
            appdomain.DelegateManager.RegisterMethodDelegate<System.Boolean>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.AnimatorClipInfo>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.UI.Selectable>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.UI.RectMask2D>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.UICharInfo>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.UILineInfo>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.UI.Dropdown.OptionData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.Sprite>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.EventTrigger.Entry>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IDropHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.BaseEventData>();
            appdomain.DelegateManager.RegisterMethodDelegate<UnityEngine.EventSystems.ICancelHandler, UnityEngine.EventSystems.BaseEventData>();

        }

        static public void Fame()
        {
            System.Type v = null;
            v = typeof(System.Collections.Generic.List<UnityEngine.GameObject[]>);

            v = typeof(System.Collections.Generic.List<UnityEngine.GameObject>);

            v = typeof(System.Collections.Generic.List<System.String>);

            v = typeof(System.Collections.Generic.List<System.Collections.Generic.List<System.String>>);

            v = typeof(System.Collections.Generic.List<System.Int32>);

            v = typeof(System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>);

            v = typeof(System.Collections.Generic.List<System.String>.Enumerator);

            v = typeof(IL.RefOutParam<System.Int32>);

            v = typeof(System.Collections.Generic.List<System.Object>);


        }
    }
}
#endif