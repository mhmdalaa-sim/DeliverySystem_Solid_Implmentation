using Solid_Implmentation.Interfaces;
using Solid_Implmentation.Models;
using Solid_Implmentation.Repositories;
using Solid_Implmentation.Services;
using Solid_Implmentation.Validators;

namespace Solid_Implmentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Setup
            IRepository<Delivery> deliveryRepo = new InMemoryRepository<Delivery>();
            IPackageValidator packageValidator = new PackageValidator();
            IDeliveryService deliveryService = new DeliveryService(deliveryRepo, packageValidator);

            // Sample Data
            var driver1 = new Driver { Id = 1, Name = "Alice Johnson" };
            var driver2 = new Driver { Id = 2, Name = "Bob Smith" };

            var truck = new Truck { LicensePlate = "TRK-1234" };
            var bike = new Bike { LicensePlate = "BIKE-5678" };

            var package1 = new Package { PackageId = "PKG001", Destination = "New York", WeightKg = 12.5 };
            var package2 = new Package { PackageId = "", Destination = "Nowhere", WeightKg = 0 }; // Invalid

            // Create Deliveries
            deliveryService.CreateDelivery(driver1, truck, package1);  // ✅ Valid
            deliveryService.CreateDelivery(driver2, bike, package2);   // ❌ Invalid

            Console.WriteLine("\n📦 All Deliveries:");
            foreach (var delivery in deliveryRepo.GetAll())
            {
                Console.WriteLine($"- {delivery}");
            }

            Console.WriteLine("\n✅ App finished. Press any key to exit...");
            Console.ReadKey();
        }
    }
}
