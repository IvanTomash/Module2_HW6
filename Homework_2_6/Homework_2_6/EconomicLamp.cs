using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_6
{
    /// <summary>
    /// shine a light but economicaly.
    /// </summary>
    internal sealed class EconomicLamp : Lamp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EconomicLamp"/> class.
        /// </summary>
        /// <param name="name">Name of the appliance.</param>
        /// <param name="power">Power of the appliance.</param>
        /// <param name="amperage">Amperage of the appliance.</param>
        public EconomicLamp(string name, double power, double amperage)
            : base(name, power, amperage)
        {
        }
    }
}
