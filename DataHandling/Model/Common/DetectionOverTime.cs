using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandling.Model.Common
{
    public class DetectionOverTime
    {
        public List<DetectedObject> DetectedObjectsOnSensors { get; set; }
        public DetectionOverTime()
        {
            DetectedObjectsOnSensors = new List<DetectedObject>();
        }
    }
}
