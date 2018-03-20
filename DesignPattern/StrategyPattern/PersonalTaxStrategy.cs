using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class PersonalTaxStrategy:AbstractStragety
    {
        public override double CalculateTax(double number)
        {
            return number * 0.12f;
        }
    }
}
