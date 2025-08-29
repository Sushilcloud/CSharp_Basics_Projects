using System;

namespace Abstraction
{

    //Abstract Class
    abstract class Animal
    {
        public abstract void animalsound(); //abstract method does not hava a body
        public void sleep()  //regular method
        {
            Console.WriteLine("Zzz");
        }

    }

    class Pig:Animal
    {
        public override void animalsound()
        {
            Console.WriteLine("the pig says : wee wee");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Pig pig = new Pig(); // create a Pig class object here
            pig.animalsound();  //Call the abstract method
            pig.sleep();        //Call the regular method

            Console.WriteLine("Hello World!");
        }
    }
}