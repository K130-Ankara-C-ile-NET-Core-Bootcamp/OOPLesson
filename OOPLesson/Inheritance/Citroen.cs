using System;
using OOPLesson.Inheritance.Enums;

namespace OOPLesson.Inheritance
{
    public class Citroen : Car
    {

        public Citroen(int gearCount) : base(gearCount)
        {
            FuelType = FuelType.Disel;

            // String değeri yazdır
            Console.WriteLine(FuelType.ToString());

            // Int değeri yazdır
            Console.WriteLine(FuelType.ToString("D"));
        }
    }
}
