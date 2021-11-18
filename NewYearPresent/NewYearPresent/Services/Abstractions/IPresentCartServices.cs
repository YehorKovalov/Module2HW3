using NewYearPresent.Models;

namespace NewYearPresent.Services.Abstractions
{
    public interface IPresentCartServices
    {
        double CountTotalWeight(PresentBag presentCart);
        Sweet FirstSweetByWeight(double weight, PresentBag presentCart);
        Sweet[] SortBagSweetsByWeight(PresentBag presentCart);
    }
}