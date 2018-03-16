using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Mouse:Observer,BreakOjbect
    {

        public string name;
        
        public Mouse(string name,Subject sub) :base(sub)
        {
            
            this.name = name;
 
        }
        public override void Respose(int num)
        {
            Console.WriteLine(name+"老鼠害怕逃走~~~~~~~~~"+num);
            Breakobj();
        }



        public void Breakobj()
        {
            Console.WriteLine("-----------------------------");
        }
    }
}
