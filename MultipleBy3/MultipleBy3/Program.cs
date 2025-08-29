using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleBy3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a,c,b,sum=0,i,total;
            Console.WriteLine("Enter any Number ");
            c=Convert.ToInt32(Console.ReadLine());

            for(i=1;i<=100;i++)
            {
                
                b = i % c;
                if (b == 0)
                {
                    //Console.Write(+i);
                    //Console.ReadLine();

                    sum =  sum+ i;
                   
                   

                }

                
            }

            Console.WriteLine("Multiple of number" + sum);
            Console.ReadLine();
        }
    }
}
