using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Divide
    {
        public decimal DivideThese(decimal num1, decimal num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Nice try!");
                Program.Main();
                return 0;
            }
            else { return num1 / num2; }

        }
    }
}
