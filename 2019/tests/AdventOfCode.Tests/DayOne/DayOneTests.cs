using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using AdventOfCode.DayOne;
using FluentAssertions;

namespace AdventOfCode.Tests.DayOne
{
    public class DayOneTests
    {
        private DayOneService serviceUnderTest;

        public DayOneTests()
        {
            serviceUnderTest = new DayOneService();
        }
        [Theory]
        [InlineData(14, 2)]
        [InlineData(1969, 966)]
        [InlineData(100756, 50346)]
        public void Fuel_Is_Calculated_Correctly(int mass, int expected)
        {
            var result = serviceUnderTest.CalculateFuel(0, mass);

            result.Should().Be(expected);
        }
    }
}
