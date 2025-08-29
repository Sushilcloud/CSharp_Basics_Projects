using System;

namespace EnumWithSwitch
{
    class Program
    {
        enum Level
        {
            Low,
            Medium,
            High

        }

        static void Main(string[] args)
        {
            Level level = Level.Low;
            switch (level)
            {
                case Level.Low:
                    Console.WriteLine("Low level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium Level");
                    break;
                case Level.High:
                    Console.WriteLine("Hight Level");
                    break;

            }
            Console.WriteLine("Hello World!");
        }
    }
}