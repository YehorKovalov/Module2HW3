using System;
using NewYearPresent.Helpers;
using NewYearPresent.Models;
using NewYearPresent.Models.SweetsTypes;
using NewYearPresent.Services.Abstractions;

namespace NewYearPresent.Services
{
    public class CandyServices : ISweetServices
    {
        public Sweet[] PackSweets()
        {
            const int jellyCandiesAmount = 3;
            const int chocolateCandiesAmount = 3;
            const int milkCandiesAmount = 3;
            var result = new Sweet[0];
            Candy tempCandy;
            for (int i = 0; i < jellyCandiesAmount; i++)
            {
                tempCandy = GetCandyWithCream();
                SweetExtension.Append(ref result, tempCandy);
            }

            for (int i = 0; i < chocolateCandiesAmount; i++)
            {
                tempCandy = GetBlackChocolateCandy();
                SweetExtension.Append(ref result, tempCandy);
            }

            for (int i = 0; i < milkCandiesAmount; i++)
            {
                tempCandy = GetMilkCandy();
                SweetExtension.Append(ref result, tempCandy);
            }

            return result;
        }

        private Candy GetCandyWithCream()
        {
            const int minCacaoPercent = 60;
            const int _maxWeight = 40;
            return new Candy()
            {
                Name = "Jelly Bear",
                Weight = new Random().Next(_maxWeight),
                CacaoPercent = new Random().Next(minCacaoPercent, 100),
                WithCream = true
            };
        }

        private Candy GetBlackChocolateCandy()
        {
            const int minCacaoPercent = 60;
            const int _maxWeight = 40;
            return new Candy()
            {
                Name = "Jack",
                Weight = new Random().Next(_maxWeight),
                CacaoPercent = new Random().Next(minCacaoPercent, 100),
                ChocolateType = ChocolateType.Black
            };
        }

        private Candy GetMilkCandy()
        {
            const int minMilkPercent = 60;
            const int _maxWeight = 40;
            return new Candy()
            {
                Name = "Cinder",
                Weight = new Random().Next(_maxWeight),
                MilkPercent = new Random().Next(minMilkPercent, 100),
                ChocolateType = ChocolateType.Milk
            };
        }
    }
}
