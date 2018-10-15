using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class ColliveryStatus
    {
        /// <summary>
        /// Current Status ID
        /// </summary>
        public int status_id { get; set; }

        /// <summary>
        /// Current Status Text
        /// </summary>
        public string status_text { get; set; }

        /// <summary>
        /// Date of Delivery
        /// </summary>
        public string delivery_date { get; set; }

        /// <summary>
        /// Parcel will be delivered before this time.
        /// </summary>
        public string delivery_time { get; set; }

        /// <summary>
        /// Updated Date
        /// </summary>
        public string updated_date { get; set; }

        /// <summary>
        /// Updated Time
        /// </summary>
        public string updated_time { get; set; }

        /// <summary>
        /// The Total Price for this Collivery.
        /// </summary>
        public decimal total_price { get; set; }

        /// <summary>
        /// Latitude co-ordinate of the collection address.
        /// </summary>
        public decimal collection_latitude { get; set; }

        /// <summary>
        /// Longitude co-ordinate of the collection address.
        /// </summary>
        public decimal collection_longitude { get; set; }

        /// <summary>
        /// Latitude co-ordinate of the delivery address.
        /// </summary>
        public decimal delivery_latitude { get; set; }

        /// <summary>
        /// Longitude co-ordinate of the delivery address.
        /// </summary>
        public decimal delivery_longitude { get; set; }

        /// <summary>
        /// Unix timestamp for Estimated Time of Arrival.
        /// </summary>
        public int eta { get; set; }

        /// <summary>
        /// Date Time String for Estimated Time of Arrival.
        /// </summary>
        public string eta_text { get; set; }
    }
}
