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
            // F�rv�ntat v�rde f�r maximum
            int expected = 378;

            // F�r det v�rdet som kommer fr�n Maximum
            int result = Statistics.Statistics.Maximum();

            // J�mf�r det f�rv�ntade v�rdet med det verkliga v�rdet
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMinimum()
        {
            // F�rv�ntat v�rde f�r minimum
            double expected = -42;

            // Kallar p� Minimum-metoden f�r att ber�kna det verkliga v�rdet
            int result = Statistics.Statistics.Minimum();

            // J�mf�r det f�rv�ntade v�rdet med det verkliga v�rdet
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMean()
        {
            // F�rv�ntat v�rde f�r medelv�rdet
            double expected = 167.3;

            // Kallar p� Mean-metoden f�r att ber�kna det verkliga v�rdet

            double result = Statistics.Statistics.Mean();

            // J�mf�r det f�rv�ntade v�rdet med det verkliga v�rdet
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMedian()
        {
            // F�rv�ntat v�rde f�r medianen
            double expected = 165;

            // Kallar p� Median-metoden f�r att ber�kna det verkliga v�rdet
            double result = Statistics.Statistics.Median();

            // J�mf�r det f�rv�ntade v�rdet med det verkliga v�rdet
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMode()
        {
            // F�rv�ntade v�rden
            int[] expected = {3, 2, 1 };

            // Kallar p� Mode-metoden f�r att ber�kna det verkliga v�rdet
            int[] result = Statistics.Statistics.Mode();

            // J�mf�r de f�rv�ntade v�rdena med de verkliga v�rdena, ordningen spelar ingen roll
            CollectionAssert.AreEquivalent(expected, result);
        }

        [TestMethod]
        public void TestRange()
        {
            // F�rv�ntat v�rde
            int expected = 420;

            // Kallar p� Range-metoden f�r att ber�kna det verkliga v�rdet
            int result = Statistics.Statistics.Range();

            // J�mf�r det f�rv�ntade v�rdet med det verkliga v�rdet
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestStandardDeviation()
        {
            // F�rv�ntat v�rde
            double expected = 0.01;

            // Kallar p� StandardDeviation-metoden f�r att ber�kna det verkliga v�rdet
            double result = Statistics.Statistics.StandardDeviation();

            // J�mf�r det f�rv�ntade v�rdet med det verkliga v�rdet med en tolerans p� 0.1
            Assert.AreEqual(expected, result, 0.1);
        }
    }
}


