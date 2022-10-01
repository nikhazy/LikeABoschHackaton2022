using DataHandling.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandling.Model.Cam
{
    public class Camera
    {
        public List<double> CameraTimeStamps { get; set; }
        public List<CameraObject> CameraObjects { get; set; }
        public List<Position> CameraPositions { get; set; }

        public Camera()
        {
            CameraTimeStamps = new List<double>();
            CameraPositions = new List<Position>();
            CameraObjects = new List<CameraObject>();
            for (int i = 0; i < 15; i++)
            {
                CameraObjects.Add(new CameraObject());
            }
        }
    }
}
