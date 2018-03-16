using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Egg:ICommunication
    {
        public void Ingredients()
        {
            Console.WriteLine("鸡蛋");
        }
    }
}
