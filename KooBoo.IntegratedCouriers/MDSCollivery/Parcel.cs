using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class Parcel
    {
        /// <summary>
        /// The weight of the parcel in kg
        /// </summary>
        public decimal weight { get; set; }

        /// <summary>
        /// The height of the parcel in cm
        /// </summary>
        public decimal height { get; set; }

        /// <summary>
        /// The length of the parcel in cm
        /// </summary>
        public decimal length { get; set; }

        /// <summary>
        /// The width of the parcel in cm
        /// </summary>
        public decimal width { get; set; }

        /// <summary>
        /// The volumetric weight of the parcel in kg (returned afterwards)
        /// </summary>
        public decimal vol_weight { get; set; }
    }
}
