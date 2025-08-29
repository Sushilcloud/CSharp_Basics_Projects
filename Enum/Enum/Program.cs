using System;

namespace Enum
{
    class Program
    {

        enum Level
        {
            Low,
            Medium,
            High
            
        }

        enum Month
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            Level level = Level.Low;
            Month month = Month.January;
            int myNum = (int)Month.April;

            Console.WriteLine(myNum);
        }
    }
}