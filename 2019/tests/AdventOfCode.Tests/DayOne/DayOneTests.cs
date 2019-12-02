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
        [InlineData(new[] { 14, 1969, 100756 }, 51314)]

        public void Fuel_Is_Calculated_Correctly(IEnumerable<int> mass, int expected)
        {
            
            var result = serviceUnderTest.GetTotalFuel(mass);

            result.Should().Be(expected);
        }
    }
}
