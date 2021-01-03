using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_intetface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******** Calculator******");
            Console.WriteLine();
            Console.WriteLine("**** BASIC CALCULATOR INTERFACE******" );
            
            Console.WriteLine();
            BasicCalc b = new BasicCalc();
            Console.WriteLine("**SUMMATION FUNCTION RESULT****");

            b.sum(11, 5);
            b.printStates();
            Console.WriteLine();
            Console.WriteLine("**SUBTRACTION FUNCTION RESULT**");
            Console.WriteLine();
            b.sub(9, 7);
            b.printStates();
            Console.WriteLine();
            Console.WriteLine("***MULTIPLICATION FUNCTION RESULT****");
            Console.WriteLine();
            b.multiplication(11, 9);
            b.printStates();
            Console.WriteLine();
            Console.WriteLine("***DIVISION FUNCTION RESULT*****");
            Console.WriteLine();
            b.division(15, 5);
            b.printStates();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***SCIENTIFIC CALCULATOR INTERFACE*****");
            Console.WriteLine();
            SciCal s = new SciCal();
            Console.WriteLine();
            Console.WriteLine("**DIVISION FUNCTION RESULT***");
            Console.WriteLine();
            s.division(11, 5);
            b.printStates();
            Console.WriteLine("**FACTORIAL FUNCTION RESULT***");
            Console.WriteLine();
            s.factorial(5);
            Console.WriteLine();
            Console.WriteLine("**X to Y FUNCTION RESULT***");
            Console.WriteLine();
            s.XtoY(200, 800);










        }
    }
}
