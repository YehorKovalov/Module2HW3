using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPresent.Models
{
    public class Sweet : IComparable<Sweet>, ICloneable
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(Sweet sweet)
        {
            return Weight.CompareTo(sweet.Weight);
        }
    }
}
