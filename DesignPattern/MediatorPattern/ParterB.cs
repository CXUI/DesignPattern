﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    //具体成员B
    class ParterB:AbstractCardPartner
    {
        public override void ChangeCount(int count, AbstractMediator mediator)
        {
            mediator.BWin(count);
        }
    }
}
