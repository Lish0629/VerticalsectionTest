using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerticalsectionTest
{
    internal class Xsection
    {
        public Point ki1, ki2;
        public Point mPoint=new Point();
        public double mAngle;
        int delta=10;
        double h0;
        public List<Point> dataPoints=new List<Point>();
        public List<Point> insPoints=new List<Point>();
        public List<Point> allLine = new List<Point>();
        public Xsection() { }
        public Xsection(Point ki1, Point ki2,List<Point> points, double h0)
        {
            this.ki1 = ki1;
            this.ki2 = ki2;
            mPoint.X = (ki1.X + ki2.X) / 2;
            mPoint.Y = (ki1.Y + ki2.Y) / 2;
            mAngle = Algo.CalAngle(ki1, ki2) + Math.PI/2;
            /*MessageBox.Show($"{Algo.CalAngle(ki1, ki2)}!");
            MessageBox.Show(mAngle.ToString());*/
            dataPoints = points;
            mPoint.H = Algo.CalHeight(delta, mPoint, dataPoints);
            mPoint.Name = $"M{ki2.Name}";
            this.h0 = h0;
        }
        public List<Point> CreateInsPoint(int delta,int n)
        {
            
            for(int i=-n; i<=n; i++)
            {
                if (i == 0)
                {
                    allLine.Add(mPoint);
                    continue;
                }
                Point pt=new Point();
                pt.Name = $"M{i:D2}";
                MessageBox.Show(delta.ToString());
                pt.X = mPoint.X + i * delta * Math.Cos(mAngle);
                pt.Y = mPoint.Y + i * delta * Math.Sin(mAngle);
                pt.H = Algo.CalHeight(n, pt, dataPoints);
                insPoints.Add(pt);
                allLine.Add(pt);
            }
            return insPoints;
        }

        


    }
}
