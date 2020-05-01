using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutofacConfiguration.Models
{
    public class Display : IDisplay
    {
        public int GetStatus()
        {
            return 5;
        }

        public void ShowNumber(string bignumber)
        {
            Console.WriteLine(bignumber);
        }
    }
}
