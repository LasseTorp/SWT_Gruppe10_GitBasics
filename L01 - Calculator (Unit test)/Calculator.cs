using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace L01___Calculator__Unit_test_
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            Accumulator = (a + b);
            return a + b;

        }

        public double Subtract(double a, double b)
        {
            Accumulator = (a - b);
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = (a * b);
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b != 0)
            {
                Accumulator = (a / b);
                return a / b;
            }
            else
            {
                throw new DivideByZeroException();
            }
        }


        public double Power(double x, double exp)
        {
            Accumulator = (Math.Pow(x, exp));
            return Math.Pow(x, exp);
        }

        public double Accumulator { get; private set; }
    }
}
