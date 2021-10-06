using System;

namespace OOPLesson.Encapsulation
{
    // Encapsulationda setter ve getter metodlar vardır
    // Set{fieldName} , Get{fieldName} şeklinde naming conventionı vardır
    public class EncapsulationClass
    {
        // Property tanımı
        public int EncapsulatedProperty { get; set; }

        // Sadece EncapsulationClass içinde set edilebilir
        public int EncapsulatedPrivateSetProperty { get; private set; } = 30;

        // Readonly Property
        // Sadece tanım anında ve contructor içinde set edilebilir
        public int EncapsulatedReadonlyProperty { get; } = 30;

        // Body ile property tanımı 
        public int EncapsulatedPropertyWithBody
        {
            get // Public getter
            {
                return EncapsulatedPropertyWithBody;
            }
            private set
            {
                // Set edilen değer value keywordü ile gelir
                if (value < 1)
                {
                    return;
                }

                EncapsulatedPropertyWithBody = value;
            }
        }

        public EncapsulationClass()
        {
            EncapsulatedReadonlyProperty = 20;
        }

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

        public void SetEncapsulatedPrivateSetProperty()
        {
            EncapsulatedPrivateSetProperty = 10;
        }

        public void SetEncapsulatedReadonlyProperty()
        {
            //EncapsulatedReadonlyProperty = 10;
        }
    }
}
