using System;
using NewYearPresent.Models;

namespace NewYearPresent.Helpers
{
    public static class SweetExtension
    {
        public static bool Append(ref Sweet[] array, Sweet item)
        {
            if (array == null)
            {
                return false;
            }

            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = item;
            return true;
        }

        public static Sweet[] AppendRange(this Sweet[] array, Sweet[] items)
        {
            if (items == null)
            {
                return null;
            }

            if (array == null)
            {
                array = new Sweet[0];
            }

            var previousLengthLastIndex = array.Length;
            var tempIndex = 0;
            var newLength = array.Length + items.Length;
            Array.Resize(ref array, newLength);
            for (; previousLengthLastIndex < newLength; previousLengthLastIndex++)
            {
                array[previousLengthLastIndex] = items[tempIndex++];
            }

            return array;
        }

        public static Sweet FindFirstSweetByWeight(this Sweet[] sweets, double weight)
        {
            Sweet result;

            foreach (var sweet in sweets)
            {
                if (sweet.Weight == weight)
                {
                    result = (Sweet)sweet.Clone();
                    return result;
                }
            }

            return null;
        }

        public static Sweet[] SortByWeight(this Sweet[] sweets)
        {
            if (sweets == null)
            {
                return null;
            }

            var result = new Sweet[sweets.Length];
            sweets.CopyTo(result, 0);
            Array.Sort(result);
            return result;
        }
    }
}
