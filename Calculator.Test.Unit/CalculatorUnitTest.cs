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

        [Test]
        public void Add_ReturnsRightAmount()
        {
            Assert.That(calculator.Add(10,10), Is.EqualTo(20));
        }
        [Test]
        public void Subtract_ReturnsRightAmount()
        {
            Assert.That(calculator.Subtract(10, 10), Is.EqualTo(0));
        }
        [Test]
        public void Multiply_ReturnsRightAmount()
        {
            Assert.That(calculator.Multiply(10, 10), Is.EqualTo(100));
        }
        [Test]
        public void Power_ReturnsRightAmount()
        {
            Assert.That(calculator.Power(10, 2), Is.EqualTo(100));
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
