using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandling.Model
{
    public class Camera
    {
        public static Camera Instance { get; set; } = new Camera();
        public List<DateTime> CameraTimeStamp { get; set; }
        public List<CameraObject> CameraObjects { get; set; }

        public Camera()
        {
            for (int i = 0; i < 15; i++)
            {
                CameraObjects.Add(new CameraObject());
            }
        }
    }
}
