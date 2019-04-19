using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp3.Core.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Core.Calculators.Tests
{
    [TestClass()]
    public class ExpressionCalculatorTests
    {
        [TestMethod()]
        public void CalculateTestSum()
        {
            var expression = "2+2";
            var calculator = new ExpressionCalculator();
            var result = calculator.Calculate(expression);
            Assert.AreEqual(4, result);
        }


        [TestMethod()]
        public void CalculateTestMinus()
        {
            var expression = "2-2";
            var calculator = new ExpressionCalculator();
            var result = calculator.Calculate(expression);
            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void CalculateTestMultiple()
        {
            var expression = "2*2";
            var calculator = new ExpressionCalculator();
            var result = calculator.Calculate(expression);
            Assert.AreEqual(4, result);
        }

        [TestMethod()]
        public void CalculateTestDivide()
        {
            var expression = "2/2";
            var calculator = new ExpressionCalculator();
            var result = calculator.Calculate(expression);
            Assert.AreEqual(1, result);
        }
    }
}