using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class Town
    {
        /// <summary>
        /// ID of the town
        /// </summary>
        public int town_id { get; set; }

        /// <summary>
        /// Name of the town
        /// </summary>
        public string town_name { get; set; }
    }

    class TownConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(List<Town>);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // deserialize as object
            var roles = serializer.Deserialize<JObject>(reader);
            var result = new List<Town>();

            // create an array out of the properties
            foreach (JProperty property in roles.Properties())
            {
                var town = new Town();
                town.town_id = int.Parse(property.Name);
                town.town_name = property.Value.ToString();
                result.Add(town);
            }

            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
