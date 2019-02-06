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
        private Calculator uutCalculator;

        [SetUp]
        public void Setup()
        {
            uutCalculator = new Calculator();
        }

        [TestCase(10,10,20)]
        [TestCase(20,20,40)]
        [TestCase(14,14,28)]
        [TestCase(1,8,9)]
        [TestCase(7.2,1.8,9)]
        [Test]
        public void Add_ReturnsRightAmount(double a, double b, double c)
        {
            Assert.That(uutCalculator.Add(a,b), Is.EqualTo(c));
        }

        [TestCase(10, 10, 0)]
        [TestCase(20, 18, 2)]
        [TestCase(8, 10, -2)]
        [TestCase(6.2,2.2,4)]
        [TestCase(4.9,1.8,3.1)]
        [Test]
        public void Subtract_ReturnsRightAmount(double a, double b, double c)
        {
            Assert.That(uutCalculator.Subtract(a, b), Is.EqualTo(c).Within(0.01));
        }

        [TestCase(10, 2, 5)]
        [TestCase(20, 10, 2)]
        [TestCase(8, 3, 2.66)]
        [TestCase(3.2,1.8,1.77)]
        [TestCase(8.7,2.5,3.48)]
        [TestCase(0,20,0)]
        [Test]
        public void Divide_ReturnsRightAmount(double a, double b, double c)
        {
            Assert.That(uutCalculator.Divide(a, b), Is.EqualTo(c).Within(0.01));
        }

        [Test]
        public void Divide_Exception_DivideBy0()
        {
            Assert.That(() => uutCalculator.Divide(1,0), Throws.TypeOf<DivideByZeroException>());
        }

        [TestCase(10, 2, 20)]
        [TestCase(20, 3, 60)]
        [TestCase(8, 3, 24)]
        [TestCase(2.22,6.5,14.43)]
        [TestCase(-5,5,-25)]
        [Test]
        public void Multiply_ReturnsRightAmount(double a, double b, double c)
        {
            Assert.That(uutCalculator.Multiply(a, b), Is.EqualTo(c).Within(0.01));
        }

        [TestCase(10, 2, 100)]
        [TestCase(2, 3, 8)]
        [TestCase(8, 4, 4096)]
        [TestCase(2.22,2.22,5.87)]
        [TestCase(3.2,2.1,11.5)]
        [Test]
        public void Power_ReturnsRightAmount(double a, double b, double c)
        {
            Assert.That(uutCalculator.Power(a, b), Is.EqualTo(c).Within(0.01));
        }

        [Test]
        public void accumulation_2plus2_4()
        {
            uutCalculator.Add(3, 4);
            uutCalculator.Add(2, 2);

            Assert.That(uutCalculator.Accumulator, Is.EqualTo(4));
        }

        [Test]
        public void accumulation_2dividedBy2_1()
        {
            uutCalculator.Divide(4, 2);
            uutCalculator.Divide(2, 2);

            Assert.That(uutCalculator.Accumulator, Is.EqualTo(1));
        }
        [Test]
        public void accumulation_2Power2_4()
        {
            uutCalculator.Power(4, 2);
            uutCalculator.Power(2, 2);

            Assert.That(uutCalculator.Accumulator, Is.EqualTo(4));
        }
    }
}
