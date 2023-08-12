using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_6
{
    /// <summary>
    /// A place where appliances are located.
    /// </summary>
    internal sealed class Apartment
    {
        private IPowerCunsumer[] electricalAppliances;

        /// <summary>
        /// Initializes a new instance of the <see cref="Apartment"/> class.
        /// </summary>
        /// <param name="powerCunsumers">A list of appliances.</param>
        public Apartment(IPowerCunsumer[] powerCunsumers)
        {
            this.electricalAppliances = powerCunsumers;
        }

        /// <summary>
        /// Gets electricalAppliances.
        /// </summary>
        public IPowerCunsumer[] ElectricalAppliances
        {
            get
            {
                return this.electricalAppliances;
            }
        }

        /// <summary>
        /// Summarise the power consumption of all appliances.
        /// </summary>
        /// <returns>Totla power consumption.</returns>
        public double GetTotalPowerConsumptionPerHour()
        {
            double res = 0;
            foreach (var power in this.electricalAppliances)
            {
                res += power.GetPowerConsumption(1);
            }

            return res;
        }
    }
}
