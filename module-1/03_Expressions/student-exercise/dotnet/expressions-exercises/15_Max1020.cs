using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
      Given 2 positive int values, return the larger value that is in the range 10..20 inclusive,
      or return 0 if neither is in that range.
      Max1020(11, 19) → 19
      Max1020(19, 11) → 19
      Max1020(11, 9) → 11
      */
        public int Max1020(int a, int b)
        {
            if (10 <= a && a <= 20)
            {
                if (a >= b || b > 20)
                {
                    return a;
                }
            }
            if (10 <= b && b <= 20)
            {
                return b;
            }
            return 0;
        }
    }
}