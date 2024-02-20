using Microsoft.VisualStudio.TestTools.UnitTesting;
using Statistics;
using System;
namespace StatisticsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMaximum()
        {
            // Förväntat värde för maximum
            int expected = 378;

            // Får det värdet som kommer från Maximum
            int result = Statistics.Statistics.Maximum();

            // Jämför det förväntade värdet med det verkliga värdet
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMinimum()
        {
            // Förväntat värde för minimum
            double expected = -42;

            // Kallar på Minimum-metoden för att beräkna det verkliga värdet
            int result = Statistics.Statistics.Minimum();

            // Jämför det förväntade värdet med det verkliga värdet
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMean()
        {
            // Förväntat värde för medelvärdet
            double expected = 167.3;

            // Kallar på Mean-metoden för att beräkna det verkliga värdet

            double result = Statistics.Statistics.Mean();

            // Jämför det förväntade värdet med det verkliga värdet
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMedian()
        {
            // Förväntat värde för medianen
            double expected = 165;

            // Kallar på Median-metoden för att beräkna det verkliga värdet
            double result = Statistics.Statistics.Median();

            // Jämför det förväntade värdet med det verkliga värdet
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMode()
        {
            // Förväntade värden
            int[] expected = {3, 2, 1 };

            // Kallar på Mode-metoden för att beräkna det verkliga värdet
            int[] result = Statistics.Statistics.Mode();

            // Jämför de förväntade värdena med de verkliga värdena, ordningen spelar ingen roll
            CollectionAssert.AreEquivalent(expected, result);
        }

        [TestMethod]
        public void TestRange()
        {
            // Förväntat värde
            int expected = 420;

            // Kallar på Range-metoden för att beräkna det verkliga värdet
            int result = Statistics.Statistics.Range();

            // Jämför det förväntade värdet med det verkliga värdet
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestStandardDeviation()
        {
            // Förväntat värde
            double expected = 0.01;

            // Kallar på StandardDeviation-metoden för att beräkna det verkliga värdet
            double result = Statistics.Statistics.StandardDeviation();

            // Jämför det förväntade värdet med det verkliga värdet med en tolerans på 0.1
            Assert.AreEqual(expected, result, 0.1);
        }
    }
}


