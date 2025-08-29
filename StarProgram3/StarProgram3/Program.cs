
using System;

namespace StarProgram3

{
    class StarPattern3
    {
        static void Main(string[] args)
        {
            int numOfColumn, numOfRow;
            Console.WriteLine("Enter Column Number");
            numOfColumn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Row Numbers");
            numOfRow = Convert.ToInt32(Console.ReadLine());
            for (int row = 1; row <= numOfRow; row++)   //number of row decide here
            {
                for (int col = 1; col <= numOfColumn; col++)  // number of column decide here
                {
                    if (col >= row)
                    {
                        Console.Write("*");
                        //Console.WriteLine();
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }


    }
}