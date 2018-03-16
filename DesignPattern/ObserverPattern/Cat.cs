using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Cat:Subject
    {
        public void Cry()
        {
            Console.WriteLine("猫发出了一声叫声");
            this.Trigger();
           
        }
    }
}
