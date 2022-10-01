using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandling.Model.Rad
{
    public class RadarData
    {
        public double aX { get; set; }
        public double aY { get; set; }
        public double dX { get; set; }
        public double dY { get; set; }
        public double dZ { get; set; }
        public double Prob1Obstacle { get; set; }
        public double vX { get; set; }
        public double vY { get; set; }

        public RadarData(string[] input)
        {
            int rawAX = Int32.Parse(input[0]);
            int rawAY = Int32.Parse(input[1]);
            int rawDX = Int32.Parse(input[2]);
            int rawDY = Int32.Parse(input[3]);
            int rawDZ = Int32.Parse(input[4]);
            int rawProb = Int32.Parse(input[5]);
            int rawVX = Int32.Parse(input[6]);
            int rawVY = Int32.Parse(input[7]);

            aX = (double)rawAX / 2048;
            aY = (double)rawAY / 2048;
            dX = (double)rawDX / 128;
            dY = (double)rawDY / 128;
            dZ = (double)rawDZ / 128;
            Prob1Obstacle = (double)rawProb / 128;
            vX = (double)rawVX / 256;
            vY = (double)rawVY / 256;
        }
    }
}
