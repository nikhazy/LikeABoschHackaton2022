using DataHandling.Model.Cam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandling.Model.Common
{
    public class DetectedObject
    {
        public double dX { get; set; }
        public double dY { get; set; }
        public double vX { get; set; }
        public double vY { get; set; }
        public ObjectType ObjType { get; set; }
        public DetectorDevice Device { get; set; }

        public DetectedObject(double dX, double dY, double vX, double vY, ObjectType objType, DetectorDevice detectorDevice)
        {
            this.dX = dX;
            this.dY = dY;
            this.vX = vX;
            this.vY = vY;
            ObjType = objType;
            Device = detectorDevice;
        }
    }
}
