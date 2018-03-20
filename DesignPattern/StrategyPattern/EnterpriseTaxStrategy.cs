using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class EnterpriseTaxStrategy:AbstractStragety
    {
        public override double CalculateTax(double number)
        {
            return (number - 3500) > 0 ? (number - 3500) * 0.045f : 0.0f;
        }
    }
}
