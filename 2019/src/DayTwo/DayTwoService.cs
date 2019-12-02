using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.DayTwo
{
    public class DayTwoService : IDayTwoService
    {
        public int[] ProcessOperations(int[] operations)
        {
            for(int i = 0; i < operations.Length; i += 4)
            {

                var opCode = operations[i];

                if(opCode == 99)
                {
                    i += 1;
                    continue;
                }

                var firstValue = operations[i + 1];
                var secondValue = operations[i + 2];
                var storageInt = operations[i + 3];

                switch (opCode)
                {
                    case 1:
                        operations[storageInt] = operations[firstValue] + operations[secondValue];
                        break;
                    case 2:
                        operations[storageInt] = operations[firstValue] * operations[secondValue];
                        break;
                }
            }
            return operations;
        }
    }
}
