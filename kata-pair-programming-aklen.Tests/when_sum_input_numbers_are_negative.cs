using System.Collections.Generic;
using Machine.Specifications;

namespace kata_pair_programming_aklen.Tests
{
    public class when_sum_input_numbers_are_negative
    {
        static CalculatorProgram _calculator;

        Establish context = () =>
            _calculator = new CalculatorProgram();

        Because of = () =>
            _calculator.SumValues(new List<decimal>()
                { -5, -7, -8 });

        It should_numbers_are_negative_not_saved_sum = () =>
            _calculator.Result.CompareTo(1);
    }
}