using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutofacConfiguration.Models
{
    public class Calculator
    {
        private readonly IDisplay _display;

        public Calculator(IDisplay display)
        {
            _display = display;
        }

        public void DoSum(int a, int b)
        {
            var engine = new LogicEngine();
            var result = engine.SumBigNumbers(a, b);

            _display.ShowNumber(result.ToString());
        }
    }
}
