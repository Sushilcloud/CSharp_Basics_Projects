using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Enter Your Choice:\n 1-Doller to Rupees \n 2-Euro to Rupee \n 3-Malaysian Ringgit to Rupee");
            choice =int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("this is case 1");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("this is case 2");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("this is case3");
                    Console.ReadLine();
                    break;


            }
            
        }
    }
}
