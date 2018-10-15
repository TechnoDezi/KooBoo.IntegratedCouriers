using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class GetSuburbsRequest
    {
        /// <summary>
        /// ID of the town to retrieve suburbs for. List of Towns can be obtained from the get_towns or search_towns function. 
        /// </summary>
        public int town_id { get; set; }

        /// <summary>
        /// Obtained after authenticating. Store it and use it in every function call. Tokens expire after 1 hour of inactivity. 
        /// </summary>
        public string token { get; set; }
    }

    public class GetSuburbsResponse:ColliveryResponseBase
    {
        /// <summary>
        /// Name of the town.
        /// </summary>
        public string town_name { get; set; }

        /// <summary>
        /// List of suburbs
        /// </summary>
        [JsonConverter(typeof(SuburbConverter))]
        public List<Suburb> suburbs { get; set; }
    }
}
