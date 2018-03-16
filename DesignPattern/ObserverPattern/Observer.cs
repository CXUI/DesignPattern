using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{

    /// <summary>
    /// 定义一个抽象类，用来注册将要触发的方法。
    /// </summary>
   public abstract class Observer:Subject 
    {
       public Observer(Subject sub)
       {
           sub.SubEvent += new SubDelegateEventHandler(Respose);
       }

 

       public abstract void Respose(int num);

       

    }
}
