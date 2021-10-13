namespace OOPLesson.StructKeyword
{
    // Stackte tutuluyor, yani value type değişkenler
    // 16 byte olmalı maksimum
    // Boş constructor yazılamaz
    // Struct constructor içinde tüm parametreler set edilmelidir
    // Extend edilemez, implemente edilebilir
    public struct MyStruct : IMyInterface
    {
        public int Value { get; set; }

        public MyStruct(int value)
        {
            Value = value;
        }

        public void AddTen()
        {
            throw new System.NotImplementedException();
        }
    }

    public interface IMyInterface
    {
        public void AddTen();
    }
}
