using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandling.Model.Rad
{
    public class RadarObject
    {
        public List<RadarData> RadarDatas { get; set; }
        public RadarObject()
        {
            RadarDatas = new List<RadarData>();
        }
    }
}
