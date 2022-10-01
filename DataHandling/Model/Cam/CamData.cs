using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandling.Model.Cam
{
    public class CamData
    {
        //public DateTime CameraTimeStamp { get; set; }
        public double dX { get; set; }
        public double dY { get; set; }
        public ObjectType ObjType { get; set; }
        public double vX { get; set; }
        public double vY { get; set; }

        public CamData(string[] inputs)
        {
            //int rawTimeStamp = Int32.Parse(inputs[0]);
            int rawDX = Int32.Parse(inputs[0]);
            int rawDY = Int32.Parse(inputs[1]);
            int rawObjType = Int32.Parse(inputs[2]);
            int rawVX = Int32.Parse(inputs[3]);
            int rawVY = Int32.Parse(inputs[4]);

            dX = (double)rawDX / 128;
            dY = (double)rawDY / 128;
            vX = (double)rawVX / 256;
            vY = (double)rawVY / 256;

            ObjType = (ObjectType)rawObjType;
        }

    }

    public enum ObjectType
    {
        NoDetection = 0,
        Truck = 1,
        Car = 2,
        Motorbike = 3,
        Bicycle = 4,
        Pedestrian = 5,
        CarOrTruck = 6,
    }
}
