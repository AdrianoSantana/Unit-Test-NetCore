using System.Collections.Generic;
using NUnit.Framework;

namespace Sparky.Test
{
    [TestFixture]
    public class CalculatorNUnitTest
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            // Act
            int result = calculator.AddNumbers(10, 20);
            // Asset
            Assert.AreEqual(30, result);
        }

        [Test]

        public void IsOddNumber_InputEvenNumber_ReturnFalse()
        {
            bool result = calculator.IsOddNumber(30);
            Assert.IsFalse(result);
        }

        [Test]
        [TestCase(11)]
        [TestCase(11111)]
        public void IsOddNumber_InputOddNumber_ReturnTrue(int value)
        {
            bool result = calculator.IsOddNumber(value);
            Assert.IsTrue(result);
        }

        [Test]
        [TestCase(10, ExpectedResult = false)]
        [TestCase(5, ExpectedResult = true)]

        public bool IsOddNumber_InputNumber_ReturnTrueIfOdd(int value)
        {
            return calculator.IsOddNumber(value);
        }

        [Test]
        [TestCase(5.4, 10.5)] // 15.9
        [TestCase(5.5, 10.5)] // 16.0
        public void AddNumbers_InputTwoDouble_GetCorrectAddition(double a, double b)
        {
            double result = calculator.AddNumbersDouble(a, b);
            Assert.AreEqual(15.9, result, .1);
        }

        [Test]
        public void OddRanger_InputMinAndMaxRange_ReturnsValidOddNumberRange()
        {
            int minValue = 5;
            int maxValue = 10;
            List<int> expectedOddRange = new List<int>() { 5, 7, 9 }; // Range: 5-10
            List<int> result = calculator.GetOddRange(minValue, maxValue);

            Assert.That(result, Is.EquivalentTo(expectedOddRange));
        }
    }
}
