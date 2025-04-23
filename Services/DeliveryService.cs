using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid_Implmentation.Interfaces;
using Solid_Implmentation.Models;

namespace Solid_Implmentation.Services
{
    public class DeliveryService : IDeliveryService
    {
        private readonly IRepository<Delivery> _deliveryRepository;

        private readonly IPackageValidator packageValidator;

        public DeliveryService(IRepository<Delivery> deliveryRepository, IPackageValidator packageValidator)
        {
            _deliveryRepository = deliveryRepository;
            this.packageValidator = packageValidator;
        }

        public void CreateDelivery(Driver driver, Vehicle vehicle, Package package)
        {
            if(!packageValidator.IsValid(package))
            {
                Console.WriteLine($"Package '{package.PackageId}' is invalid. Delivery aborted.");
                return;
            }

            var delivery = new Delivery
            {
                Driver = driver,
                Vehicle = vehicle,
                Package = package
            };

            _deliveryRepository.Add(delivery);

            Console.WriteLine("✅ Delivery Created:");
            Console.WriteLine(delivery);
        }
    }
}
