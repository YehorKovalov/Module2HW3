using NewYearPresent.Models.SweetsTypes;

namespace NewYearPresent.Models
{
    public class Chocolate : Sweet
    {
        public double CacaoPercent { get; set; }
        public double MilkPercent { get; set; }
        public ChocolateType ChocolateType { get; set; }
    }
}
