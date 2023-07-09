using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VerticalsectionTest
{
    public partial class Form1 : Form
    {
        List<Point> dataPoints = new List<Point>();//所有数据点
        List<Point> keyPoints = new List<Point>();//所有K关键点
        double h0 = 0;
        int delta = 10;
        string filename = "";
        Ysection ysection = new Ysection();
        Xsection xsection = new Xsection();
        List<Xsection> xsections = new List<Xsection>();
        public Form1()
        {
            InitializeComponent();
        }

        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FileRead fileRead = new FileRead();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                fileRead.Read(openFileDialog1.FileName);
                dataPoints = fileRead.datapoints;
                keyPoints = fileRead.keypoints;
                h0 = fileRead.h0;
            }
            richTextBox2.Text = fileRead.headline;
            foreach(Point p in dataPoints)
            {
                richTextBox2.Text += p.ToString();
            }
        }
        private void 计算设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void 生成插值点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename == null)
            {
                MessageBox.Show("未导入数据");
                return;
            }
            if (xsection.allLine.Count == 0)
            {
                richTextBox2.Text = "";
            }
            ysection = new Ysection(keyPoints,dataPoints,h0);
            ysection.CreateInsPoint(delta, 5);
            richTextBox2.Text = "";
            foreach(Point p in ysection.AllinLine)
            {
                richTextBox2.Text += p.ToString();
            }
        }//纵截面

        

        

        public void 生成纵截面图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Series areaSeries = new Series("纵截面");
            areaSeries.ChartType = SeriesChartType.Line;
            chart1.Series.Add(areaSeries);
            chart1.Titles.Add("纵截面图");
            chart1.ChartAreas[0].AxisX.Title = "距K0距离";
            chart1.ChartAreas[0].AxisY.Title = "高度";
            areaSeries.Points.AddXY(0, keyPoints[0].H);
            
            foreach (Point point in ysection.InsPoints)
            {
                areaSeries.Points.AddXY(Math.Round(Algo.Distance(point, keyPoints[0])),point.H);
            }
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*Point point = new Point();
            foreach(Point p in dataPoints)
            {
                if (p.Name == "K1")
                {
                    point = p;
                }
            }
            double s = Algo.CalHeight(5, point, dataPoints);
            MessageBox.Show($"{s}");*/
            //Point a = new Point(-2, 2);
            //Point b = new Point(0,0);
            // double s=Algo.CalAngle1(a,b);
            //MessageBox.Show($"{s}"); 
            Point point = new Point();
            Point point1 = new Point();
            Point point2 = new Point();
            point = keyPoints[0];
            point1 = keyPoints[1];
            point2 = keyPoints[2];
            MessageBox.Show($"{Algo.CalAngle(point, point1)},{Algo.CalAngle(point1, point2)}");
        }

        public void 计算纵断面长度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ysection.CalYLength();
            richTextBox2.Text += "---------纵断面长度---------\n" ;
            richTextBox2.Text += $"纵断面长度：{Math.Round(ysection.Length,3)}\n";
        }

        private void 计算纵截面面积ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ysection.CalYArea();
            richTextBox2.Text += "---------纵断面面积---------\n";
            richTextBox2.Text += $"纵断面面积：{Math.Round(ysection.Area, 3)}\n";
        }

        private void 生成插值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delta = 5;
            if ( filename == null)
            {
                MessageBox.Show("未导入数据");
                return;
            }
            if (ysection.AllinLine.Count == 0)
            {
                richTextBox2.Text = "";
            }
            for (int i = 0; i < keyPoints.Count - 1; i++)
            {
                xsection = new Xsection(keyPoints[i], keyPoints[i+1], dataPoints, h0);
                xsection.CreateInsPoint(delta, 5);
                xsections.Add(xsection);    
            }
            foreach(Xsection xsection in xsections)
            {
                richTextBox2.Text += $"========横截面{xsection.mPoint.Name}========\n";
                foreach(Point x in xsection.allLine)
                {
                    richTextBox2.Text += x.ToString();
                }
            }
         
            
            
            
        }//横截面

        private void 生成ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
