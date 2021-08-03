namespace wxb
{
    public interface ITypeSerialize
    {
        byte typeFlag { get; } // ���ͱ�ʶ
        void WriteTo(object value, IStream ms);
        void MergeFrom(ref object value, IStream ms);
        bool IsEquals(object x, object y); // �ж�����ֵ�Ƿ����

#if !CloseNested // �ر�Ԥ����Ƕ��֧��
        void WriteTo(object value, Nested.AnyBase ab); // ��ֵд�뵽ab����
        void MergeFrom(ref object value, Nested.AnyBase ab); // ͨ��ab������ֵ
#endif
    }
}