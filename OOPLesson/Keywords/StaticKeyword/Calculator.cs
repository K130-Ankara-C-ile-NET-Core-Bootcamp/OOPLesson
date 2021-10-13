namespace OOPLesson.StaticKeyword
{
    public class Calculator
    {
        // Uygulama ayağa kalkerken ram üstünde tanımı yapılır 
        // Uygulamanın genelinde aynı tek değişken paylaşılarak kullanılır
        // Üstünde yapılan her değişiklik kendisini kullanan bağımsız instanceların her birini etkiler
        public static double Result = 0;

        public void Sum(double value)
        {
            Result += value;
        }

        public void Minus(double value)
        {
            Result -= value;
        }

        public double GetResult()
        {
            return Result;
        }
    }
}
