using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerticalsectionTest
{
    internal class Algo
    {
        
        public static double CalAngle(Point a,Point b) 
        {
            double dx=b.X-a.X;
            double dy=b.Y-a.Y;
            double angle=Math.Atan(dy/dx);
            angle=angle*(180/Math.PI);//象限角
            //return angle;
            if (dx == 0)
            {
                if (dy > 0)
                    angle = 90;
                else
                    angle = 270;
                return angle;
            }
            if (angle > 0 && angle < 90)
            {
                //angle = angle;
            }
            if (angle > 90 && angle < 180)
            {
                angle = angle +180;
            }
            if (angle > -90 && angle <0)
            {
                angle = angle+180;
            }
            if (angle < -90 && angle > -180)
            {
                angle = angle+360;
            }
            angle/=(180/Math.PI);
            return angle;
        }//返回弧度式角度
        public static double Distance(Point a,Point b)
        {
            double distance;
            double dx=a.X-b.X;
            double dy = a.Y-b.Y;    
            distance= Math.Sqrt(dx*dx+dy*dy);
            return distance;
        }//计算长度
        public static double CalHeight(int count,Point insPoint,List<Point> points)
        {
            double height;
            double hd=0, id=0;
            List<PointQ> QPointQList = new List<PointQ>();//离散点Q表
            foreach(Point p in points)
            {
                if(p==insPoint)
                {
                    continue;
                }
                PointQ pointQ = new PointQ();
                pointQ.Point = p;
                pointQ.Distance= Distance(pointQ.Point, insPoint);
                QPointQList.Add(pointQ);
            }//将所有点计算距离放入Q表
            QPointQList =QPointQList.OrderBy(t => t.Distance).Take(count).ToList();
            //对Q表进行排序，只取前5个Q值
            foreach(PointQ pointQ in QPointQList)
            {
                hd += pointQ.Point.H / pointQ.Distance;
                id += 1 / pointQ.Distance;
            }//计算高度参数
            height=hd/id;
            return height;
        }//计算插值点高度
        public static double CalArea(Point a,Point b,double h0)
        {
            double area = 0;
            area=(a.H+b.H-2*h0)/2*Algo.Distance(a,b);
            return area;
        }
    }
}
