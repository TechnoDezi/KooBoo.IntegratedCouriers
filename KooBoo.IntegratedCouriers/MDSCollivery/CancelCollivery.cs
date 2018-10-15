using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class CancelColliveryRequest
    {
        /// <summary>
        /// ID of the Collivery you wish to Accept
        /// </summary>
        public int collivery_id { get; set; }

        /// <summary>
        /// Obtained after authenticating. Store it and use it in every function call. Tokens expire after 1 hour of inactivity. 
        /// </summary>
        public string token { get; set; }
    }

    public class CancelColliveryResponse : ColliveryResponseBase
    {
        public string success { get; set; }
    }
}
