using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class GetAddressesRequest
    {
        /// <summary>
        /// Obtained after authenticating. Store it and use it in every function call. Tokens expire after 1 hour of inactivity. 
        /// </summary>
        public string token { get; set; }

        /// <summary>
        /// (Optional)
        /// </summary>
        public GetAddressesRequestFilter filter { get; set; }
    }

    public class GetAddressesRequestFilter
    {
        /// <summary>
        ///  (Optional) Show only addresses where the company name contains company_name 
        /// </summary>
        public string company_name { get; set; }

        /// <summary>
        ///  (Optional) Show only addresses for this Town ID. 
        /// </summary>
        public int town_id { get; set; }

        /// <summary>
        /// (Optional) Show only addresses for this Suburb Name.
        /// </summary>
        public string suburb { get; set; }

        /// <summary>
        /// (Optional) Search for your Custom ID.
        /// </summary>
        public string custom_id { get; set; }
    }

    public class GetAddressesResponse:ColliveryResponseBase
    {
        /// <summary>
        /// Array containing all the addresses
        /// </summary>
        [JsonConverter(typeof(AddressConverter))]
        public List<Address> addresses { get; set; }
    }
}
