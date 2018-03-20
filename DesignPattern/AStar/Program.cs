using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar
{
    class Program
    {
        static void Main(string[] args)
        {

            AStarRun mytest = new AStarRun();

            Point pa = new Point();
            pa.x = 1;
            pa.y = 1;

            Point pd = new Point();
            pd.x = 8;
            pd.y = 8;

            mytest.FindWay(pa, pd);

            mytest.PrintMap();

            Console.ReadKey();

        }
    }
}
