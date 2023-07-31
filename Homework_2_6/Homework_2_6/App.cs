using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_6
{
    /// <summary>
    /// Starter class.
    /// </summary>
    internal sealed class App
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        public App()
        {
        }

        /// <summary>
        /// Run the application.
        /// </summary>
        public void Run()
        {
            Apartment apartment = new Apartment(new IPowerCunsumer[]
            {
                new Toaster("Toater", 1100, 5),
                new Television("Television", 125, 0.6),
                new Microwave("Microwave", 800, 4),
                new Lamp("Lamp", 100, 0.4),
                new Kettle("Kettle", 2000, 9),
                new EconomicLamp("EcoLamp", 20, 0.1),
            });

            foreach (var item in apartment.ElectricalAppliances)
            {
                Console.WriteLine($"Name:\t{item.Name}\nPower:\t{item.Power}\nAmperage:\t{item.Amperage}");
            }

            Console.WriteLine("After sorting:");
            apartment.SortAppliancesByPower();
            foreach (var item in apartment.ElectricalAppliances)
            {
                Console.WriteLine($"Name:\t{item.Name}\nPower:\t{item.Power}\nAmperage:\t{item.Amperage}");
            }

            Console.WriteLine("Find by amperage:\t" + apartment.FindAppliancesByAmperage(3, 6).Name);
            Console.WriteLine("Total power consumption:" + apartment.GetTotalPowerConsumptionPerHour());
        }
    }
}
