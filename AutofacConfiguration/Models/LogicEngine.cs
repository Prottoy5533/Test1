using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutofacConfiguration.Models
{
    public class LogicEngine
    {
        public long SumBigNumbers(int a, int b)
        {
            long x = a;
            long y = b;
            return x + y;
        }
    }
}
