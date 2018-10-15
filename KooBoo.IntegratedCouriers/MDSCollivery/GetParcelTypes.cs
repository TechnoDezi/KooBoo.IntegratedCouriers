using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class GetParcelTypesRequest
    {
        /// <summary>
        /// Obtained after authenticating. Store it and use it in every function call. Tokens expire after 1 hour of inactivity. 
        /// </summary>
        public string token { get; set; }

    }

    public class GetParcelTypesResponse:ColliveryResponseBase
    {
        public List<ParcelType> parcelTypes { get; set; }
    }
}
