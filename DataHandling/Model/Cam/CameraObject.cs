using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandling.Model.Cam
{
    public class CameraObject
    {
        public List<CamData> CameraDatas { get; set; }
        public CameraObject()
        {
            CameraDatas = new List<CamData>();
        }
    }
}
