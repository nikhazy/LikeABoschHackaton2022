using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandling.Model.HostVehicle
{
    public class VehicleData
    {
        public double TimeStamp { get; set; }
        public double aX { get; set; }
        public double aY { get; set; }
        public double psiDtOpt { get; set; }
        public double tAbsRefTime { get; set; }
        public double vX { get; set; }
        public double vY { get; set; }

        public VehicleData(string[] input)
        {

            TimeStamp = double.Parse(input[0]);
            aX = double.Parse(input[1]) / 2048;
            aY = double.Parse(input[2]) / 2048;
            psiDtOpt = double.Parse(input[3]) / 16384;
            tAbsRefTime = double.Parse(input[4]);
            vX = double.Parse(input[5]) / 256;
            vY = double.Parse(input[6]) / 256;

        }
    }
}
