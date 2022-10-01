using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandling.Model.Rad
{
    public class Radar
    {
        public List<double> RadarTimeStamp { get; set; }
        public List<RadarObject> RadarObjects { get; set; }
        public Radar()
        {
            RadarTimeStamp = new List<double>();
            RadarObjects = new List<RadarObject>();
            for (int i = 0; i < 10; i++)
            {
                RadarObjects.Add(new RadarObject());
            }
        }
    }
}
