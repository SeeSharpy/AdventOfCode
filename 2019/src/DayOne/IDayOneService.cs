using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.DayOne
{
    public interface IDayOneService
    {
        public int GetTotalFuel(IEnumerable<int> masses);
    }
}
