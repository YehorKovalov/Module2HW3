using NewYearPresent.Models;
using NewYearPresent.Services;
using NewYearPresent.UI;

namespace NewYearPresent.Controllers
{
    public class PresentBagController
    {
        private readonly PresentBagServices _cartServices;
        private readonly ConsoleManager _consoleManager;

        public PresentBagController()
        {
            _consoleManager = new ConsoleManager();
            _cartServices = new PresentBagServices();
        }

        public void FindingSweet(double weight, PresentBag presentBag)
        {
            if (weight < 0)
            {
                _consoleManager.DisplayBadArgument();
                return;
            }

            var resultSweet = _cartServices.FirstSweetByWeight(weight, presentBag);

            if (resultSweet == null)
            {
                _consoleManager.DisplaySweetNotFound();
                return;
            }

            _consoleManager.DisplaySucceedFoundSweet(resultSweet);
        }

        public void SortingSweets(PresentBag presentBag)
        {
            if (presentBag == null || presentBag.Sweets == null)
            {
                _consoleManager.DisplayBadArgument();
                return;
            }

            var resultSweets = _cartServices.SortBagSweetsByWeight(presentBag);

            if (resultSweets == null)
            {
                return;
            }

            _consoleManager.DisplayPresentCartSweets(resultSweets);
        }

        public void FormingPresentBagSweets(ref PresentBag presentBag)
        {
            presentBag = _cartServices.FormPresentBag();

            if (presentBag == null)
            {
                _consoleManager.DisplayBadArgument();
                return;
            }

            _consoleManager.DisplayPresentCartSweets(presentBag.Sweets);
        }

        public void CountingTotalWeight(ref PresentBag presentBag)
        {
            if (presentBag == null)
            {
                _consoleManager.DisplayBadArgument();
                return;
            }

            var totalWeight = _cartServices.CountTotalWeight(presentBag);
            if (totalWeight <= 0)
            {
                _consoleManager.DisplayBadArgument();
                return;
            }

            _consoleManager.DisplayTotalWeight(totalWeight);
        }
    }
}
