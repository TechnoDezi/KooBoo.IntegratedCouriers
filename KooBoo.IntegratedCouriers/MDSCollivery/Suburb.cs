using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class Suburb
    {
        /// <summary>
        /// ID of the suburb
        /// </summary>
        public int suburb_id { get; set; }

        /// <summary>
        /// Suburb Name
        /// </summary>
        public string suburb_name { get; set; }
    }

    class SuburbConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(List<Suburb>);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // deserialize as object
            var roles = serializer.Deserialize<JObject>(reader);
            var result = new List<Suburb>();

            // create an array out of the properties
            foreach (JProperty property in roles.Properties())
            {
                var suburb = new Suburb();
                suburb.suburb_id = int.Parse(property.Name);
                suburb.suburb_name = property.Value.ToString();
                result.Add(suburb);
            }

            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
