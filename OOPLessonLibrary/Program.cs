using OOPLesson.AccessModifiers;

namespace OOPLessonLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void PublicClassDefinitions()
        {
            var internalClass = new PublicClass();

            // Public olduğundan erişilebilir
            internalClass.PublicProperty = 10;

        }

        public static void InternalClassDefinitions()
        {
            // Internal class olduğu için sadece aynı kütüphane üstünden erişilir
            // Erişim hatası verir
            //var internalClass = new InternalClass();

            // Erişim hatası verir
            //internalClass.PublicProperty = 10;
            //internalClass.InternalProperty = 10;
        }
    }
}
