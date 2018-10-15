using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class AddContactRequest
    {
        public AddContactRequestData data { get; set; }

        /// <summary>
        /// Obtained after authenticating. Store it and use it in every function call. Tokens expire after 1 hour of inactivity. 
        /// </summary>
        public string token { get; set; }
    }

    public class AddContactRequestData
    {
        /// <summary>
        /// Address ID you wish to add a contact for.
        /// </summary>
        public int address_id { get; set; }

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

    public class AddContactResponse:ColliveryResponseBase
    {
        /// <summary>
        /// Contact ID
        /// </summary>
        public int contact_id { get; set; }
    }
}
