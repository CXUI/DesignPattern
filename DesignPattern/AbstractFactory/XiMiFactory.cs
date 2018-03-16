using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class XiMiFactory:AbstroactFacClass
    {
        public override AbstractScreenClass Screen()
        {
            return new XiMiPhoneScreen();
        }

        public override AbstractPhoneShellClass PhoneShell()
        {
            return new XiMiPhoneShell();
        }
    }
}
