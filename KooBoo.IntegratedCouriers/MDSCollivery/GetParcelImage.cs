using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class GetParcelImageRequest
    {
        /// <summary>
        /// Parcel ID for the requested image. Can be obtained by using the get_parcel_image_list function. 
        /// </summary>
        public string parcel_id { get; set; }

        /// <summary>
        /// Obtained after authenticating. Store it and use it in every function call. Tokens expire after 1 hour of inactivity. 
        /// </summary>
        public string token { get; set; }
    }

    public class GetParcelImageResponse:ColliveryResponseBase
    {
        public ParcelImage image { get; set; }
    }
}
