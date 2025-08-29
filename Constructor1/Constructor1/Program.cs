using System;

namespace HelloWorld
{
    class Car
    {
        public string model;
        public string color;
        public int year;

        // create a class constructor with multiple parameter
        public Car(string modelName, string modelColor, int yearName)
        {
            model=modelName;
            color=modelColor;
            year=yearName;

        }

        static void Main(string[] args)
        {
        Car Ford = new Car("Mustang","Red",1987);
            Console.WriteLine(Ford.color+"  "+Ford.model+"  "+Ford.year);
        }
    }
}