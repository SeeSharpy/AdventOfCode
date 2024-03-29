﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.DayOne
{
    public class DayOneService : IDayOneService
    {

        public int GetTotalFuel(IEnumerable<int> masses)
        {
            var answer = 0;

            foreach (var mass in masses)
            {
                answer += CalculateFuel(0, mass);
            }

            return answer;
        }

        int CalculateFuel(int totalMass, int mass)
        {
            var sum = totalMass;

            var fuelRequired = Convert.ToInt32(Math.Floor(mass / 3.0)) - 2;
            

            if (fuelRequired > 0)
            {
                sum += fuelRequired;
                sum = CalculateFuel(sum, fuelRequired);
            }

            return sum;
        }


    }
}
