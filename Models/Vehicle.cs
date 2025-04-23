using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Implmentation.Models
{
    public abstract class Vehicle
    {
        public string LiscencePlate { get; set; }

        public abstract string GetVehicleType();


    }

    public class Bike : Vehicle
    {
        public override string GetVehicleType()
        {
            return "Bike";

        }
    }

    public class Truck : Vehicle
    {
        public override string GetVehicleType() => "Bike";
      
    }
}
