using System;
using Machine.Specifications;
using Xunit;

namespace kata_pair_programming_aklen.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void When_Sum_Input_Empty_Return_Zero()
        {
            CalculatorProgram calculator = new CalculatorProgram();
            decimal result = calculator.SumNumbers(0, 0);

            Assert.Matches("result", "0");
        }
    }
}
