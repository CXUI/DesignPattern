using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class HuaWeiPhoneScreen:AbstractScreenClass
    {
        public override void Prints()
        {
            Console.WriteLine("华为手机屏幕");
        }
    }
}
