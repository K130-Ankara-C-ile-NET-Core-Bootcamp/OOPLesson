using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using OOPLesson.Abstraction;
using OOPLesson.Encapsulation;
using OOPLesson.Inheritance;
using OOPLesson.Polymorphism;
using OOPLesson.StaticKeyword;
// Named using directive
using Modifiers = OOPLesson.AccessModifiers;

namespace OOPLesson
{
    // Access Modifier (erişim belirteci) Listesi
    // private
    // protected
    // internal
    // public
    // protected internal

    // Static instance bağımsız uygulama genelinde tek sefer yaratılan ve tüm threadler tarafından paylaşılan varlıklardır
    class Program
    {
        // Propertyler her zaman büyük harfle başlar (pascalcase)
        public int PropertyNamingExample { get; set; }

        // Class için field isimlendirme kuralı
        private int _memberNamingExample;

        // Method isimleri her zaman pascalcase ile yazılır
        static void Main(string[] args)
        {
            // Metod için değişken isimlendirme kuralı
            var camelCaseExample = 10;

            StaticExample();
        }

        public static void PublicClassDefinitions()
        {
            // PublicClass'a erişebildik
            Modifiers.PublicClass publicClass =
                new Modifiers.PublicClass();

            // Basit tanımlama
            var publicClassVar = new Modifiers.PublicClass();

            // Daha basit tanımla
            Modifiers.PublicClass publicClassNew =
                new();

            // Erişilebilir
            publicClass.PublicProperty = 0;
            publicClass.PublicMethod();

            // Erişim hatası (inaccessible)
            //publicClass._privateField = 0;
            //publicClass.PrivateMethod();
        }

        public static void InternalClassDefinitions()
        {
            OOPLesson.AccessModifiers.InternalClass internalClass =
                new OOPLesson.AccessModifiers.InternalClass();

            // Aynı dll içinde olduğundan ikisi de erişilebilir
            internalClass.PublicProperty = 10;
            internalClass.InternalProperty = 10;

            // Private sadece tanımlandığı class içinden erişilebilir olacak
            //internalClass.privateField = 10;
        }

        public static void EncapsulationExample()
        {
            EncapsulationClass instance = new EncapsulationClass();

            // Setter çağrısı
            instance.SetPrivateField(55);

            // Getter çağrısı
            instance.GetPrivateField();

            // Private setter inaccessible
            instance.EncapsulatedProperty = 10;

            var getValue = instance.EncapsulatedPropertyWithBody;
            //instance.EncapsulatedPropertyWithBody = 20;
        }

        public static void InheritanceExample()
        {
            BMW bmw = new BMW(
                gearCount: 6,
                x: 100,
                y: 120,
                wheelCount: 4);

            bmw.GetGearCount();
            bmw.DoDrift();
            bmw.GetWheelCount();

            // Protected variable cannot be reached here
            //bmw.FuelType = 10;

            Citroen citroen = new Citroen(4);
            citroen.SetGearCount(5);
            citroen.GetGearCount();

            // Citroen DriftableCar'dan türemediği için bu özelliğe sahip değil
            //citroen.DoDrift();

            // Herhangi bir araba 0'dan küçük X'e sahip olamaz, bu kod hata fırlatacaktır
            //citroen.SetX(-1);

            DriftableCar driftCar = new DriftableCar(7);

            // GetWheelCount BMW model arabaya özgü bir özelliktir
            //driftCar.GetWheelCount();

            // Empty constructor BMW ve DriftableCar yarat (Default olarak 5 vites gelecektir)
            BMW bmwDefaultConstructor = new BMW();
            DriftableCar driftDefault = new DriftableCar();

            Car bmwBase = new BMW();

            // Car SetWheelCount içermediği için Car tipinde yaratılan BMW objesi üstünden çağrılamaz
            //bmwBase.SetWheelCount();

            var bmwInstance = (BMW)bmwBase;
            bmwInstance.SetWheelCount(6);

            List<Car> cars = new List<Car>
            {
                new BMW(),
                new BMW(),
                new Citroen(1),
            };

            // Cast hatası alırız. Çünkü 3. eleman olan Citroen BMW'ye çevrilemez
            // Yalnızca aynı özelliklere birebir sahip olan farklı classlar birbirine cast edilebilir
            // Bir base class tipindeki obje child class tipine cast edilebilir
            //foreach (BMW car in cars)
            //{
            //    car.SetWheelCount(10);
            //}

            foreach (Car car in cars)
            {
                SetCarProperties(car);
            }
        }

        public static void SetCarProperties(Car car)
        {
            car.SetX(15);
            car.SetY(20);
            car.SetGearCount(5);

            // Car tipindeki obje aslında bir BMW class'ına ait ise if'e düşer
            if (car is BMW)
            {
                ((BMW)car).SetWheelCount(4);
            }
        }

        public static void PolymorphismExample()
        {
            var sum = new Sum();

            // First overload
            sum.SetValue(20);

            // Second overload
            sum.SetValue(20, 10);

            Console.WriteLine(sum.Calculate());

            var minus = new Minus();
            minus.SetValue(20);
            minus.SetValue(20, 10);
            Console.WriteLine(minus.Calculate());

            var sumResult = minus.Sum(5, 10, 15, 5);
            Console.WriteLine(sumResult);
        }

        public static void AbstractionExample()
        {
            var rectangle = new Rectangle("FutbolSahası");
            rectangle.Draw();
            Console.WriteLine(rectangle.GetName());

            var circle = new Circle("Top");
            circle.Draw();
            Console.WriteLine(circle.GetName());

            // Abstract class instance'a sahip olamaz
            //var shape = new Shape("shape");
        }

        public static void StaticExample()
        {
            // Runtime sırasında newlendiği için set edebiliyoruz
            // Static değişkenlere erişmek için instance.variable yerine class.variable kullanıyoruz
            Calculator.Result = 55;

            var calculator1 = new Calculator();
            calculator1.Sum(10);
            calculator1.Minus(4);

            var calculator2 = new Calculator();
            calculator2.Sum(6);
            calculator2.Minus(7);

            Console.WriteLine(calculator1.GetResult());
            Console.WriteLine(calculator2.GetResult());
            Console.WriteLine(Calculator.Result);

            // Static classlardan instance türetilemez
            var staticClass = new StaticClass();
        }
    }
}
