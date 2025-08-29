using System;

namespace Inheritance
{

    class Vehicle  //base class parent
    {
        public string brand = "Ford";  //field
        public void honk()
        {
            Console.WriteLine("trut trut");
        }

    }

    class Car : Vehicle //derived class child
    {
        public string modelName = "Mustang";  //car filed
    }
    class Program
    {
        static void Main(string[] args)
        {
            // create a myCar Object
            Car myCar = new Car();

            //// Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();
            // // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand+"  "+myCar.modelName);
        }
    }
}