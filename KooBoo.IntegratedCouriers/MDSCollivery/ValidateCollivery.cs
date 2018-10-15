using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class ValidateColliveryRequest
    {
        /// <summary>
        /// Contains all the information of the new Collivery.
        /// </summary>
        public ValidateColliveryRequestData data { get; set; }

        /// <summary>
        /// Obtained after authenticating. Store it and use it in every function call. Tokens expire after 1 hour of inactivity. 
        /// </summary>
        public string token { get; set; }
    }

    public class ValidateColliveryRequestData
    {
        /// <summary>
        /// Address ID where the parcel should be collected from. The list of Address ID’s can be obtained from the get_addresses function. 
        /// </summary>
        public int collivery_from { get; set; }

        /// <summary>
        /// Contact ID of the person from whom the parcel should be collected from. This is linked to the selected Address ID. The list of Contacts for a specific address can be obtained from the get_contacts function. 
        /// </summary>
        public int contact_from { get; set; }

        /// <summary>
        /// Address ID where the parcel should be delivered to. The list of Address ID’s can be obtained from the get_addresses function. 
        /// </summary>
        public int collivery_to { get; set; }

        /// <summary>
        /// Contact ID of the person from whom the parcel should be delivered to. This is linked to the selected Address ID. The list of Contacts for a specific address can be obtained from the get_contacts function. 
        /// </summary>
        public int contact_to { get; set; }

        /// <summary>
        /// ID of the Parcel Type from the get_parcel_types function.
        /// </summary>
        public int collivery_type { get; set; }

        /// <summary>
        /// ID of service type from the get_services function.
        /// </summary>
        public int service { get; set; }

        /// <summary>
        /// Let MDS Collivery carry the risk on this consignment up to a maximum of R5000.00. 1 for true, 0 for false. Defaults to 0.
        /// </summary>
        public int cover { get; set; }

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

    public class ValidateColliveryResponse:ColliveryResponseBase
    {
        /// <summary>
        /// Address ID where the parcel should be collected from. The list of Address ID’s can be obtained from the get_addresses function. 
        /// </summary>
        public int collivery_from { get; set; }

        /// <summary>
        /// Contact ID of the person from whom the parcel should be collected from. This is linked to the selected Address ID. The list of Contacts for a specific address can be obtained from the get_contacts function. 
        /// </summary>
        public int contact_from { get; set; }

        /// <summary>
        /// Address ID where the parcel should be delivered to. The list of Address ID’s can be obtained from the get_addresses function. 
        /// </summary>
        public int collivery_to { get; set; }

        /// <summary>
        /// Contact ID of the person from whom the parcel should be delivered to. This is linked to the selected Address ID. The list of Contacts for a specific address can be obtained from the get_contacts function. 
        /// </summary>
        public int contact_to { get; set; }

        /// <summary>
        /// ID of the Parcel Type from the get_parcel_types function.
        /// </summary>
        public int collivery_type { get; set; }

        /// <summary>
        /// Number to parcels for this Collivery. This should match the array count of the parcel dimensions array. 
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
        /// Let MDS Collivery carry the risk on this consignment up to a maximum of R5000.00. 1 for true, 0 for false. Defaults to 0.
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
        /// Unix Time for the time it will be delivered.
        /// </summary>
        public int delivery_time { get; set; }

        /// <summary>
        /// Was the time adjusted? 1 for true, 0 for false.
        /// </summary>
        public int time_changed { get; set; }

        /// <summary>
        /// The reason the time was changed.
        /// </summary>
        public string time_changed_reason { get; set; }

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
