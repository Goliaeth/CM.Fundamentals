using ConsoleCalculator;
using System;

namespace TestProject
{
    public class CalculatorTest
    {
        [Fact]
        public void ShoulDoAddition()
        {
            double result = Calculator.DoOperation(1, 2, "a");
            Assert.Equal(3, result);
        }

        [Fact]
        public void ShoulDoMultiplication()
        {
            double result = Calculator.DoOperation(3, 5, "m");
            Assert.Equal(15, result);
        }

        [Fact]
        public void ShoulDoDivision()
        {
            double result = Calculator.DoOperation(8, 2, "d");
            Assert.Equal(4, result);
        }

        [Fact]
        public void ShoulDoSubtraction()
        {
            double result = Calculator.DoOperation(3, 1, "s");
            Assert.Equal(2, result);
        }

        [Fact]
        public void ShouldReturnIncorrectOptionEntry()
        {
            var result1 = Calculator.DoOperation(3, 1, "r");
            var result2 = Calculator.DoOperation(6, 4, "");
            Assert.Equal(Double.NaN, result1);
            Assert.Equal(Double.NaN, result2);
        }
    }
}