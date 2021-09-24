using System;

namespace DAY_2_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            

            SumOfTWoDice s = new SumOfTWoDice();
            s.AddDice();

            IntOpt i = new IntOpt();
            i.AddInput();

            DoubleOpt d = new DoubleOpt();
            d.CheckOperation();

            Distance distance = new Distance();
            distance.FindDistance();
        }
    }
}
