using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace VerticalsectionTest
{
    internal class Point
    {
        public string Name { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double H { get; set; }
        public Point(double x,double y)
        {
            X = x; Y = y;
        }
        public Point() { }
        public Point(string line)
        {
            var part = line.Split(',');
            Name = part[0];
            X = double.Parse(part[1].Trim());
            Y = double.Parse(part[2].Trim());
            H = double.Parse(part[3].Trim());
        }
        public void Parse(string line)
        {
            var part=line.Split(',');
            Name = part[0];
            X = double.Parse(part[1].Trim());
            Y = double.Parse(part[2].Trim());
            H = double.Parse(part[3].Trim());
        }
        public override string ToString()
        {
            string s;
            s = $"{Name},{X:f3},{Y:f3},{H:f3}\n";
            return s;
        }
    }
    internal class PointQ
    {
        public Point Point { get; set; }
        public double Distance { get; set; }
    }
}
