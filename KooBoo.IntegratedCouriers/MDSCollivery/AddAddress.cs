using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class AddAddressRequest
    {
        /// <summary>
        /// Object containing the information for the address.
        /// </summary>
        public AddAddressRequestData data { get; set; }

        /// <summary>
        /// Obtained after authenticating. Store it and use it in every function call. Tokens expire after 1 hour of inactivity. 
        /// </summary>
        public string token { get; set; }
    }

    public class AddAddressRequestData
    {
        /// <summary>
        /// (Recommended) Company Name. Defaults to {full_name}
        /// </summary>
        public string company_name { get; set; }

        /// <summary>
        /// (Optional) Building name or extra information
        /// </summary>
        public string building { get; set; }

        /// <summary>
        /// Street name and house number
        /// </summary>
        public string street { get; set; }

        /// <summary>
        /// Location Type ID. Due to some types of deliveries incurring surcharges (eg. Government Buildings / Embassies / Farms / Plots), it is important to know, up front, the type of address we will be delivering to. The list of Location ID’s can be obtained by the get_location_types function. 
        /// </summary>
        public int location_type { get; set; }

        /// <summary>
        /// ID of the Suburb for this address. The Suburb MUST belong to the given town. List of Suburbs can be obtained from the get_suburbs or search_towns function. 
        /// </summary>
        public int suburb_id { get; set; }

        /// <summary>
        /// Town ID of the town for this address. List of Towns can be obtained from the get_towns or search_towns function. 
        /// </summary>
        public int town_id { get; set; }

        /// <summary>
        /// (optional) Country the address is in. Defaults to South Africa (ZAF) if none is given. Uses ISO 3166-1 alpha-3 Standard. 
        /// </summary>
        public string country { get; set; }

        /// <summary>
        /// (Optional) Address Zip/Postal Code
        /// </summary>
        public string zip_code { get; set; }

        /// <summary>
        /// (optional) A Unique identifier you may use to search for this address or group a number of addresses together. 
        /// </summary>
        public string custom_id { get; set; }

        /// <summary>
        /// Contact person's full name and surname.
        /// </summary>
        public string full_name { get; set; }

        /// <summary>
        /// Contact person's phone number.
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// Contact person's cellphone number.
        /// </summary>
        public string cellphone { get; set; }

        /// <summary>
        /// Contact person's email address. This is VERY Important if you need MDS Collivery to send the standard email notifications to the contact of pending delivery request. 
        /// </summary>
        public string email { get; set; }
    }

    public class AddAddressResponse:ColliveryResponseBase
    {
        /// <summary>
        /// Address ID
        /// </summary>
        public int address_id { get; set; }

        /// <summary>
        /// Contact ID
        /// </summary>
        public int contact_id { get; set; }
    }
}
