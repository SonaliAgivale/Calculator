using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====calculator=====");
            ClsCalculator calc=new ClsCalculator();
            calc.addition(10, 13);
            Console.ReadKey();

        }
    }
}
