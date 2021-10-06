using OOPLesson.Inheritance;
using OOPLesson.Inheritance.Enums;

namespace OOPLessonLibrary.Inheritance
{
    public class Mercedes : Car
    {
        public Mercedes(int gearCount) : base(gearCount)
        {
            FuelType = FuelType.Gas;

            // Protected olduğu için erişebilir 
            InternalProtectedProperty = 10;
        }
    }
}
