using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class ParcelType
    {
        /// <summary>
        /// Contains information about the Parcel Type
        /// </summary>
        public int parcel_type_id { get; set; }

        /// <summary>
        /// Name of Parcel Type
        /// </summary>
        public string type_text { get; set; }

        /// <summary>
        /// Parcel Type Description
        /// </summary>
        public string type_description { get; set; }
    }

    class ParcelTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(List<ParcelType>);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // deserialize as object
            var roles = serializer.Deserialize<JObject>(reader);
            var result = new List<ParcelType>();

            // create an array out of the properties
            foreach (JProperty property in roles.Properties())
            {
                int parcelID = int.Parse(property.Name);

                var parcelType = property.Value.ToObject<ParcelType>();
                parcelType.parcel_type_id = parcelID;
                result.Add(parcelType);
            }

            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
