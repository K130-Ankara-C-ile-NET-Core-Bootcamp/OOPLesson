namespace OOPLesson.Inheritance
{
    public class DriftableCar : Car
    {
        public DriftableCar(int gearCount) : base(gearCount)
        {

        }

        public DriftableCar() : base(5)
        {

        }

        public void DoDrift()
        {
            // Drift yapan kod
        }
    }
}
