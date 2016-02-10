using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    public class UserInput
    {
        decimal num1;
        decimal num2;


        public decimal AskNumOne()
        {
            Console.WriteLine("What is your first number?");
            if (decimal.TryParse(Console.ReadLine(), out num1))
            {
            }
            else
            {
                Console.WriteLine("Enter a valid Number!! \n");
                AskNumOne();
            }
            return num1;
        }
        public decimal AskNumTwo()
        {
            Console.WriteLine("What is your second number?");
            if (decimal.TryParse(Console.ReadLine(), out num2))
            {
            }
            else
            {
                Console.WriteLine("Enter a valid Number!! \n");
                AskNumTwo();
            }
            return num2;
        }
        public string AskOperate()
        {
            Console.WriteLine("1 for {0}, 2 for {1}, 3 for {2}, 4 for {3}, 5 for {4}", decide.Add, decide.Subtract, decide.Multiply, decide.Divide, decide.Exponent);
            string calc = Console.ReadLine();
            return calc;
        }

    }
}
