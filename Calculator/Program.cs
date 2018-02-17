using System;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            int a, b;
            string operand;
            float answer;
            Console.Write("a :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("add,sub,div,mul: ");
            operand = Console.ReadLine();
            Console.Write("b :");
            b = Convert.ToInt32(Console.ReadLine());
            switch (operand)
            {
                case "sub":
                    answer = a - b;
                    break;
                case "add":
                    answer = a + b;
                    break;
                case "div":
                    answer = a / b;
                    break;
                case "mul":
                    answer = a * b;
                    break;
                default:
                    answer = 0;
                    break;
            }
            Console.WriteLine(answer.ToString());
            Console.ReadLine();
        }
    }
}