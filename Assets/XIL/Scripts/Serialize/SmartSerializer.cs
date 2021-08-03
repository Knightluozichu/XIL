namespace wxb
{
    public class SmartSerializer : ITypeSerialize
    {
        public SmartSerializer(System.Type baseType, ITypeSerialize baseTypeSerialize)
        {
            this.baseType = baseType;
            this.baseTypeSerialize = baseTypeSerialize;
        }

        System.Type baseType;
        ITypeSerialize baseTypeSerialize;
        byte ITypeSerialize.typeFlag { get { return TypeFlags.smartType; } } // ���ͱ�ʶ

        void ITypeSerialize.WriteTo(object value, IStream ms)
        {
            if (value == null)
            {
                ms.WriteString(string.Empty);
                return;
            }

            var type = IL.Help.GetInstanceType(value);
            var serial = type == baseType ? baseTypeSerialize : BinarySerializable.GetByType(type);
            ms.WriteString(type.FullName);
            serial.WriteTo(value, ms);
        }

        void ITypeSerialize.MergeFrom(ref object value, IStream ms)
        {
            string fullName = ms.ReadString();
            if (string.IsNullOrEmpty(fullName))
                return;

            System.Type type;
            if (value == null || ((type = IL.Help.GetInstanceType(value)).FullName != fullName))
            {
                if (IL.Help.TryGetTypeByFullName(fullName, out type))
                    value = IL.Help.Create(type);
            }

            var serial = type == baseType ? baseTypeSerialize : BinarySerializable.GetByType(type);
            serial.MergeFrom(ref value, ms);
        }

        // �ж�����ֵ�Ƿ����
        bool ITypeSerialize.IsEquals(object x, object y)
        {
            System.Type xType = IL.Help.GetInstanceType(x);
            System.Type yType = IL.Help.GetInstanceType(y);

            if (xType != yType)
                return false;

            if (xType == baseType)
                return baseTypeSerialize.IsEquals(x, y);

            return BinarySerializable.IsEquip(x, y);
        }

#if !CloseNested
        // ��ֵд�뵽ab����
        void ITypeSerialize.WriteTo(object value, Nested.AnyBase ab)
        {
            if (value == null)
            {
                ab.typeName = string.Empty;
                return;
            }

            var type = IL.Help.GetInstanceType(value);
            var serial = type == baseType ? baseTypeSerialize : BinarySerializable.GetByType(type);
            ab.typeName = type.FullName;
            serial.WriteTo(value, ab);
        }

        // ͨ��ab������ֵ
        void ITypeSerialize.MergeFrom(ref object value, Nested.AnyBase ab)
        {
            string fullName = ab.typeName;
            if (string.IsNullOrEmpty(fullName))
                return;

            System.Type type;
            if (value == null || ((type = IL.Help.GetInstanceType(value)).FullName != fullName))
            {
                if (IL.Help.TryGetTypeByFullName(fullName, out type))
                    value = IL.Help.Create(type);
            }

            var serial = type == baseType ? baseTypeSerialize : BinarySerializable.GetByType(type);
            serial.MergeFrom(ref value, ab);
        }
#endif
    }
}