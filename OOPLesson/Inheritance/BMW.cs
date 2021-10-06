using System;
using OOPLesson.Inheritance.Enums;

namespace OOPLesson.Inheritance
{
    // BMW, Car'ın childıdır. Car'dan extend eder.
    // Car'ın sahip olduğu her yeteneğe sahiptir.
    public class BMW : DriftableCar
    {
        private int _wheelCount;

        public BMW(int gearCount, double x, double y, int wheelCount) : base(gearCount)
        {
            SetX(x);
            SetY(y);
            SetWheelCount(wheelCount);

            Initialise();

            // Bu tanım geçersizdir çünkü x ve y Car sınıfı içinde privatedır
            //_x = x;
            //_y = y;
        }

        public BMW()
        {
            Initialise();
        }

        private void Initialise()
        {
            FuelType = FuelType.Gas;
        }

        public void SetWheelCount(int wheelCount)
        {
            _wheelCount = wheelCount;
        }

        public int GetWheelCount()
        {
            return _wheelCount;
        }
    }
}
