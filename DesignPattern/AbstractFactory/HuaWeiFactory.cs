using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class HuaWeiFactory:AbstroactFacClass
    {
        public override AbstractScreenClass Screen()
        {
            return new HuaWeiPhoneScreen();
        }

        public override AbstractPhoneShellClass PhoneShell()
        {
            return new HuaWeiPhoneShell();
        }
    }
}
