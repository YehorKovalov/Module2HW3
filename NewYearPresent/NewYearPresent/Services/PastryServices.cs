using System;
using NewYearPresent.Helpers;
using NewYearPresent.Models;
using NewYearPresent.Services.Abstractions;

namespace NewYearPresent.Services
{
    public class PastryServices : ISweetServices
    {
        public Sweet[] PackSweets()
        {
            var result = new Sweet[0];

            var flaky = GetFlaky();
            SweetExtension.Append(ref result, flaky);

            var puff = GetPuff();
            SweetExtension.Append(ref result, puff);

            var shortcrust = GetShortcrust();
            SweetExtension.Append(ref result, shortcrust);

            return result;
        }

        private Pastry GetFlaky()
        {
            const int maxFlakyWeight = 200;
            return new Pastry()
            {
                Name = "Flacky",
                Weight = new Random().Next(maxFlakyWeight),
                PasrtyType = PastryType.Flaky,
                FlourPercent = new Random().Next(100)
            };
        }

        private Pastry GetPuff()
        {
            const int maxFlakyWeight = 200;
            return new Pastry()
            {
                Name = "Puff",
                Weight = new Random().Next(maxFlakyWeight),
                PasrtyType = PastryType.Puff,
                FlourPercent = new Random().Next(100)
            };
        }

        private Pastry GetShortcrust()
        {
            const int maxFlakyWeight = 200;
            return new Pastry()
            {
                Name = "Shortcrust",
                Weight = new Random().Next(maxFlakyWeight),
                PasrtyType = PastryType.Shortcrust,
                FlourPercent = new Random().Next(100)
            };
        }
    }
}
