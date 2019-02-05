using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator = L01___Calculator__Unit_test_.Calculator;

namespace Cal.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestCase(10,10,20)]
        [TestCase(20,20,40)]
        [TestCase(14,14,28)]
        [Test]
        public void Add_ReturnsRightAmount(double a, double b, double c)
        {
            Assert.That(calculator.Add(a,b), Is.EqualTo(c));
        }

        [TestCase(10, 10, 0)]
        [TestCase(20, 18, 2)]
        [TestCase(8, 10, -2)]
        [Test]
        public void Subtract_ReturnsRightAmount(double a, double b, double c)
        {
            Assert.That(calculator.Subtract(a, b), Is.EqualTo(c));
        }

        [TestCase(10, 2, 5)]
        [TestCase(20, 10, 2)]
        [TestCase(8, 3, 2.66)]
        [Test]
        public void Divide_ReturnsRightAmount(double a, double b, double c)
        {
            Assert.That(calculator.Divide(a, b), Is.EqualTo(c).Within(0.01));
        }

        [TestCase(10, 2, 20)]
        [TestCase(20, 3, 60)]
        [TestCase(8, 3, 24)]
        [Test]
        public void Multiply_ReturnsRightAmount(double a, double b, double c)
        {
            Assert.That(calculator.Multiply(a, b), Is.EqualTo(c));
        }

        [TestCase(10, 2, 100)]
        [TestCase(2, 3, 8)]
        [TestCase(8, 4, 4096)]
        [Test]
        public void Power_ReturnsRightAmount(double a, double b, double c)
        {
            Assert.That(calculator.Power(a, b), Is.EqualTo(c));
        }

        [Test]
        public void accumulation_2plus2_4()
        {
            calculator.Add(3, 4);
            calculator.Add(2, 2);

            Assert.That(calculator.Accumulator, Is.EqualTo(4));
        }
    }
}
