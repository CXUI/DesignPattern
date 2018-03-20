using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            AbstractCardPartner A = new ParterAL();
            AbstractCardPartner B = new ParterB();
            A.MoneyCount = 20;
            B.MoneyCount = 20;

            AbstractMediator mediator = new MediatorPater(A,B);
            A.ChangeCount(5, mediator);
            Console.WriteLine("A:" + A.MoneyCount);
            Console.WriteLine("B:" + B.MoneyCount);


            B.ChangeCount(5, mediator);
            Console.WriteLine("A:" + A.MoneyCount);
            Console.WriteLine("B:" + B.MoneyCount);

            Console.ReadKey();
        }
    }
}
