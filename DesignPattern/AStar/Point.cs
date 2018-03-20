using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar
{
    class Point
    {
        public int y;
        public int x;
        public int G;
        public int H;
        public Point father;

        public Point()
        {

        }

        public Point(int y,int x,int g,int h, Point f)
        {
            this.y = y;
            this.x = x;
            this.G = g;
            this.H = h;
            this.father = f;

        }

    }
}
