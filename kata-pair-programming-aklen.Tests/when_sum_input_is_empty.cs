using System;
using System.Collections.Generic;
using Machine.Specifications;

namespace kata_pair_programming_aklen.Tests
{
    public class when_sum_input_is_empty
    {

        static CalculatorProgram _calculator;

        Establish context = () =>
            _calculator = new CalculatorProgram();

        //_calculator.SumValues(new List<decimal>(){1, 2, 3});
        Because of = () =>
            _calculator.SumValues(new List<decimal>());

        It should_numbers_are_empty = () =>
            _calculator.Result.CompareTo(0);

    }
}