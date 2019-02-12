using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01___Calculator__Unit_test_
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Add({0} + {1}) = {2}", 10.00, 10.00, calculator.Add(10,10));
            Console.WriteLine("Subtract({0} - {1}) = {2}", 10.00, 10.00, calculator.Subtract(10,10));
            Console.WriteLine("Divide({0} / {1}) = {2}", 10.00, 2.00, calculator.Subtract(10, 2));
            Console.WriteLine("Multiply({0} * {1}) = {2}", 10.00, 10.00, calculator.Multiply(10,10));
            Console.WriteLine("Power({0} ^ {1}) = {2}", 10.00, 1.00, calculator.Power(10,1));

            Console.ReadKey();

            //Hej jeppe
        }
    }
}
