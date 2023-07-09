using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerticalsectionTest
{
    internal class Ysection
    {
        public Ysection() { }
        public double Length=0;
        public double Area = 0;
        public double H0 { get; set; }
        public Ysection(List<Point> keyPoint,List<Point> ppoints,double h0)
        {
            KeyPoint = keyPoint;//关键点表
            Ppoints = ppoints;//数据点表
            H0 = h0;
        }
        //keypoint是断面数据中的K0,K1值
        //ppoint是断面数据中的普通点
        public List<Point> Ppoints = new List<Point>();//数据点表
        public List<Point> InsPoints = new List<Point>();//插入点表
        public List<Point> KeyPoint = new List<Point>();//关键点表
        public List<Point> AllinLine=new List<Point>();//所有在纵截面上的点
        public void CreateInsPoint(int delta,int n)
        {
            int Count = Convert.ToInt32(Algo.Distance(KeyPoint[0], KeyPoint[KeyPoint.Count-1]))/delta;
            //计算插入点的个数
            int j = 0;
            AllinLine.Add(KeyPoint[0]);
            for(int i = 1; i <= Count; i++)
            {
                Point pt = new Point();
                pt.Name = $"V{i:D2}";
                pt.X = KeyPoint[j].X + (i * delta - Algo.Distance(KeyPoint[0], KeyPoint[j])) * Math.Cos(Algo.CalAngle(KeyPoint[j], KeyPoint[j+1]));
                pt.Y = KeyPoint[j].Y + (i * delta - Algo.Distance(KeyPoint[0], KeyPoint[j])) * Math.Sin(Algo.CalAngle(KeyPoint[j], KeyPoint[j + 1]));
                pt.H = Algo.CalHeight(n, pt, Ppoints);
                InsPoints.Add(pt);
                AllinLine.Add(pt);
                if (Algo.Distance(pt, KeyPoint[j+1]) < delta)
                {
                    j++;
                    AllinLine.Add(KeyPoint[j]);
                }
            }
            //计算插入点的坐标
            
        }
        public double CalYLength()
        {
            for(int i = 0; i < AllinLine.Count-1; i++)
            {
                Length += Algo.Distance(AllinLine[i], AllinLine[i + 1]);
            }
            return Length;
        }
        public double CalYArea()
        {
            for (int i = 0; i < AllinLine.Count - 1; i++)
            {
                Area += Algo.CalArea(AllinLine[i], AllinLine[i + 1],H0
                    
                    );
            }
            return Length;
        }
    }
}
