using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Intefaces
{
    public interface IAverageCalculator
    {
        double ArithmeticMeanCalculator(List<double> numbers);

        double HarmonicMeanCalculator(List<double> numbers);

        double MedianCalculator(List<double> numbers);
    }
}
