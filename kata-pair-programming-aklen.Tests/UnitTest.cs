using System;
using Machine.Specifications;
using Xunit;

namespace kata_pair_programming_aklen.Tests
{
    public class UnitTest
    {
        [Fact]
        public void When_Sum_Input_Are_5_And_5_Return_Ten()
        {
            CalculatorProgram calculator = new CalculatorProgram();
            decimal expected = 10;

            decimal result = calculator.SumNumbers(5, 5);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void When_Sum_Input_Are_Zero_Return_Zero()
        {
            CalculatorProgram calculator = new CalculatorProgram();
            decimal expected = 1;

            decimal result = calculator.SumNumbers(0, 0);

            Assert.Equal(expected, result);
        }
    }
}
