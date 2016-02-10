using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Exponential
    {
        public double ExponentThese(decimal num1, decimal num2)
        {
            double first = Convert.ToDouble(num1);
            double second = Convert.ToDouble(num2);
            double set = Math.Pow(first, second);
            //Convert.ToDecimal(set);
            Console.WriteLine("Your answer is: " + set); 
            return set;
        }
    }
}
