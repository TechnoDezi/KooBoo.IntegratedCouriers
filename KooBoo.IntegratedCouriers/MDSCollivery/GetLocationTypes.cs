using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class GetLocationTypesRequest
    {
        /// <summary>
        /// Obtained after authenticating. Store it and use it in every function call. Tokens expire after 1 hour of inactivity. 
        /// </summary>
        public string token { get; set; }
    }

    public class GetLocationTypesResponse:ColliveryResponseBase
    {
        /// <summary>
        /// List of location types (id => name)
        /// </summary>
        [JsonConverter(typeof(LocationTypeConverter))]
        public List<LocationType> results { get; set; }
    }
}
