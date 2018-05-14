using Newtonsoft.Json;
using System;
using Wine.Bottles;

namespace Wine
{
    class Program
    {
        static void Main(string[] args)
        {
            Container bottle = new Bottle(id: 1, name: "Claret", size: 75);

            

            bottle.Pour();
          
        }

        // c# is always pass by value
        static void DoWork(int number, Bottle bottle)
        {
            number = 10;
            bottle = new Bottle(2, "Grape", 75);   
        }
    }
}
