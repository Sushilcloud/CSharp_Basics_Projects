// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Loop");
            Console.WriteLine("First Program");

            Console.WriteLine("Loop First Method");
            if (20 > 10)
            {
                Console.WriteLine("20 is greater than 10");
            }
            else
            {
                Console.WriteLine("20 IS LESS THAN 10");
            }

            //Second Program as input method

            Console.WriteLine("Enter First Numer" );
            int fnumber=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int snumber=Convert.ToInt32(Console.ReadLine());
            if(fnumber>snumber)
            {
                Console.WriteLine("First number is greater then second");
            }
            else
            {
                Console.WriteLine("Second is greater than first");
            }

            // Short method to write
            int time = 20;
            string result = (time < 18) ? "good day" : "good ever";
            Console.WriteLine(result);


            // switch statement

            Console.WriteLine("Enter day");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 0: Console.WriteLine("Monday"); break;
                case 1: Console.WriteLine("Tuesday"); break;
                case 2: Console.WriteLine("wednesday"); break;
                case 3: Console.WriteLine("Thursday"); break;
                case 4: Console.WriteLine("Friday"); break;
                case 5: Console.WriteLine("Saturday"); break;
                case 6: Console.WriteLine("Sunday"); break;
                default: Console.WriteLine("looking forward to weekend");break;
           

            }




        }
    }
}