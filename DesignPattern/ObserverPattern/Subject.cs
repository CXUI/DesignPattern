using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public delegate void SubDelegateEventHandler(int num);

    /// <summary>
    ///抽象类，定义一个触发类，  具体依赖抽象，定义一个事件，用来注册要触发的事件。
    /// </summary>
   public abstract class Subject
    {
        public event SubDelegateEventHandler SubEvent;

        public void Trigger()
        {
            if(this.SubEvent!=null){

                this.SubEvent(0);
            }
        }
    }
}
