using System;
using NewYearPresent.Models;
using NewYearPresent.Models.SweetsTypes;

namespace NewYearPresent.UI
{
    public class ConsoleManager
    {
        public void StartingWords()
        {
            Console.WriteLine("Hi! Let's collect a bag!");
        }

        public void DisplaySucceedFoundSweet(Sweet sweet)
        {
            DisplaySweet(sweet);
        }

        public void DisplaySweetNotFound()
        {
            Console.WriteLine("Sweet hasn't found...Try again");
        }

        public void DisplayTotalWeight(double weight)
        {
            Console.WriteLine($"Totel weigth of present: {weight}");
        }

        public void DisplayBadArgument()
        {
            Console.WriteLine($"Bad argument");
        }

        public void DisplayPresentCartSweets(Sweet[] sweets)
        {
            Console.WriteLine("Present includes: ");
            foreach (var sweet in sweets)
            {
                DisplaySweet(sweet);
            }

            Console.WriteLine();
        }

        private void DisplaySweet(Sweet sweet)
        {
            Console.Write($"{sweet.Name}, {sweet.Weight} grams");
            if (sweet is Chocolate chocolate)
            {
                if (chocolate is Candy candy)
                {
                    DisplayCandy(candy);
                }

                if (chocolate is ChocolateBar chocolateBar)
                {
                    DisplayChocolateBar(chocolateBar);
                }

                switch (chocolate.ChocolateType)
                {
                    case ChocolateType.Black:
                        Console.Write($", with {chocolate.CacaoPercent} cacao percent");
                        break;
                    case ChocolateType.Milk:
                        Console.Write($", with {chocolate.MilkPercent} milk percent");
                        break;
                }
            }
            else if (sweet is Pastry pastry)
            {
                DisplayPastry(pastry);
            }

            Console.WriteLine();
        }

        private void DisplayCandy(Candy candy)
        {
            if (candy.WithCream)
            {
                Console.Write(", with cream inside");
            }
        }

        private void DisplayChocolateBar(ChocolateBar chocolateBar)
        {
            if (chocolateBar.WithNuts)
            {
                Console.Write(", with nuts");
            }

            if (chocolateBar.WithRaisins)
            {
                Console.Write(", with raisins");
            }
        }

        private void DisplayPastry(Pastry pastry)
        {
            Console.Write($", with {pastry.FlourPercent} flour percent");
        }
    }
}
