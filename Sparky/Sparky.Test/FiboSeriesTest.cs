using System.Collections.Generic;
using NUnit.Framework;

namespace Sparky.Test
{
    [TestFixture]
    public class FiboSeriesTest
    {
        private Fibo fibo;

        [SetUp]
        public void Setup()
        {
            fibo = new Fibo();
        }

        [Test]
        public void GetFiboSeries_InputRange1_ListIsNotEmpty()
        {
            List<int> expectedList = new() { 0 };
            fibo.Range = 1;

            var fiboSeries = fibo.GetFiboSeries();

            Assert.That(fiboSeries, Is.Not.Empty);
            Assert.That(fiboSeries, Is.Ordered);
            Assert.That(fiboSeries, Is.EquivalentTo(expectedList));
        }

        [Test]
        public void GetFiboSeries_InputRange6_ListFibo()
        {
            List<int> expectedList = new List<int>{ 0, 1, 1, 2 , 3 ,5 };
            fibo.Range = 6;

            var fiboSeries = fibo.GetFiboSeries();

            Assert.Multiple(() => {
                Assert.That(fiboSeries, Has.Member(3));
                Assert.That(fiboSeries.Count, Is.EqualTo(6));
                Assert.That(fiboSeries, Has.No.Member(4));
                Assert.That(fiboSeries, Is.EquivalentTo(expectedList));
            }); 
        }

    }
}
