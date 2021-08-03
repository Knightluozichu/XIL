namespace wxb
{
    class UnityObjectSerialize : ITypeSerialize
    {
        byte ITypeSerialize.typeFlag { get { return TypeFlags.unityObjectType; } } // ���ͱ�ʶ

        void ITypeSerialize.WriteTo(object value, IStream stream)
        {
            stream.WriteUnityObject((UnityEngine.Object)value);
        }

        void ITypeSerialize.MergeFrom(ref object parent, IStream stream)
        {
            parent = stream.ReadUnityObject();
        }

        // �ж�����ֵ�Ƿ����
        bool ITypeSerialize.IsEquals(object x, object y)
        {
            return (UnityEngine.Object)x == (UnityEngine.Object)y;
        }

        // ����ת��
        public static UnityEngine.Object To(UnityEngine.Object src, System.Type type)
        {
            if (ReferenceEquals(src, null))
                return null;

#if USE_HOT
            if (type is ILRuntime.Reflection.ILRuntimeWrapperType)
                type = ((ILRuntime.Reflection.ILRuntimeWrapperType)type).RealType;
#endif
            var srcType = src.GetType();
            if (srcType == type)
                return src;

            if (type.IsAssignableFrom(srcType))
                return src; // src : type

            //if (typeof(UnityEngine.Component).IsAssignableFrom(type))
            //{
            //    if (src is UnityEngine.Component)
            //        return ((UnityEngine.Component)src).GetComponent(type);
            //    else if (src is UnityEngine.GameObject)
            //        return ((UnityEngine.GameObject)src).GetComponent(type);
            //}
            //else if (type == typeof(UnityEngine.GameObject))
            //{
            //    if (src is UnityEngine.Component)
            //        return ((UnityEngine.Component)src).gameObject;
            //}

            return null;
        }

#if !CloseNested
        // ��ֵд�뵽ab����
        void ITypeSerialize.WriteTo(object value, Nested.AnyBase ab)
        {
            ab.unityObj = value as UnityEngine.Object;
        }

        // ͨ��ab������ֵ
        void ITypeSerialize.MergeFrom(ref object value, Nested.AnyBase ab)
        {
            value = ab.unityObj;
        }
#endif
    }
}