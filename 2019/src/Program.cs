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

            DayOne(serviceProvider);

            Console.ReadLine();
        }

        static void DayOne(ServiceProvider serviceProvider)
        {
            var dayOneService = serviceProvider.GetService<IDayOneService>();
            var dayOneInput =
                System.IO.File
                    .ReadAllLines($"{Environment.CurrentDirectory}/DayOne/DayOneInput.txt")
                    .Select(l => Convert.ToInt32(l))
                    .ToArray();

            Console.WriteLine($"Answer for day one is: {dayOneService.GetTotalFuel(dayOneInput)} ");
        }
    }
}
