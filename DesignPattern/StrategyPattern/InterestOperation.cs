using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class InterestOperation
    {
        public AbstractStragety stragety;

        public InterestOperation(AbstractStragety stragety)
        {
            this.stragety = stragety;
        }

        public double  GetNum(double number)
        {
           return  stragety.CalculateTax(number);
        }


    }
}
