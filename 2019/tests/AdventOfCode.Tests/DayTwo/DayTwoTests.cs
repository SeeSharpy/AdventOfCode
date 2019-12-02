using AdventOfCode.DayTwo;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AdventOfCode.Tests.DayTwo
{
    public class DayTwoTests
    {
        [Theory]
        [InlineData(new[] { 1, 0, 0, 0, 99 }, new[] { 2, 0, 0, 0, 99 })]
        [InlineData(new[] { 2, 3, 0, 3, 99 }, new[] { 2, 3, 0, 6, 99 })]
        [InlineData(new [] { 2, 4, 4, 5, 99, 0 }, new[] { 2, 4, 4, 5, 99, 9801 })]
        [InlineData(new[] { 1, 1, 1, 4, 99, 5, 6, 0, 99 }, new[] { 30, 1, 1, 4, 2, 5, 6, 0, 99 })]
        public void IntcodeIsCorrect(int[] operations, int[] expected)
        {
            var dayTwoService = new DayTwoService();

            var result = dayTwoService.ProcessOperations(operations);

            result.Should().BeEquivalentTo(expected);
        }   
    }
}
