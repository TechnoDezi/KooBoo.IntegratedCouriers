using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class Price
    {
        /// <summary>
        /// Price of the Collivery excluding vat.
        /// </summary>
        public decimal ex_vat { get; set; }

        /// <summary>
        /// Price of the Collivery including vat.
        /// </summary>
        public decimal inc_vat { get; set; }

        /// <summary>
        /// Total vat paid for the Collivery
        /// </summary>
        public decimal vat { get; set; }

        /// <summary>
        /// The initial included weight.
        /// </summary>
        public decimal inc_weight { get; set; }

        /// <summary>
        /// Rate per Kilogram after the initial included weight.
        /// </summary>
        public decimal rate_per_kg { get; set; }
    }
}
