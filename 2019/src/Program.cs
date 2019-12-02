using AdventOfCode.DayOne;
using AdventOfCode.DayTwo;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IDayOneService, DayOneService>()
                .AddSingleton<IDayTwoService, DayTwoService>()
                .BuildServiceProvider();

            DayOne(serviceProvider);
            DayTwo(serviceProvider);

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

        static void DayTwo(ServiceProvider serviceProvider)
        {
            var resultList = new List<int>();
            File.ReadAllLines($"{Environment.CurrentDirectory}/DayTwo/DayTwoInput.txt")
                .ToList()
                .ForEach((line) => {
                    var numbers = line.Split(',')
                          .Select(c => Convert.ToInt32(c));
                    resultList.AddRange(numbers);
                });

            var dayTwoService = serviceProvider.GetService<IDayTwoService>();

            var noun = 0;
            var verb = 0;

            for(noun = 0; noun <= 99; noun++)
            {
                for(verb = 0; verb <= 99; verb++)
                {
                    var numbers = resultList.ToArray();
                    numbers[1] = noun;
                    numbers[2] = verb;

                    var dayTwoResult = dayTwoService.ProcessOperations(numbers);

                    if(dayTwoResult[0] == 19690720)
                        Console.WriteLine($"Answer for day two is: Noun: {noun} | Verb: {verb} ");
                }
            }



            

            
        }
    }
}
