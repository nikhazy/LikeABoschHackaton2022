using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandling.Model.Cam
{
    public class CameraMountingPosition
    {
        public double PosXCam { get; set; }
        public double PosYCam { get; set; }
        public double PosZCam { get; set; }

        public CameraMountingPosition(string[] input)
        {

        }
    }
}
