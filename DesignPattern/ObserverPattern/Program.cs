using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{

    //程序设计：猫大叫一声，所有的老鼠都开始逃跑，主人被惊醒。

    //思路：1、构造出Cat、Mouse、Master三个类，并能使程序运行。

    //2、从Mouse和Master中提取抽象。

    //3、联动效应，只要执行Cat.Cryed()就可以使老鼠逃跑，主人惊醒。
    class Program
    {
        static void Main(string[] args)
        {

            Cat cat = new Cat();

          

            Mouse mouse = new Mouse("jam",cat);
    
            
            Mouse mouse1 = new Mouse("1111", cat);
            Master master=new Master("小明",cat);
            cat.Cry();

            Console.ReadLine();

        }
    }
}
