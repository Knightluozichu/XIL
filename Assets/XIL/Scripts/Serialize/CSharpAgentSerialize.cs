﻿using System.Reflection;
using System.Collections.Generic;
using UnityEditor;

namespace wxb
{
    public class CSharpAgentSerialize : ITypeSerialize
    {
        public CSharpAgentSerialize(System.Type type)
        {
            this.type = type;
        }

        System.Type type;

        byte ITypeSerialize.typeFlag { get { return TypeFlags.csharpAgentType; } } // 类型标识

        // 得到unity对象
        public static UnityEngine.Object GetUnityObject(System.Type type, object value)
        {
            if (value == null)
                return null;

            var field = IL.Help.GetField(type, "unity");
            if (field == null)
            {
                L.LogErrorFormat("CSharpAgent type:{0} {1} not find unity!", type.FullName, value.GetType().FullName);
                return null;
            }

            return field.GetValue(value) as UnityEngine.Object;
        }

        void ITypeSerialize.WriteTo(object value, IStream stream)
        {
            stream.WriteUnityObject(GetUnityObject(type, value));
        }

        public static object GetObject(UnityEngine.Object obj)
        {
            if (obj == null)
                return null;

            var property = IL.Help.GetProperty(obj.GetType(), "refType");
            if (property == null)
            {
                L.LogErrorFormat("CSharpAgent type:{0} not find refType!", obj.GetType().FullName);
                return null;
            }

            var refType = property.GetValue(obj) as RefType;
            if (refType == null)
            {
                L.LogError("refType == null");
                return null;
            }

            return refType.Instance;
        }

        FieldInfo unity_fieldInfo;
        void ITypeSerialize.MergeFrom(ref object parent, IStream stream)
        {
            var unity = stream.ReadUnityObject();
            SetObject(ref parent, unity);
        }

        public void SetObject(ref object parent, UnityEngine.Object unity)
        {
            if (parent == null)
                parent = IL.Help.CreateInstaince(type, null);

            if (unity_fieldInfo == null)
            {
                unity_fieldInfo = IL.Help.GetField(type, "unity");
                if (unity_fieldInfo == null)
                {
                    L.LogErrorFormat("type:{0} not find unity_fieldInfo", type.Name);
                    return;
                }
            }

#if UNITY_EDITOR
            unity = UnityObjectSerialize.To(unity, IL.Help.GetRealType(unity_fieldInfo.FieldType));
#endif
            try
            {
                unity_fieldInfo.SetValue(parent, unity);
            }
            catch (System.Exception ex)
            {
                L.LogException(ex);
            }
        }

        // 判断两个值是否相等
        bool ITypeSerialize.IsEquals(object x, object y)
        {
            return (UnityEngine.Object)x == (UnityEngine.Object)y;
        }

#if !CloseNested
        // 把值写入到ab当中
        void ITypeSerialize.WriteTo(object value, Nested.AnyBase ab)
        {
            ab.unityObj = GetUnityObject(type, value);
        }

        // 通过ab来设置值
        void ITypeSerialize.MergeFrom(ref object value, Nested.AnyBase ab)
        {
            SetObject(ref value, ab.unityObj);
        }
#endif
    }
}

