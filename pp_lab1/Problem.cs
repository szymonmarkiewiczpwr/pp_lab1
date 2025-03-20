using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("pp_lab1_tests")]
[assembly: InternalsVisibleTo("pp_lab1_forms")]
namespace pp_lab1
{
    internal class Problem
    {
        internal int ItemsCount { get; private set; }
        internal List<BackpackItem> AvaiableItems { get; private set; }
        internal List<BackpackItem> BackpackItems { get; private set; } = new List<BackpackItem>();

        private readonly Random _random;

        public Problem(
            int rngSeed,
            int generateItemsCount = 10_000_000
            )
        {
            _random = new Random(rngSeed);

            ItemsCount = generateItemsCount;
            AvaiableItems = Enumerable.Range(1, generateItemsCount)
                .Select(x => new BackpackItem(_random.Next(10) + 1, _random.Next(10) + 1))
                .ToList();

            AvaiableItems.Sort();
        }

        public List<BackpackItem> Solve(int backpackCapacity)
        {
            int weightSum = 0;
            for (int i = 0; i < AvaiableItems.Count; i++)
            {
                weightSum += AvaiableItems[i].Weight;
                if (weightSum >= backpackCapacity)
                {
                    weightSum -= AvaiableItems[i].Weight;
                    continue;
                }

                BackpackItems.Add(AvaiableItems[i]);
            }

            return BackpackItems;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (BackpackItems.Count == 0)
            {
                stringBuilder.AppendLine("Problem not yet solved, items avaiable:\n");
                AvaiableItems.ForEach(x =>
                {
                    stringBuilder.AppendLine($"\t{x.ToString()}");
                });

                return stringBuilder.ToString();
            }

            BackpackItems.ForEach(x =>
            {
                stringBuilder.AppendLine($"{x.ToString()} ");
            });
            stringBuilder.AppendLine($"Total Sum: {BackpackItems.Sum(x => x.Value)}");
            stringBuilder.AppendLine($"Total Weight: {BackpackItems.Sum(x => x.Weight)}");
            return stringBuilder.ToString();
        }
    }
}
