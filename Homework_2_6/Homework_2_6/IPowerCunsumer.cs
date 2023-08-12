using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_6
{
    /// <summary>
    /// Appliances which consume electrical power.
    /// </summary>
    internal interface IPowerCunsumer
    {
        /// <summary>
        /// Gets name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets power.
        /// </summary>
        public double Power { get; }

        /// <summary>
        /// Gets amperage.
        /// </summary>
        public double Amperage { get; }

        /// <summary>
        /// Calculate power consumption.
        /// </summary>
        /// <param name="time">In hours.</param>
        /// <returns>Value of power consumption.</returns>
        double GetPowerConsumption(double time);
    }
}
