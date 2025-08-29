// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is my First C# Project");
            Console.WriteLine(2 + 1);       
           // Console.WriteLine(if 2 > 1) ;
           // return;

            // variable in C#
            int a=1;
            double b = 2.2;
            char c = 'a';
            String s = "Sushil";
            bool t=true;

            Console.WriteLine("First Method to call Variable");
            //First Method to write
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(s);
            Console.WriteLine(t);
            Console.WriteLine("");

            Console.WriteLine("Second Method to call Variables");
           
            // Second Method with ref
            Console.WriteLine($"Example of Int={a}");
            Console.WriteLine($"Example of Double={b}");
            Console.WriteLine($"Example of Char={c}");
            Console.WriteLine($"Example of String={s}");
            Console.WriteLine($"Example of bool={t}");
            Console.WriteLine("");

            Console.WriteLine("Third Method to call Variables");

            // Third Method
            Console.WriteLine("int" + a);
            Console.WriteLine("double" + b);
            Console.WriteLine("char" + c);
            Console.WriteLine("string" + s);
            Console.WriteLine("bool" + t);
            Console.WriteLine("");

            Console.WriteLine("Another way to write");
            String firstname = "sushil";
            String lastname = "Godiyal";
            String fullname=firstname + lastname;
            Console.WriteLine(firstname);
            Console.WriteLine(lastname);
            Console.WriteLine(fullname);
            Console.WriteLine("");

            Console.WriteLine("convert method");
            int myInt = 10;
            Console.WriteLine(Convert.ToString(myInt));

            Console.WriteLine("");
            Console.WriteLine("Type Casting");

            //Type casting is when you assign a value of one data type to another type.

            int myInt1 = 9;
            double myDouble = myInt1;
            Console.WriteLine(myInt1);
            Console.WriteLine(myDouble);

            double myDouble1 = 9.78;
            int myInt2 = (int)myDouble;
            Console.WriteLine(myDouble1);
            Console.WriteLine(myInt2);


            // User Input 
            Console.WriteLine("");
            Console.WriteLine("user Input");
            Console.WriteLine("Enter Username");
            string username=Console.ReadLine();
            Console.WriteLine("user name is"+username);

            //user input as number
            Console.WriteLine("Enter your age");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your age is " + age);

            //Math
            Console.WriteLine("Max number is ="+Math.Max(5, 2));

            // Length of String
            string txt="fjdjfdlfjalsdjfajoijfoijojas";
            Console.WriteLine(" The Length of string is " + txt.Length);
            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());


            //string concatenation

            string fname = "lokesh";
            string lname = "godiyal";
            string nameof = fname + lname;
            Console.WriteLine("full name is" + nameof);


            string fname1 = "john";
            string lname2 = "doe";
            string name3 = string.Concat(fname1, lname2);
            Console.WriteLine(name3);


            // Access string

            string mystring = "hello";
            Console.WriteLine(mystring[0]); //output is h

            // index of
            Console.WriteLine(mystring.IndexOf("o"));




        }
    }
}