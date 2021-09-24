using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_2_Assignment2
{
    class DoubleOpt
    {
        public void CheckOperation()
        {
            double a, b, c;

            Console.WriteLine("Enter a= ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter b = ");
            b = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter c = ");
            c = Convert.ToDouble(Console.ReadLine());


            double input;
            Console.WriteLine("Enter input = 1.Operation1 \n" +
                "2.Opration2 \n" +
                "3.Operation3 \n" +
                "4.Operation4 \n");
            input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:

                    double op1 = a + b * c;
                    Console.WriteLine("Operation1 = " + op1);
                    break;

                case 2:
                    double op2 = a * b + c;
                    Console.WriteLine("Operation2 = " + op2);
                    break;

                case 3:
                    double op3 = c + a / b;
                    Console.WriteLine("Operation3 = " + op3);
                    break;

                case 4:

                    double op4 = a % b + c;
                    Console.WriteLine("Operation4 = " + op4);
                    break;

                default:
                    Console.WriteLine("Enter proper input ");
                    break;

            }
            Console.ReadLine();



        }
    }
}

