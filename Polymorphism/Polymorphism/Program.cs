using System;

namespace HelloWorld
{

    class Animal  //base Class Parent
    {
        public void animalsound()  //method
        {
            Console.WriteLine("the animal makes a sound");
        }
    }

    class pig:Animal //Derived Class (child)
    {
        public void animalsound()
        {
            Console.WriteLine("The Pig Says:wee wee");
        }
    }
    class dog : Animal //Derived Class (child)
    {
        public void animalsound()
        {
            Console.WriteLine("The Dog Says: bhaw bhaw");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Animal myAnimal=new Animal();   // create a class Animal Object
            pig myPig=new pig();            // create a class pig object
            dog mydog=new dog();            // create a class dog object


            myAnimal.animalsound();
            myPig.animalsound();
            mydog.animalsound();
                
           
        }
    }
}