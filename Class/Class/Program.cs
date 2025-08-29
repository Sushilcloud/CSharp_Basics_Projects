using System;

namespace HelloWorld
{
    class Car
    {
        string color = "red";
        static void Main(string[] args)
        {
            // Single Object
            Car car = new Car();
            // Mutliple object
            Car car1 = new Car();
            Console.WriteLine(car.color);
            Console.WriteLine(car1.color);
        }
    }
}