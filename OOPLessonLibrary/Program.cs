using OOPLesson.AccessModifiers;
using OOPLessonLibrary.Inheritance;

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

            var mercedes = new Mercedes(1);

            // Internal olduğu için erişilemez
            // mercedes.InternalProtectedProperty = 20;
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
