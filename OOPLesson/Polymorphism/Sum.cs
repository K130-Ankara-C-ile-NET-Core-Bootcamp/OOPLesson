namespace OOPLesson.Polymorphism
{
    public class Sum : MathBase
    {
        // Overwritten method
        public override double Calculate()
        {
            Result = Value1 + Value2;

            return base.Calculate();
        }
    }
}
