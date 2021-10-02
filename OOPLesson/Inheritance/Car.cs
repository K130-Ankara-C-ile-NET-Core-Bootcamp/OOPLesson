using System;

namespace OOPLesson.Inheritance
{
    public class Car
    {
        private double _x, _y;
        private int _gearCount;

        // Constructor method
        // Return type alamaz
        // Bu classtan bir instance newlendiği anda ilk olarak ve otomatik olarak çağırılacak metoddur.
        public Car(int gearCount)
        {
            _gearCount = gearCount;
        }

        public void SetX(double x)
        {
            if (x < 0)
            {
                throw new Exception("X'e geçersiz değer verildi");
            }

            _x = x;
        }

        public double GetX()
        {
            return _x;
        }

        public void SetY(double y)
        {
            _y = y;
        }

        public double GetY()
        {
            return _y;
        }

        public void SetGearCount(int gearCount)
        {
            _gearCount = gearCount;
        }

        public int GetGearCount()
        {
            return _gearCount;
        }
    }
}
