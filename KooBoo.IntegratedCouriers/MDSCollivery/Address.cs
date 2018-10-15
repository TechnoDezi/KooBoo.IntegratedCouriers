using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class Address
    {
        /// <summary>
        /// Address ID
        /// </summary>
        public int address_id { get; set; }

        /// <summary>
        /// A Unique identifier you may use to search for this address or group a number of addresses together. 
        /// </summary>
        public string custom_id { get; set; }

        /// <summary>
        /// Your Client ID
        /// </summary>
        public int client_id { get; set; }

        /// <summary>
        /// ID of the Suburb for this address. List of Suburbs can be obtained from the get_suburbs or search_towns function. 
        /// </summary>
        public int suburb_id { get; set; }

        /// <summary>
        /// Address Suburb Name
        /// </summary>
        public string suburb_name { get; set; }

        /// <summary>
        /// Town ID of the town for this address. List of Towns can be obtained from the get_towns or search_towns function. 
        /// </summary>
        public int town_id { get; set; }

        /// <summary>
        /// Address Town Name
        /// </summary>
        public string town_name { get; set; }

        /// <summary>
        /// Address Location Type. The list of Location ID’s can be obtained from the get_location_types function. 
        /// </summary>
        public int location_type { get; set; }

        /// <summary>
        /// Company Name
        /// </summary>
        public string company_name { get; set; }

        /// <summary>
        /// Building Details
        /// </summary>
        public string building_details { get; set; }

        /// <summary>
        /// Street name and house number
        /// </summary>
        public string street { get; set; }

        /// <summary>
        /// (Deprecated) Support for legacy addresses that have name and number separate. This will not be supported in the next version. 
        /// </summary>
        public string street_name { get; set; }

        /// <summary>
        /// (Deprecated) Support for legacy addresses that have name and number separate. This will not be supported in the next version. 
        /// </summary>
        public string street_no { get; set; }

        /// <summary>
        /// The Nine South African Provinces (Only if South African address): CAP, EC, GAU, KZN, MP, NC, NP, NW, OFS 
        /// </summary>
        public string province { get; set; }

        /// <summary>
        /// Uses  ISO 3166-1 alpha-3 Standard. 
        /// </summary>
        public string country_brief { get; set; }

        /// <summary>
        /// Country Name
        /// </summary>
        public string country_name { get; set; }

        /// <summary>
        /// Surcharges added for address
        /// </summary>
        public decimal surcharge { get; set; }

        /// <summary>
        /// Company, Building Details, Street, Suburb, Town
        /// </summary>
        public string nice_address { get; set; }
    }

    class AddressConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(List<Address>);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // deserialize as object
            var roles = serializer.Deserialize<JObject>(reader);
            var result = new List<Address>();

            // create an array out of the properties
            foreach (JProperty property in roles.Properties())
            {
                var address = property.Value.ToObject<Address>();
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
