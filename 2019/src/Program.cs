using AdventOfCode.DayOne;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IDayOneService, DayOneService>()
                .BuildServiceProvider();

            Console.WriteLine("Loading Day One Answer");
            var dayOneService = serviceProvider.GetService<IDayOneService>();
            var answer = new List<int>();

            var numbers =
                System.IO.File
                    .ReadAllLines($"{Environment.CurrentDirectory}/DayOne/DayOneInput.txt")
                    .Select(l => Convert.ToInt32(l))
                    .ToArray();

            foreach (var mass in numbers)
            {
                answer.Add(dayOneService.CalculateFuel(0, mass));
            }

            Console.WriteLine($"Answer for day one is: {answer.Sum() } ");
        }
    }
}
