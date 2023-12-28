using Common.Interfaces;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class TestFuntion2
    {
        private IStaircaseBuilder _staircaseBuilder;

        [TestInitialize]
        public void TestInitialize()
        {
            _staircaseBuilder = new StaircaseBuilder();
        }

        [TestMethod]
        public void RightAlignedStaircaseBuilder_ReturnsCorrectStaircase()
        {

            int size = 5;
            string expectedStaircase =
                "    #\r\n" +
                "   ##\r\n" +
                "  ###\r\n" +
                " ####\r\n" +
                "#####\r\n";

            string result = _staircaseBuilder.RightAlignedStaircaseBuilder(size);

            Assert.AreEqual(expectedStaircase, result);
        }

        [TestMethod]
        public void InvertedRightAlignedStaircaseBuilder_ReturnsCorrectStaircase()
        {
            int size = 5;
            string expectedStaircase =
                "#####\r\n" +
                " ####\r\n" +
                "  ###\r\n" +
                "   ##\r\n" +
                "    #\r\n";

            string result = _staircaseBuilder.InvertedRightAlignedStaircaseBuilder(size);

            Assert.AreEqual(expectedStaircase, result);
        }

        [TestMethod]
        public void CenterAlignedStaircaseBuilder_SizeGreaterThanLimit_ReturnsInvalidLimitMessage()
        {
            int size = 105;
            string expectedMessage = "limite no valido";

            string result = _staircaseBuilder.CenterAlignedStaircaseBuilder(size);

            Assert.AreEqual(expectedMessage, result);
        }
    }
}
