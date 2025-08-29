using System;

namespace Interface
{
    interface IAnimal
    {
        void AnimalSound(); //interface method does not have body
    }

    // Pig "implements" the IANimal interface
    class Pig:IAnimal
    {
        public void AnimalSound()  //method
        {
            // the body of animal sound provided here
            Console.WriteLine("The Pig says : wee wee");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Pig pig = new Pig();
            pig.AnimalSound();
            Console.WriteLine("Hello World!");
        }
    }
}