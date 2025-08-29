// See https://aka.ms/new-console-template for more information

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // while loop
            int p = 0;
            while (p < 5)
            {
                Console.WriteLine("P value is "+p);
                p++;
            }

            // for loop
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // foreach loop
            string[] cars = { "volvo", "bmw", "ford", "maruti" };
            foreach (string car in cars)
            {
                Console.Write(car);
            }

            Console.WriteLine("\n break statement \n");

            for(int i=0; i < 5; i++)
            {
                if(i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("\n Continue statement \n skip the value j 4 and then continue");
            
            for(int j=0; j < 10; j++)
            {

                if (j == 4)
                {
                    continue;
                }
                Console.WriteLine(j);
            }


            // Break and Continue statement on while loop

            Console.WriteLine("\n break and Continue statement in while loop");

            int d = 0;
            while(d<10)
            {
                Console.WriteLine(d);
                d++;
                if(d==5)
                {
                    break;
                }
            }

            Console.WriteLine("\n Continue statement in while loop");
            int s = 0;
            while(s<10)
            {
                              
                if(s==5)
                {
                    s++;
                    continue;
                   
                }
                Console.WriteLine(s);
                s++;
            }


        }
    }
}

