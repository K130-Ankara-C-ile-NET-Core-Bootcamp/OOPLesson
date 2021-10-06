using System;
using Log.Derived;
using Log.Interfaces;

namespace Log
{
    class Program
    {
        static void Main(string[] args)
        {
            ILog logger = new FileLog();
            logger.Log("log mesajı");
        }
    }
}
