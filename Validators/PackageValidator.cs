using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid_Implmentation.Interfaces;
using Solid_Implmentation.Models;

namespace Solid_Implmentation.Validators
{
    public class PackageValidator:IPackageValidator
    {
        public bool IsValid(Package package)
        {
            if (string.IsNullOrWhiteSpace(package.PackageId)) return false;
            if (string.IsNullOrWhiteSpace(package.Destination)) return false;
            if (package.WeightKg <= 0) return false;
            return true;
        }
    }
}
