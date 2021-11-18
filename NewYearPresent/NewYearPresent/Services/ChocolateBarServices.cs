using System;
using NewYearPresent.Helpers;
using NewYearPresent.Models;
using NewYearPresent.Models.SweetsTypes;
using NewYearPresent.Services.Abstractions;

namespace NewYearPresent.Services
{
    public class ChocolateBarServices : ISweetServices
    {
        public Sweet[] PackSweets()
        {
            var result = new Sweet[0];
            var chocolateBar = GetDarkChocolateBar();
            SweetExtension.Append(ref result, chocolateBar);
            var milkBar = GetMilkChocolateBar();
            SweetExtension.Append(ref result, milkBar);

            return result;
        }

        private ChocolateBar GetDarkChocolateBar()
        {
            const int maxWeightInGrams = 300;
            return new ChocolateBar
            {
                Name = "Roshen dark",
                Weight = new Random().Next(maxWeightInGrams),
                CacaoPercent = new Random().Next(100),
                ChocolateType = ChocolateType.Black,
                WithNuts = new Random().Next(2) == 0,
                WithRaisins = new Random().Next(2) == 0
            };
        }

        private ChocolateBar GetMilkChocolateBar()
        {
            const int maxWeightInGrams = 300;
            return new ChocolateBar
            {
                Name = "Cinder chocolate white",
                Weight = new Random().Next(maxWeightInGrams),
                MilkPercent = new Random().Next(100),
                ChocolateType = ChocolateType.Milk,
                WithNuts = new Random().Next(2) == 0,
                WithRaisins = new Random().Next(2) == 0
            };
        }
    }
}
