using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class GraphingCalc : IEnumerable
    {
        List<string> NumSets;
        string newNumb;
        public void CalculateThis()
        {
            Console.WriteLine("What is your equation");
            string equation = Console.ReadLine();
            decimal number;
            string multiply = "*";
            string add = "+";
            NumSets = new List<string>();
            if (decimal.TryParse(equation, out number))
            {
                newNumb += number;
            }
            else/* if(equation == multiply)*/
            {
                
                Console.WriteLine("Enter a valid Number!! \n");
                CalculateThis();
            }
            NumSets.Add(newNumb);
            Console.WriteLine(newNumb);
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)NumSets).GetEnumerator();
        }
    }
}
