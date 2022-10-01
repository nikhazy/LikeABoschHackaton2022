using DataHandling.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandling.Model.Rad
{
    public class Radar
    {
        public string Name { get; set; }
        public List<double> RadarTimeStamp { get; set; }
        public List<RadarObject> RadarObjects { get; set; }
        public Position Position { get; set; }
        public Radar(string name, double x, double y, double z, double angleAzi, double angleEle)
        {
            Name = name;
            Position = new Position(x,y,z, angleAzi, angleEle);
            RadarTimeStamp = new List<double>();
            RadarObjects = new List<RadarObject>();
            for (int i = 0; i < 10; i++)
            {
                RadarObjects.Add(new RadarObject());
            }
        }
    }
}
