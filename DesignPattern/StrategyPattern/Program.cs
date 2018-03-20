using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
       
            InterestOperation person = new InterestOperation(new PersonalTaxStrategy());
 
            Console.WriteLine("个人税：{0}",person.GetNum(50000));


            InterestOperation enterprise = new InterestOperation(new EnterpriseTaxStrategy());

            Console.WriteLine("个人税：{0}" , enterprise.GetNum(50000));

            Console.ReadKey();


        }
    }
}
