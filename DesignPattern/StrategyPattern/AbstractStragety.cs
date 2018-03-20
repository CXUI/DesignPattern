using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
   abstract class AbstractStragety
    {
        public abstract double CalculateTax(double number); 
    }
}
