using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class XiMiPhoneShell:AbstractPhoneShellClass
    {
        public override void Prints()
        {
            Console.WriteLine("小米手机壳");
        }
    }
}
