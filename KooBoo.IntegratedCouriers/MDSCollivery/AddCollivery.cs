using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class AddColliveryRequest
    {
        /// <summary>
        /// Should contain the array returned by the validate function WITHOUT any changes! If you need to make adjustments to the information, first re-validate it before passing it to the add_collivery function. 
        /// </summary>
        public AddColliveryRequestData data { get; set; }

        /// <summary>
        /// Obtained after authenticating. Store it and use it in every function call. Tokens expire after 1 hour of inactivity. 
        /// </summary>
        public string token { get; set; }
    }

    public class AddColliveryRequestData
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

        /// <summary>
        /// (Optional, Not Recommended) Do not check if anything (Time, Pricing, Information) changed since previous validation. This should only be used if you do not care about the information returned by the validate function. 
        /// </summary>
        public int ignore_validation_change { get; set; }

        /// <summary>
        /// (optional) Customer reference number. 
        /// </summary>
        public string cust_ref { get; set; }

        /// <summary>
        /// (optional) Alternative waybill number for tracking parcel using clients waybill number. Should start with an Alpha Character. 
        /// </summary>
        public string custom_id { get; set; }

        /// <summary>
        /// (optional) Extra instructions a user might want to provide. 
        /// </summary>
        public string instructions { get; set; }
    }

    public class AddColliveryResponse:ColliveryResponseBase
    {
        /// <summary>
        /// ID of the Collivery. Store it for later use.
        /// </summary>
        public int collivery_id { get; set; }

        /// <summary>
        /// Unix Time for the time it will be collected.
        /// </summary>
        public int collection_time { get; set; }

        /// <summary>
        /// Unix Time for the time it will be delivered.
        /// </summary>
        public int delivery_time { get; set; }

        /// <summary>
        /// Total weight of consignment rounded to 1 decimal point
        /// </summary>
        public decimal weight { get; set; }

        /// <summary>
        /// Volumetric weight. If the Volumetric weight is more than the actual weight, the volumetric weight will be used instead.
        /// </summary>
        public decimal vol_weight { get; set; }

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
