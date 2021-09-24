using System;

namespace DAY_2_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
          

                int input;
                Console.WriteLine("Enter input \n" +
                    "1.AddTwoDiceRoll\n" +
                    "2.OperationOfThreeInputs\n" +
                    "3.OperationOfthreeDoubleinputs\n" +
                    "4.Find distance\n" );

                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        SumOfTWoDice s = new SumOfTWoDice();
                        s.AddDice();
                        break;

                    case 2:
                        IntOpt i = new IntOpt();
                        i.AddInput();
                        break;

                    case 3:
                        DoubleOpt d = new DoubleOpt();
                        d.CheckOperation();
                        break;

                    case 4:
                        Distance distance = new Distance();
                        distance.FindDistance();
                        break;

                    
                    default:
                        Console.WriteLine(" Invalid input ");
                        break;
                }
           

        }
    }
}
