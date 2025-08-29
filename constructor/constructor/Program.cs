using System;

namespace constructor
{
    class Car
    {

        public string model; //create a field

    // create a class constructor for the Car Class
    public Car()
    {
            model = "Mastang"; // set the initial value for model
    }

        static void Main(string[] args)
        {
            Car Ford = new Car(); // create an object for the car classs (this will call the constructor)
            Console.WriteLine(Ford.model);
        }
    }
}