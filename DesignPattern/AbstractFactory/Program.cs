using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //华为工厂
            HuaWeiFactory hw = new HuaWeiFactory();
            hw.PhoneShell().Prints();
            hw.Screen().Prints();

            //小米工厂
            XiMiFactory xm = new XiMiFactory();
            XiMiPhoneScreen xms = (XiMiPhoneScreen)xm.Screen();
            xms.Prints();
            XiMiPhoneShell xmp = (XiMiPhoneShell)xm.PhoneShell();
            xmp.Prints();


            Console.ReadKey();
        }
    }
}
