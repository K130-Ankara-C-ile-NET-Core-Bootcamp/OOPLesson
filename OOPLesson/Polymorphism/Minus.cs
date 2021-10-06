namespace OOPLesson.Polymorphism
{
    public class Minus : MathBase
    {
        // Overwritten method
        public override double Calculate()
        {
            Result = Value1 - Value2;

            return base.Calculate();
        }

        // Virtual method olmadığı için override edilemiyor
        //public override void SetValue(double value1)
        //{
            
        //}
    }
}
