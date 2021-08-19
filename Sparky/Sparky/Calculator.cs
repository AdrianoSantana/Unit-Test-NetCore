using System.Collections.Generic;

namespace Sparky
{
    public class Calculator
    {
        public List<int> NumberRange = new List<int>();
        public int AddNumbers(int x, int y)
        {
            return x + y;
        }

        public bool IsOddNumber(int number)
        {
            return number % 2 != 0;
        }

        public double AddNumbersDouble(double a, double b)
        {
            return a + b;
        }

        public List<int> GetOddRange(int min, int max)
        {
            NumberRange.Clear();
            for (var index = min; index <= max; index++)
            {
                if (index % 2 != 0)
                {
                    NumberRange.Add(index);
                }
            }
            return NumberRange;
        }
    }
}
