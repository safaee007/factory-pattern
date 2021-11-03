using System;

namespace factoryPatern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            CarFactory factory = new CarFactory();
            var car = factory.GetCar("B");

            car.StartCar();

        }
    }
}
