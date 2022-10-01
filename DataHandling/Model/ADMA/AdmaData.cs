using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandling.Model.ADMA
{
    public class AdmaData
    {
        public double TimeStamp { get; set; }
        public int HunterGpsMode { get; set; }
        public double LatDeltaDistance { get; set; }
        public double LatDeltaVelocity { get; set; }
        public double LongDeltaDistance { get; set; }
        public double LongDeltaVelocity { get; set; }

        public AdmaData(string[] input)
        {
            TimeStamp = double.Parse(input[0]);
            HunterGpsMode = Int32.Parse(input[1]);
            LatDeltaDistance = double.Parse(input[2]);
            LatDeltaVelocity = double.Parse(input[3]);
            LongDeltaDistance = double.Parse(input[4]);
            LongDeltaVelocity = double.Parse(input[5]);
        }
    }
}
