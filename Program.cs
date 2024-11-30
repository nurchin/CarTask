using System;
using System.Runtime.ConstrainedExecution;

namespace CarTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("Mercedes","E200",Car.CarType.Sedan);
            Car car2 = new Car("Tesla","Cybertruck",Car.CarType.SUV);

            Console.WriteLine(car1);
            Console.WriteLine(car2);






        }








    }
}