using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{

    // 抽象中介者类
    abstract class AbstractMediator
    {

        public AbstractCardPartner A;
        public AbstractCardPartner B;

        public AbstractMediator(AbstractCardPartner a,AbstractCardPartner b)
        {
            this.A = a;
            this.B = b;

        }

        public abstract void AWin(int count);
        public abstract void BWin(int count);

    }
}
