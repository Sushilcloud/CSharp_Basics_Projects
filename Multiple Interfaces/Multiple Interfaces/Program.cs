using System;

namespace MultipleInterface
{

    interface myFirstInterface
        {
        void myMethod();  //interface method
        }

    interface mySecondInterface
    {
        void mySecondMethod(); //interface method its does not have body part
    }

    class DemoClass : myFirstInterface, mySecondInterface  //implement multiple interface
    {
        public void myMethod()
        {
            Console.WriteLine("My First Interface");
        }

        public void mySecondMethod()
        {
            Console.WriteLine("My Second Interface");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DemoClass demo = new DemoClass();
            demo.myMethod();
            demo.mySecondMethod();
            Console.WriteLine("Hello World!");
        }
    }
}