namespace OOPLesson.AccessModifiers
{
    // Solution'ın içindeki tüm classlardan erişilebilir olacaktır
    // Access modifier belirtilmeyen classlar default olarak "internal" olacaktır
    public class PublicClass
    {
        // Property
        // Solution'ın içindeki tüm classlardan erişilebilir olacaktır
        public int PublicProperty { get; set; }

        // Field
        // Sadece PublicClasstan erişilebilir olacaktır
        private int _privateField;

        // Access modifier belirtilmeyen değişkenler default olarak "private" olacaktır
        // private int _privateField2 şeklinde compile edilecek
        int _privateField2;

        public void PublicMethod()
        {
            _privateField = 10; // Private fielda erişim
        }

        // Access modifier belirtilmeyen metodlar default olarak "private" olacaktır
        void PrivateMethod()
        {
            _privateField = 10; // Private fielda erişim
        }
    }
}
