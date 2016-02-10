using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    enum decide
    {
        Add,
        Subtract,
        Multiply,
        Divide,
        Exponent,
    }
    public class CalculateThis
    {
        decimal answer;
        public decimal Calculate(string calculate, decimal num1, decimal num2)
        {
            //int first = Convert.ToInt32(num1);
            //int second = Convert.ToInt32(num2);

            switch (calculate)
            {
                case "1":
                    Addition addition = new Addition();
                    answer = addition.AddThese(num1, num2);
                    Console.WriteLine("Your answer is: " + answer);
                    break;
                case "2":
                    Subtraction subtraction = new Subtraction();
                    answer = subtraction.SubtractThese(num1, num2);
                    Console.WriteLine("Your answer is: " + answer);
                    break;
                case "3":
                    Multiply multiply = new Multiply();
                    answer = multiply.MultiplyThese(num1, num2);
                    Console.WriteLine("Your answer is: " + answer);
                    break;
                case "4":
                    Divide divide = new Divide();
                    answer = divide.DivideThese(num1, num2);
                    Console.WriteLine("Your answer is: " + answer);
                    break;
                case "5":
                    Exponential exponential = new Exponential();
                    exponential.ExponentThese(num1, num2);
                    break;
                default:
                    Console.WriteLine("Not a valid choice!");
                    break;
            }
            return answer;
        }
    }
}
