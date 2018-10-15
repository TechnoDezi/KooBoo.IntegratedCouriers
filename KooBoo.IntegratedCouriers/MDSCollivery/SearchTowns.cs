using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class SearchTownsRequest
    {
        /// <summary>
        /// Lookup Towns/Suburbs starting with town_name. Requires at least two characters before lookup is done.
        /// </summary>
        public string town_name { get; set; }

        /// <summary>
        /// Obtained after authenticating. Store it and use it in every function call. Tokens expire after 1 hour of inactivity. 
        /// </summary>
        public string token { get; set; }
    }

    public class SearchTownsResponse:ColliveryResponseBase
    {
        /// <summary>
        /// List of towns matching {town_name}
        /// </summary>
        [JsonConverter(typeof(TownConverter))]
        public List<Town> towns { get; set; }

        /// <summary>
        /// List of towns that have suburbs matching {town_name}
        /// </summary>
        [JsonConverter(typeof(TownConverter))]
        public List<Town> suburb_towns { get; set; }

        /// <summary>
        /// List of towns id's that have suburbs matching {town_name}
        /// </summary>
        [JsonConverter(typeof(SearchTownsSuburbsConverter))]
        public List<SearchTownsSuburbs> suburbs { get; set; }
    }

    public class SearchTownsSuburbs
    {
        /// <summary>
        /// the id of the town where the suburb matches town_name
        /// </summary>
        public int town_id { get; set; }

        /// <summary>
        /// the id of the suburb
        /// </summary>
        public int suburb_id { get; set; }

        /// <summary>
        /// The name of the suburb
        /// </summary>
        public string suburb_name { get; set; }
    }

    class SearchTownsSuburbsConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(List<SearchTownsSuburbs>);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // deserialize as object
            var roles = serializer.Deserialize<JObject>(reader);
            var result = new List<SearchTownsSuburbs>();

            // create an array out of the properties
            foreach (JProperty property in roles.Properties())
            {
                int townID = int.Parse(property.Name);

                foreach (JProperty propertyValue in property.Value.ToObject<JObject>().Properties())
                {
                    var town = new SearchTownsSuburbs();
                    town.town_id = townID;
                    town.suburb_id = int.Parse(propertyValue.Name);
                    town.suburb_name = propertyValue.Value.ToString();
                    result.Add(town);
                }
            }

            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
