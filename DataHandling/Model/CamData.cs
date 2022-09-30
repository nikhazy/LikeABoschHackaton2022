using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandling.Model
{
    public class CamData
    {
        public DateTime CameraTimeStamp { get; set; }
        public double dX { get; set; }
        public double dY { get; set; }
        public double vX { get; set; }
        public double vY { get; set; }
        public ObjectType ObjType { get; set; }

        public CamData(string[] inputs)
        {
            
        }

    }

    public enum ObjectType
    {
        NoDetection,
        Truck,
        Car,
        Motorbike,
        Bicycle,
        Pedestrian,
        CarOrTruck,
    }
}
