using Common.Intefaces;
using Common.Interfaces;
using Domain.Services;

namespace UnitTest
{
    [TestClass]
    public class TestFuntion1
    {
        private IAverageCalculator _averageCalculator;

        [TestInitialize]
        public void TestInitialize()
        {
            _averageCalculator = new AverageCalculator(); 
        }

        [TestMethod]
        public void ArithmeticMeanCalculator_ReturnsCorrectArithmeticMean()
        {
            var numbers = new List<double> { 1, 2, 3, 4, 5 };
            var expectedAritmeticMean = 3;

            var actualAritmeticMean = _averageCalculator.ArithmeticMeanCalculator(numbers);

            Assert.AreEqual(expectedAritmeticMean, actualAritmeticMean, 0.001);
        }

        [TestMethod]
        public void HarmonicMeanCalculator_ReturnsCorrectHarmonicMean()
        {
            var numbers = new List<double> { 1, 2, 3, 4, 5}; 
            var expectedHarmonicMean = 2.19;

            var actualHarmonicMean = _averageCalculator.HarmonicMeanCalculator(numbers);

            Assert.AreEqual(expectedHarmonicMean, actualHarmonicMean, 0.001); 
        }

        [TestMethod]
        public void MedianCalculator_ReturnsCorrectMedianCalculator()
        {
            var numbers = new List<double> { 1, 2, 3, 4, 5 };
            var expectedMean = 3;

            var ActualMean = _averageCalculator.MedianCalculator(numbers);

            Assert.AreEqual(expectedMean, ActualMean, 0.001);
        }
    }
}