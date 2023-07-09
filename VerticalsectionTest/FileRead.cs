using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerticalsectionTest
{
    internal class FileRead
    {
        public string headline = "";
        public double h0;
        public string[] keypoint = null;
        public List<Point> datapoints = new List<Point>();
        public List<Point> keypoints = new List<Point>();
        public void Read(string filename)
        {
            var reader = new StreamReader(filename, Encoding.Default);
            bool isK0 = true;
            
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (isK0)
                {
                    
                    var s=line.Split(',');
                    if (s[0] == "H0")
                    {
                        h0 = double.Parse(s[1].Trim());
                    }
                    if (s[0] == "K0"&&s[1]!="K1")
                        isK0 = false;
                    else
                    {
                        headline += line+"\n";
                        continue;
                    }
                        
                }
                Point data = new Point();
                if (line != null)
                {
                    data.Parse(line);
                    if (data.Name.StartsWith("K"))
                    {
                        keypoints.Add(data);
                    }
                    datapoints.Add(data);
                }
            }

            
        }
    }
}
