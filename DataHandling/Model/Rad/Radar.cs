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
        public DetectorDevice Type { get; set; }
        public List<double> RadarTimeStamp { get; set; }
        public List<RadarObject> RadarObjects { get; set; }
        public Position Position { get; set; }
        public Radar(DetectorDevice type, double x, double y, double z, double angleAzi, double angleEle)
        {
            Type = type;
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
