﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class ConcreteStateB:State
    {
        public override void Handle(Context context)
        {
            context.State1 = new ConcreteStateA();
        }
    }
}
