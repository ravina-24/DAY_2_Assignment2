using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_2_Assignment2
{
    class IntOpt
    {

        public void AddInput()
        {
            int a, b, c;

            Console.WriteLine("Enter a= ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b = ");
            b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter c = ");
            c = Convert.ToInt32(Console.ReadLine());


            int input;
            Console.WriteLine("Enter input = 1.Operation1 \n" +
                "2.Opration2 \n" +
                "3.Operation3 \n" +
                "4.Operation4 \n");
            input = Convert.ToInt32(Console.ReadLine());

            switch(input)
            {
                case 1:

                    int op1 = a + b * c;
                    Console.WriteLine("Operation1 = " + op1);
                    break;

                case 2:
                    int op2 = a * b + c;
                    Console.WriteLine("Operation2 = " + op2);
                    break;

                case 3:
                    int op3 = c + a / b;
                    Console.WriteLine("Operation3 = " + op3);
                    break;

                case 4:

                    int op4 = a % b + c;
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
