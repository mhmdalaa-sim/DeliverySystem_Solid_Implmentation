using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Implmentation.Models
{
    public class Delivery
    {
        public Driver Driver { get; set; }
        public Vehicle Vehicle { get; set; }
        public Package Package { get; set; }

        public override string ToString()
        {
            return $"Driver: {Driver.Name}, Vehicle: {Vehicle.GetVehicleType()}, Package: {Package.PackageId}, Destination: {Package.Destination}, Weight: {Package.WeightKg}kg";
        }
    }
}
