using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Master:Observer,BreakOjbect
    {
        public string name;
        public Master(string nam ,Subject sub) :base(sub)
        {
  
            name = nam;
        }

        public override void Respose(int num)
        {
            Console.WriteLine(name+"睡眼朦胧醒来~~~~~~~~~~"+num);

        }




        void BreakOjbect.Breakobj()
        {
            Console.WriteLine("--------------------+++++++++++++++++++++++++=");
        }
    }
}
