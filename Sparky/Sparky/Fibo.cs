using System.Collections.Generic;

namespace Sparky
{
    public class Fibo
    {
        public int Range { get; set; }
        public Fibo()
        {
            Range = 5;
        }

        public List<int> GetFiboSeries()
        {
            List<int> fiboSeries = new();
            int previousElement = 0, nextElement = 1, newElement = 0;
            if (Range == 1)
            {
                fiboSeries.Add(0);
                return fiboSeries;
            }
            fiboSeries.Add(0);
            fiboSeries.Add(1);
            for (int index = 3; index <= Range; index++)
            {
                newElement = previousElement + nextElement;
                fiboSeries.Add(newElement);
                previousElement = nextElement;
                nextElement = newElement;
            }
            return fiboSeries;
        }
    }
}
