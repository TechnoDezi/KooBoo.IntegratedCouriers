using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class GetTownsRequest
    {
        /// <summary>
        /// Obtained after authenticating. Store it and use it in every function call. Tokens expire after 1 hour of inactivity. 
        /// </summary>
        public string token { get; set; }

        /// <summary>
        /// (optional) Get towns for a specific country. Defaults to South Africa (ZAF) if none is given. Uses ISO 3166-1 alpha-3 Standard 
        /// </summary>
        public string country { get; set; }

        /// <summary>
        ///  (optional) Filter towns for a specific province (South Africa only). CAP, EC, GAU, KZN, MP, NC, NP, NW, OFS 
        /// </summary>
        public string province { get; set; }
    }

    public class GetTownsResponse:ColliveryResponseBase
    {
        [JsonConverter(typeof(TownConverter))]
        public List<Town> towns { get; set; }
    }
}
