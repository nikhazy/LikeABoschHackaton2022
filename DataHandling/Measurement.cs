using DataHandling.Model.ADMA;
using DataHandling.Model.Cam;
using DataHandling.Model.Common;
using DataHandling.Model.HostVehicle;
using DataHandling.Model.Rad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandling
{
    public class Measurement
    {
        public static Measurement Instance { get; set; } = new Measurement();
        public List<double> TimeStamp { get; set; }
        public Camera Camera { get; set; }
        public List<Radar> Radars { get; set; }

        public AdmaModel Adma { get; set; }
        public Vehicle Vehicle { get; set; }
        public List<DetectionOverTime> SensorDetectonOverTimeList { get; set; }
        public Measurement()
        {
            TimeStamp = new List<double>();

            Vehicle = new Vehicle();
            Adma = new AdmaModel();
            Camera = new Camera();
            Radars = new List<Radar>();
            SensorDetectonOverTimeList = new List<DetectionOverTime>();

            Radars.Add(new Radar(DetectorDevice.FrontLeftRadar, 3473.8, 628.6, 515.6, 42, 0));
            Radars.Add(new Radar(DetectorDevice.RearLeftRadar, -766.4, 738, 735.9, 135, 0.48));
            Radars.Add(new Radar(DetectorDevice.FrontRightRadar, 3473.8, -628.6, 515.6, -42, 0));
            Radars.Add(new Radar(DetectorDevice.RearRightRadar, -766.4, -738, 735.9, -135, 0.48));
        }

        public void CollectSensorDetectionsOverTime()
        {
            for (int i = 0; i < TimeStamp.Count; i++)
            {

            }
        }
    }
}
