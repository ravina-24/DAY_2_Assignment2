using System;

namespace DAY_2_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SumOfTWoDice s = new SumOfTWoDice();
            s.AddDice();

            IntOpt i = new IntOpt();
            i.AddInput();
        }
    }
}
