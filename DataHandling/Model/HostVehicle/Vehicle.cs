using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandling.Model.HostVehicle
{
    public class Vehicle
    {
        public List<VehicleData> VehicleDatas { get; set; }
        public Vehicle()
        {
            VehicleDatas = new List<VehicleData>();
        }
    }
}
