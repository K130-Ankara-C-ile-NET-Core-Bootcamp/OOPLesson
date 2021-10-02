using System;

namespace OOPLesson.Encapsulation
{
    // Encapsulationda setter ve getter metodlar vardır
    // Set{fieldName} , Get{fieldName} şeklinde naming conventionı vardır
    public class EncapsulationClass
    {
        // Field tanımı
        private int _privateField;

        // Setter method
        // Value değerini kontrol et
        // Uygun değilse set etme
        // Uygun ise istenilen şekilde set et
        public void SetPrivateField(int value)
        {
            if (value < 1)
            {
                throw new Exception("Value 1'den küçük olamaz");
            }

            // Exception olduğu durumda bu satıra geçmeden program kapanacaktır
            _privateField = value;

            // Gelen değerin 1 fazlasına set edecek
            //_privateField = value + 1;
        }

        public int GetPrivateField()
        {
            return _privateField;
        }
    }
}
