using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar
{
    class AStarRun
    {
        //数组用1表示可通过，0表示障碍物

        byte[,] R = new byte[10, 10]
        {
            { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }

        };

        //开启列表
        List<Point> OpenList = new List<Point>();

        //关闭列表
        List<Point> CloseList = new List<Point>();

     
        //从开启列表查找F值最小的节点
        private Point GetMinFFromOpenList()
        {
            Point pmit = null;
            foreach(var p in OpenList)
            {
                if (pmit == null||pmit.G+pmit.H>p.G+p.H)
                {
                    pmit = p;
                }

                
            }

            return pmit;
        }

        //判断一个点是否是障碍物
        public bool isBar(Point p ,byte[,] map)
        {
            if (map[p.y, p.x] == 0)
            {
                return true;
            }
            return false;
        }

        //判断一个点是否在关闭列表中
        public bool IsInCloseList(int x,int y)
        {
            foreach(Point temp in CloseList){

                if(temp.x==x&&temp.y==y)
                {
                    return true;
                }
            }
            return false;
        }

        //从关闭列表中得到一个点
        public Point GetPointFromCloseList(int x,int y)
        {
            foreach(Point p in CloseList)
            {
                if(p.x==x&&p.y==y)
                {
                    return p;
                }
            }
            return null;
        }

        //判断开启列表是否包含一个坐标的点
        private bool IsInOpenList(int x, int y)
        {
            foreach (Point p in OpenList) if (p.x == x && p.y == y) return true;
            return false;
        }
        //从开启列表返回对应坐标的点
        private Point GetPointFromOpenList(int x, int y)
        {
            foreach (Point p in OpenList) if (p.x == x && p.y == y) return p;
            return null;
        }

        //得到某个点的G值
        private int GetG(Point p)
        {
            if (p.father == null) return 0;
            if (p.x == p.father.x && p.y == p.father.y) return p.father.G + 10;
            else return p.father.G + 14;
        }

        //得到某个点的H值
        public int GetH(Point p,Point pd)
        {
            return Math.Abs(p.x - pd.x) + Math.Abs(p.y - pd.y);
        }


        //检查当前节点附近的节点
        private void CheckP8(Point p0, byte[,] map, Point pa, ref Point pb)
        {
            for (int xt = p0.x - 1; xt <= p0.x + 1; xt++)
            {
                for (int yt = p0.y - 1; yt <= p0.y + 1; yt++)
                {
                    //排除超过边界和等于自身的点
                    if ((xt >= 0 && xt < 10 && yt >= 0 && yt < 10) && !(xt == p0.x && yt == p0.y))
                    {
                        //排除障碍点和关闭列表中的点
                        if (map[yt, xt] != 0 && !IsInCloseList(xt, yt))
                        {
                            if (IsInOpenList(xt, yt))
                            {
                                Point pt = GetPointFromOpenList(xt, yt);
                                int G_new = 0;
                                if (p0.x == pt.x || p0.y == pt.y) G_new = p0.G + 10;
                                else G_new = p0.G + 14;
                                if (G_new < pt.G)
                                {
                                    OpenList.Remove(pt);
                                    pt.father = p0;
                                    pt.G = G_new;
                                    OpenList.Add(pt);
                                }
                            }
                            else
                            {
                                //不在开启列表中
                                Point pt = new Point();
                                pt.x = xt;
                                pt.y = yt;
                                pt.father = p0;
                                pt.G = GetG(pt);
                                pt.H = GetH(pt, pb);
                                OpenList.Add(pt);
                            }
                        }
                    }
                }
            }
        }


        //发现路径
         public void FindWay(Point pa, Point pb)
        {

          OpenList .Add(pa);
          while (!(IsInOpenList(pb.x, pb.y) || OpenList.Count == 0))
            {
                Point p0 = GetMinFFromOpenList();
                if (p0 == null) return;
                OpenList.Remove(p0);
                CloseList.Add(p0);
                CheckP8(p0, R, pa, ref pb);
            }


            Point p = GetPointFromOpenList(pb.x, pb.y);
            while (p.father != null)
            {
                p = p.father;
                R[p.y, p.x] = 3;
            }

        }

        //保存路径
        public void SaveWay( Point pb)
        {

            Point p = pb;
            while (p.father != null)
            {
                p = p.father;
                R[p.y, p.x] = 3;
            }
        }

        public void PrintMap()
        {
            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    if (R[a, b] == 1) Console.Write("█");
                    else if (R[a, b] == 3) Console.Write("★");
                    else if (R[a, b] == 4) Console.Write("○");

                    else Console.Write("  ");
                }
                Console.Write("\n");
            }

        }
    }
}
