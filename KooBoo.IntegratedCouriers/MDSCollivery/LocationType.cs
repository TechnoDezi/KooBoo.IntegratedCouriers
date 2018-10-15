using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class LocationType
    {
        /// <summary>
        /// the id of the location type
        /// </summary>
        public int locationtype_id { get; set; }

        /// <summary>
        /// the name of the location type
        /// </summary>
        public string locationtype_name { get; set; }
    }

    class LocationTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(List<LocationType>);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // deserialize as object
            var roles = serializer.Deserialize<JObject>(reader);
            var result = new List<LocationType>();

            // create an array out of the properties
            foreach (JProperty property in roles.Properties())
            {
                var locationType = new LocationType();
                locationType.locationtype_id = int.Parse(property.Name);
                locationType.locationtype_name = property.Value.ToString();
                result.Add(locationType);
            }

            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
