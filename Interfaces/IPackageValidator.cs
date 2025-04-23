using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid_Implmentation.Models;

namespace Solid_Implmentation.Interfaces
{
    public interface IPackageValidator
    {
        bool IsValid(Package package);
    }
}
