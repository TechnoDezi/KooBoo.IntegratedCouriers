using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class GetAddressRequest
    {
        /// <summary>
        /// Address ID
        /// </summary>
        public int address_id { get; set; }

        /// <summary>
        /// Obtained after authenticating. Store it and use it in every function call. Tokens expire after 1 hour of inactivity. 
        /// </summary>
        public string token { get; set; }
    }

    public class GetAddressResponse:ColliveryResponseBase
    {
        public Address address { get; set; }
    }
}
