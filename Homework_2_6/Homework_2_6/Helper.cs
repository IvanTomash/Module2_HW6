using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_6
{
    /// <summary>
    /// Used for extensions.
    /// </summary>
    internal static class Helper
    {
        /// <summary>
        /// Sort by ascending.
        /// </summary>
        /// <param name="apartment">Represent an apartment.</param>
        public static void SortAppliancesByPower(this Apartment apartment)
        {
            for (int i = 0; i < apartment.ElectricalAppliances.Length; i++)
            {
                for (int j = 0; j < apartment.ElectricalAppliances.Length - 1; j++)
                {
                    if (apartment.ElectricalAppliances[j].Power > apartment.ElectricalAppliances[j + 1].Power)
                    {
                        IPowerCunsumer extra = apartment.ElectricalAppliances[j];
                        apartment.ElectricalAppliances[j] = apartment.ElectricalAppliances[j + 1];
                        apartment.ElectricalAppliances[j + 1] = extra;
                    }
                }
            }
        }

        /// <summary>
        /// Finds particulr appliance by a range of amperage.
        /// </summary>
        /// <param name="apartment">Represent an apartment.</param>
        /// <param name="minValue">Min value of amperage.</param>
        /// <param name="maxValue">Max value of amperage.</param>
        /// <returns>Appropriate item.</returns>
        public static IPowerCunsumer FindAppliancesByAmperage(this Apartment apartment, double minValue, double maxValue)
        {
            foreach (var app in apartment.ElectricalAppliances)
            {
                if (app.Amperage > minValue && app.Amperage < maxValue)
                {
                    return app;
                }
            }

            return null;
        }
    }
}
