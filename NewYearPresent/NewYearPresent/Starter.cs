using NewYearPresent.Controllers;
using NewYearPresent.Models;
using NewYearPresent.UI;

namespace NewYearPresent
{
    public class Starter
    {
        private readonly ConsoleManager _consoleManager;
        private readonly PresentBagController _presentController;
        public Starter()
        {
            _consoleManager = new ConsoleManager();
            _presentController = new PresentBagController();
        }

        public void Run()
        {
            _consoleManager.StartingWords();
            var presentBag = new PresentBag();
            _presentController.FormingPresentBagSweets(ref presentBag);
            _presentController.SortingSweets(presentBag);
            _presentController.CountingTotalWeight(ref presentBag);

            const double forExampleValue = 0.12;
            presentBag.Sweets[0].Weight = forExampleValue;
            _presentController.FindingSweet(forExampleValue, presentBag);
        }
    }
}
