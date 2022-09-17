using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem.Tests
{
    public class CounterMangerTests
    {
    }

    public class Counter
    {
        private double? _percentage;

        public Counter(string name, int count)
        {
            Name = name;
            Count = count;
        }

        public string Name { get; }
        public int Count { get; private set; }

        public double GetPercentage(int total) => _percentage ?? Math.Round(Count * 100.0 / total, 2);

        public void AddExcess(double excess) => _percentage += excess;
    }

    public class CounterManager
    {
        public CounterManager(params Counter[] counters)
        {
            Counters = new List<Counter>(counters);
        }

        public List<Counter> Counters { get; set; }

        public int Total() => Counters.Sum(c => c.Count);

        public double TotalPercentage() => Counters.Sum(c => c.GetPercentage(Total()));

        public void AnnounceWinner()
        {
            var excess = Math.Round(100 - TotalPercentage(), 2);
            Console.WriteLine($"Excess: {excess}");

            var biggestAmountOfVotes = Counters.Max(c => c.Count);
            var winners = Counters.Where(c => c.Count == biggestAmountOfVotes).ToList();

            if (winners.Count == 1)
            {
                var winner = winners.First();
                winner.AddExcess(excess);
                Console.WriteLine($"{winner.Name} won!");
            }
            else
            {
                // Add the excess to the the smallest counter
                if (winners.Count != Counters.Count)
                {
                    var lowestAmountOfVotes = Counters.Min(x => x.Count);
                    var loser = Counters.First(x => x.Count == lowestAmountOfVotes);
                    loser.AddExcess(excess);
                }

                Console.WriteLine(String.Join(" -DRAW- ", winners.Select(c => c.Name)));
            }

            foreach (var c in Counters)
            {
                Console.WriteLine($"{c.Name} Counts: {c.Count}, Percentage: {c.GetPercentage(Total())}%");
            }
        }
    }

}
