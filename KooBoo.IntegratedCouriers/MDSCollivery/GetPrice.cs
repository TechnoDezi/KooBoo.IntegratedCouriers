using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class GetPriceRequest
    {
        /// <summary>
        /// Contains all the information of the Collivery to get a price for.
        /// </summary>
        public GetPriceRequestData data { get; set; }

        /// <summary>
        /// Obtained after authenticating. Store it and use it in every function call. Tokens expire after 1 hour of inactivity. 
        /// </summary>
        public string token { get; set; }
    }

    public class GetPriceRequestData
    {
        /// <summary>
        /// Address ID where the parcel should be collected from. The list of Address ID’s can be obtained from the get_addresses function. * Can be replaced with from_town_id and from_location_type. 
        /// </summary>
        public int collivery_from { get; set; }

        /// <summary>
        /// Town ID where the parcel should be collected from. The list of Town ID’s can be obtained from the get_towns function. * Can be replaced with collivery_from. 
        /// </summary>
        public int from_town_id { get; set; }

        /// <summary>
        /// Location Type where the parcel should be collected from. The list of Location Types can be obtained from the get_location_types function. * Can be replaced with collivery_from. 
        /// </summary>
        public int from_location_type { get; set; }

        /// <summary>
        /// Address ID where the parcel should be delivered to. The list of Address ID’s can be obtained from the get_addresses function. * Can be replaced with to_town_id and to_location_type. 
        /// </summary>
        public int collivery_to { get; set; }

        /// <summary>
        ///  Town ID where the parcel should be delivered to. The list of Town ID’s can be obtained from the get_towns function. * Can be replaced with collivery_to.  
        /// </summary>
        public int to_town_id { get; set; }

        /// <summary>
        /// Location Type where the parcel should be delivered to. The list of Location Types can be obtained from the get_location_types function. * Can be replaced with collivery_to. 
        /// </summary>
        public int to_location_type { get; set; }

        /// <summary>
        /// ID of the Parcel Type from the get_parcel_types function.
        /// </summary>
        public int collivery_type { get; set; }

        /// <summary>
        /// ID of service type from the get_services function.
        /// </summary>
        public int service { get; set; }

        /// <summary>
        /// Let MDS Collivery carry the risk on this consignment up to a maximum of R5000.00.  1 for true, 0 for false. Defaults to 0.
        /// </summary>
        public int cover { get; set; }

        /// <summary>
        /// Exclude Weekends to avoid additional surcharges. 1 for true, 0 for false. Defaults to 1.
        /// </summary>
        public int exclude_weekend { get; set; }

        /// <summary>
        /// (optional) Unix Time for the time it will be collected. The system will calculate and return the collection time if none is given. 
        /// </summary>
        public int collection_time { get; set; }

        /// <summary>
        /// (optional if parcel array is given) Number to parcels for this Collivery. This will be replaced with the array count in the parcel array. 
        /// </summary>
        public int parcel_count { get; set; }

        /// <summary>
        /// (optional if parcel array is given) Total weight of consignment rounded to 1 decimal point. This will be replaced with the weight sum of the weights in the parcel array. 
        /// </summary>
        public decimal weight { get; set; }

        /// <summary>
        /// (Highly recommended, as volumetric weight will be calculated using the parcel array. We can't give a final price without accurate dimensions of every parcel. Please contact integration@collivery.co.za for more information.) Contains the list of parcels for shipping 
        /// </summary>
        public List<Parcel> parcels { get; set; }
    }

    public class GetPriceResponse:ColliveryResponseBase
    {
        /// <summary>
        /// Address ID where the parcel should be collected from. The list of Address ID’s can be obtained from the get_addresses function. 
        /// </summary>
        public int collivery_from { get; set; }

        /// <summary>
        /// Town ID where the parcel should be collected from. The list of Town ID’s can be obtained from the get_towns function. Will be replaced by collivery_from. 
        /// </summary>
        public int from_town_id { get; set; }

        /// <summary>
        /// Location Type where the parcel should be collected from. The list of Location Types can be obtained from the get_location_types function. Will be replaced by collivery_from. 
        /// </summary>
        public int from_location_type { get; set; }

        /// <summary>
        /// Address ID where the parcel should be delivered to. The list of Address ID’s can be obtained from the get_addresses function. 
        /// </summary>
        public int collivery_to { get; set; }

        /// <summary>
        /// Town ID where the parcel should be delivered to. The list of Town ID’s can be obtained from the get_towns function. Will be replaced by collivery_to. 
        /// </summary>
        public int to_town_id { get; set; }

        /// <summary>
        /// Location Type where the parcel should be delivered to. The list of Location Types can be obtained from the get_location_types function. Will be replaced by collivery_to. 
        /// </summary>
        public int to_location_type { get; set; }

        /// <summary>
        /// ID of the Parcel Type from the get_parcel_types function.
        /// </summary>
        public int collivery_type { get; set; }

        /// <summary>
        ///  Number to parcels for this Collivery. This should match the array count of the parcel dimensions array.  
        /// </summary>
        public int parcel_count { get; set; }

        /// <summary>
        /// Total weight of consignment rounded to 1 decimal point
        /// </summary>
        public decimal weight { get; set; }

        /// <summary>
        /// ID of service type from the get_services function.
        /// </summary>
        public int service { get; set; }

        /// <summary>
        ///  Let MDS Collivery carry the risk on this consignment up to a maximum of R5000.00. 1 for true, 0 for false. Defaults to 0. 
        /// </summary>
        public int cover { get; set; }

        /// <summary>
        ///  This is used to calculate the Volumetric weight using (length*width*height)/vm_divisor 
        /// </summary>
        public int vm_divisor { get; set; }

        /// <summary>
        /// Volumetric weight. If the Volumetric weight is more than the actual weight, the volumetric weight will be used instead.
        /// </summary>
        public decimal vol_weight { get; set; }

        /// <summary>
        /// Unix Time for the time it will be collected.
        /// </summary>
        public int collection_time { get; set; }

        /// <summary>
        /// Contains different pricing information.
        /// </summary>
        public Price price { get; set; }

        /// <summary>
        /// Contains the list of parcels for shipping
        /// </summary>
        public List<Parcel> parcels { get; set; }
    }
}
