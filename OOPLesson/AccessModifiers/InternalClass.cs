namespace OOPLesson.AccessModifiers
{
    // Default access modifier tanımı gereği bu class internaldır
    // compile edilirken şuna çevrilir -> internal class InternalClass
    class InternalClass 
    {
        public int PublicProperty { get; set; }

        // Sadece aynı library(proje) içinden erişilebilir
        internal int InternalProperty { get; set; }

        private int privateField;
    }
}
