using System;
using Log.Interfaces;

namespace Log.Derived
{
    // İki nokta (:) 'dan sonra ilk gelen ifade parent class'ı sonrasındaki ifadeler ise interfaceleri belirtir
    // Bir class birden fazla interface implemente edebilir
    public class ConsoleLog : LogBase, ILog, IInterface
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
