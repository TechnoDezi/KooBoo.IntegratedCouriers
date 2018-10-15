using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class ParcelImage
    {
        /// <summary>
        /// Size of the POD in bytes.
        /// </summary>
        public int size { get; set; }

        /// <summary>
        /// File mime
        /// </summary>
        public string mime { get; set; }

        /// <summary>
        /// File Name
        /// </summary>
        public string filename { get; set; }

        /// <summary>
        /// Parcel ID
        /// </summary>
        public string parcel_id { get; set; }

        /// <summary>
        /// Base64 encoded image
        /// </summary>
        public string file { get; set; }
    }

    class ParcelImageConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(List<ParcelImage>);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // deserialize as object
            var roles = serializer.Deserialize<JObject>(reader);
            var result = new List<ParcelImage>();

            // create an array out of the properties
            foreach (JProperty property in roles.Properties())
            {
                var address = property.Value.ToObject<ParcelImage>();
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
