namespace OOPLesson.StaticKeyword
{
    // Static classlar extend edilemiyorlar
    // Statik classler otomatik olarak sealed classtir
    public static class StaticClass
    {
        // Static methodlar class'ının instance'ı olmadan çalışabilir
        public static void StaticMethod()
        {

        }

        // Virtual, abstract, override keywordleri statik methodda geçersizdir
        public static virtual void StaticMethod2()
        {

        }

        // Static classdan instance türetilemeyeceği için statik olmayan bir metot barındıramaz
        public void NonStaticMethod()
        {

        }
    }

    public class NonStaticClass : StaticClass
    {
        // Class static olmasa bile, static field, method, property vs barındırabilir
        public static void StaticMethod()
        {

        }
    }
}
