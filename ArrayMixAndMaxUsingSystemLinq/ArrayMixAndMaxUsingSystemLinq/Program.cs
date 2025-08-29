using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMixAndMaxUsingSystemLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[]   number ={ 32,3,36,76,43};
            Console.WriteLine("smallest element="+number.Min());
            Console.ReadLine();

            Console.WriteLine("Largest element=" + number.Max());
            Console.ReadLine();

            Console.WriteLine("Sum of All Array=" + number.Sum());
            Console.ReadLine();

            Console.WriteLine("Sum of All Array=" + number.Average());
            Console.ReadLine();
            Console.WriteLine("Sum of All Array=" + number.Count());
            Console.ReadLine();


        }
    }
}
