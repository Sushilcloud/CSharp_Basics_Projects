using System;

namespace Conditional
{
    class IfStatement   
    {
        static void Main(string[] args)
        {
            int number = 2;
            if (number <= 5)
            {
                Console.WriteLine("{0} is less thean 5", number);
            }
            else
            {
                Console.WriteLine("more than 5");
            }
        }
    }
}