using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class Contact
    {
        /// <summary>
        /// Contact ID
        /// </summary>
        public int contact_id { get; set; }

        /// <summary>
        /// Address ID
        /// </summary>
        public int address_id { get; set; }

        /// <summary>
        /// Contacts Full Name
        /// </summary>
        public string full_name { get; set; }

        /// <summary>
        /// Contacts Phone Number
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// Contacts Cellphone Number
        /// </summary>
        public string cellphone { get; set; }

        /// <summary>
        /// Contacts Email Address
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// Name, Number, Email
        /// </summary>
        public string nice_contact { get; set; }
    }

    class ContactConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(List<Contact>);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // deserialize as object
            var roles = serializer.Deserialize<JObject>(reader);
            var result = new List<Contact>();

            // create an array out of the properties
            foreach (JProperty property in roles.Properties())
            {
                var address = property.Value.ToObject<Contact>();
                result.Add(address);
            }

            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
