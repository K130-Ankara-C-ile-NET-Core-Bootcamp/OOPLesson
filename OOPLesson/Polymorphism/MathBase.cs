namespace OOPLesson.Polymorphism
{
    public class MathBase
    {
        protected double Result { get; set; }

        protected double Value1 { get; set; }

        protected double Value2 { get; set; }

        // Override edilebilir method
        // Overriding yöntemi
        public virtual double Calculate()
        {
            return Result;
        }

        // Override etmeyeceğiz dolayısıyla buradaki body çalışacak
        // Hem Minus hem de Sum için
        public virtual double Sum(params double[] values)
        {
            Result = 0;

            foreach (var value in values)
            {
                Result += value;
            }

            return Result;
        }

        // Overload yöntemi
        public void SetValue(double value1)
        {
            Value1 = value1;
        }

        // Overload yöntemi
        public void SetValue(double value1, double value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
    }
}
