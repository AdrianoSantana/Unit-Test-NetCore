using NUnit.Framework;

namespace Sparky.Test
{
    [TestFixture]
    public class GradingCalculatorTest
    {
        private GradingCalculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new GradingCalculator();
        }

        [Test]
        public void GradingCalculator_InputScore95Attendance90_GradeWithValueA()
        {
            calculator.Score = 95;
            calculator.AttendancePercentage = 90;
            Assert.AreEqual(calculator.GetGrade(), "A");
            Assert.That(calculator.GetGrade(), Is.EqualTo("A"));
        }

        [Test]
        [TestCase(95, 90, ExpectedResult = "A")]
        [TestCase(85, 90, ExpectedResult = "B")]
        [TestCase(65, 90, ExpectedResult = "C")]
        [TestCase(95, 65, ExpectedResult = "B")]
        [TestCase(95, 55, ExpectedResult = "F")]
        [TestCase(65, 55, ExpectedResult = "F")]
        [TestCase(50, 90, ExpectedResult = "F")]

        public string GradingCalculator_ScoreAttendance_GradeWithValue(int score, int attendance)
        {
            calculator.Score = score;
            calculator.AttendancePercentage = attendance;
            return calculator.GetGrade();
        }
        
    }
}
