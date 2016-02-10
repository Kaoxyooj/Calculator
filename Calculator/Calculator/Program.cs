using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        public static void Main(/*string[] args*/)
        {
            bool looper = true;
            while (looper == true)
            {
                UserInput ui = new UserInput();
                decimal first = ui.AskNumOne();
                decimal second = ui.AskNumTwo();
                string ask = ui.AskOperate();
                CalculateThis calc = new CalculateThis();
                calc.Calculate(ask, first, second);
                Console.ReadKey();
                Console.WriteLine("Do you want to calculate something else?  Press 2 to exit");
                string yesNo;
                yesNo = Console.ReadLine();
                if (yesNo == "2")
                {
                    looper = false;
                }

                //GraphingCalc graph = new GraphingCalc();
                //graph.CalculateThis();
                //Console.ReadLine();
            }
        }
    }
}

