using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    //具体中介类
    class MediatorPater:AbstractMediator
    {
        public MediatorPater(AbstractCardPartner A, AbstractCardPartner B)
            : base(A, B)
        {

        }


        public override void AWin(int count)
        {
            A.MoneyCount += count;
            B.MoneyCount -= count;
        }

        public override void BWin(int count)
        {
            A.MoneyCount -= count;
            B.MoneyCount += count;
        }
    }
}
