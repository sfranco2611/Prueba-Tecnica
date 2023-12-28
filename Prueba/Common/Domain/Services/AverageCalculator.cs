using Common.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class AverageCalculator : IAverageCalculator
    {
        public double ArithmeticMeanCalculator(List<double> numbers)
        {
            return numbers.Average();
        }

        public double HarmonicMeanCalculator(List<double> numbers)
        {
            double sumOfReciprocals = numbers.Sum(x => 1 / x);
            return numbers.Count / sumOfReciprocals;
        }

        public double MedianCalculator(List<double> numbers)
        {
            int numberCount = numbers.Count;
            var sortedNumbers = numbers.OrderBy(n => n).ToList();
            int midIndex = numberCount / 2;
            if (numberCount % 2 == 0)
            {
                return (sortedNumbers[midIndex] + sortedNumbers[midIndex - 1]) / 2;
            }
            else
            {
                return sortedNumbers[midIndex];
            }   
        }
    }
}
