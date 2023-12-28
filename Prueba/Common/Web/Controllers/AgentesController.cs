using Common.Intefaces;
using Common.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("Agentes")]
    public class AgentesController : ControllerBase
    {
        private readonly IAverageCalculator _averageCalculator;
        private readonly IStaircaseBuilder _staircaseBuilder;
        public AgentesController(IAverageCalculator averageCalculator, IStaircaseBuilder staircaseBuilder) 
        {
            _averageCalculator = averageCalculator;
            _staircaseBuilder = staircaseBuilder;
        }

        [Route("AgenteA/ArithmeticMean")]
        [HttpPost]
        public double ArithmeticMeanCalculator(List<double> numbers)
        {
            return _averageCalculator.ArithmeticMeanCalculator(numbers);
        }

        [Route("AgenteA/StairsAscd")]
        [HttpPost]
        public string RightAlignedStaircaseBuilder(int size)
        {
            return _staircaseBuilder.RightAlignedStaircaseBuilder(size);
        }

        [Route("AgenteB/HarmonicMean")]
        [HttpPost]
        public double HarmonicMeanCalculator(List<double> numbers)
        {
            return _averageCalculator.HarmonicMeanCalculator(numbers);
        }

        [Route("AgenteB/StairsDscd")]
        [HttpPost]
        public string InvertedRightAlignedStaircaseBuilder(int size)
        {
            return _staircaseBuilder.InvertedRightAlignedStaircaseBuilder(size);
        }

        [Route("AgenteC/Median")]
        [HttpPost]
        public double MedianCalculator(List<double> numbers)
        {
            return _averageCalculator.MedianCalculator(numbers);
        }

        [Route("AgenteC/StairsCenter")]
        [HttpPost]
        public string CenterAlignedStaircaseBuilder(int size)
        {
            return _staircaseBuilder.CenterAlignedStaircaseBuilder(size);
        }

    }
}