using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandling.Model.Common
{
    public class Position
    {
        public double PosX { get; set; }
        public double PosY { get; set; }
        public double PosZ { get; set; }
        public double AngleAzi { get; set; }
        public double AngleEle { get; set; }

        public Position(double posX, double posY, double posZ, double angleAzi, double angleEle)
        {
            PosX = posX;
            PosY = posY;
            PosZ = posZ;
            AngleAzi = angleAzi;
            AngleEle = angleEle;
        }

        public Position(string[] input)
        {
            PosX = double.Parse(input[0]);
            PosY = double.Parse(input[1]);
            PosZ = double.Parse(input[2]);
        }
    }
}
