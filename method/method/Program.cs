using System;

namespace HelloWorld
{
    class Program
    {

        static void mymethod()
        {
            Console.WriteLine("Hello this is method");
        }

        // parameter inside the method
        static void Name(string fname)
        {
            Console.WriteLine(fname + "Godiyal");
        }

        //multiple parameter inside the method

        static void multipleparameter(string sname, int age)
        {
            Console.WriteLine(sname + "is" + age);
        }

        // Return Value Method
        static int MyReturn(int x)
        {
            return 5 + x;

        }

        // Example sum of two parameter return value
        static int sumoftwo(int a, int b)
        {
            return a + b;
        }
        

        // exmaple multiple of two parameter return and stored in third variable
        static int multiple(int a,int b)
        {
            return a * b;
        }

        //Method Overloading
        //with method overloading multiple method can have the same name with different parameter

        static int PlusMethodInt(int x, int y)
        {
            return x + y;
        }
        static double PlusMethodDouble(double x,double y)
        {
            return x + y;
        }

        //
        static void plus()
        {
            Console.WriteLine("Enter first number:-");
            int firstnum=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number:-");
            int lastnum = Convert.ToInt32(Console.ReadLine());
                              
            Console.WriteLine(firstnum +lastnum);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            mymethod();
            plus();
            Name("Sushil");
            Name("Lokesh");
            Name("Rajeev");

            multipleparameter("sushil", 40);
            multipleparameter("Lokesh", 42);

            Console.WriteLine(MyReturn(1));

            Console.WriteLine("return sum of two value is"+sumoftwo(2,3));

            int x = multiple(4, 4);
            Console.WriteLine("Return multiply of two variable " + x);

            //Method overLoading
            int muNum1 = PlusMethodInt(8, 5);
            Console.WriteLine("int:" + muNum1);
            double myDouble1=PlusMethodDouble(8.2, 5.5);
            Console.WriteLine("Double:" + myDouble1);
        }

        //Return value



    }
    
}