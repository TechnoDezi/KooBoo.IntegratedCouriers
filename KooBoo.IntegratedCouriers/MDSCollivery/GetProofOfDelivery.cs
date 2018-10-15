using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class GetProofOfDeliveryRequest
    {
        /// <summary>
        /// Waybill number for the requested POD.
        /// </summary>
        public int collivery_id { get; set; }

        /// <summary>
        /// Obtained after authenticating. Store it and use it in every function call. Tokens expire after 1 hour of inactivity. 
        /// </summary>
        public string token { get; set; }
    }

    public class GetProofOfDeliveryResponse:ColliveryResponseBase
    {
        /// <summary>
        /// Contains the POD and its information.
        /// </summary>
        public ProofOfDelivery pod { get; set; }
    }
}
