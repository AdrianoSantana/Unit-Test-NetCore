using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sparky;

namespace SparkyMSTest
{
    [TestClass]
    public class CalculatorMSTest
    {
        [TestMethod]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            // Arrange
            Calculator calc = new();
            // Act
            int result = calc.AddNumbers(10, 20);
            // Asset
            Assert.AreEqual(30, result);
        }
        
    }
}
