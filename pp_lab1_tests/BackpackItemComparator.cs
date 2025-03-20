using pp_lab1;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_lab1_tests
{
    class BackpackItemComparator : IEqualityComparer<BackpackItem>
    {
        public bool Equals(BackpackItem? x, BackpackItem? y)
        {
            if (x is null || y is null)
                return false;

            return x.Value == y.Value && x.Weight == y.Weight;
        }

        public int GetHashCode([DisallowNull] BackpackItem obj)
        {
            return HashCode.Combine(obj.Value, obj.Weight);
        }
    }
}
