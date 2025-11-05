using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingnment_Linq.Data
{

    class EqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            return Sort(x) == Sort(y);
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            return Sort(obj).GetHashCode();
        }

        string Sort(string obj)
        {
            var Word = obj.ToCharArray();
            Array.Sort(Word);
            return new string(Word);
        }
    }
}
