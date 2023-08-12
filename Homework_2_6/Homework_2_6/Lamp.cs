using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_6
{
    /// <summary>
    /// Shines a light.
    /// </summary>
    internal class Lamp : IPowerCunsumer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Lamp"/> class.
        /// </summary>
        /// <param name="name">Name of the appliance.</param>
        /// <param name="power">Power of the appliance.</param>
        /// <param name="amperage">Amperage of the appliance.</param>
        public Lamp(string name, double power, double amperage)
        {
            this.Name = name;
            this.Power = power;
            this.Amperage = amperage;
        }

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
        double IPowerCunsumer.GetPowerConsumption(double time)
        {
            double powerConsumption = this.Power * time;
            return powerConsumption;
        }
    }
}
