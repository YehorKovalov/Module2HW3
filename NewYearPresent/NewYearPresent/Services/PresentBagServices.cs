using NewYearPresent.Models;
using NewYearPresent.Services.Abstractions;
using NewYearPresent.Helpers;

namespace NewYearPresent.Services
{
    public class PresentBagServices : IPresentCartServices
    {
        private ISweetServices _sweetServices;

        public double CountTotalWeight(PresentBag presentBag)
        {
            if (presentBag == null || presentBag.Sweets == null)
            {
                return 0;
            }

            double result = 0;
            foreach (var sweet in presentBag.Sweets)
            {
                result += sweet.Weight;
            }

            return result;
        }

        public Sweet[] SortBagSweetsByWeight(PresentBag presentBag)
        {
            if (presentBag == null || presentBag.Sweets == null)
            {
                return null;
            }

            return presentBag.Sweets.SortByWeight();
        }

        public Sweet FirstSweetByWeight(double weight, PresentBag presentBag)
        {
            if (weight <= 0 || presentBag.Sweets == null)
            {
                return null;
            }

            return presentBag.Sweets.FindFirstSweetByWeight(weight);
        }

        public PresentBag FormPresentBag()
        {
            var presentBag = new PresentBag();
            _sweetServices = new CandyServices();
            var sweets = _sweetServices.PackSweets();
            AddSweetsToBag(sweets, ref presentBag);
            _sweetServices = new ChocolateBarServices();
            sweets = _sweetServices.PackSweets();
            AddSweetsToBag(sweets, ref presentBag);
            _sweetServices = new PastryServices();
            sweets = _sweetServices.PackSweets();
            AddSweetsToBag(sweets, ref presentBag);
            return presentBag;
        }

        private bool AddSweetsToBag(Sweet[] sweets, ref PresentBag presentBag)
        {
            if (sweets == null || presentBag == null)
            {
                return false;
            }

            var result = presentBag.Sweets.AppendRange(sweets);
            presentBag.Sweets = result;

            if (presentBag.Sweets == null)
            {
                return false;
            }

            return true;
        }
    }
}
