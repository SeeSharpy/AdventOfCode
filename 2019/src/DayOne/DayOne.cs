using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.DayOne
{
    public static class DayOne
    {
        public static int CalculateFuel(int mass)
        {
            var roundedDown = Convert.ToInt32(Math.Floor(mass / 3.0));

            return roundedDown - 2;
        }
    }
}
