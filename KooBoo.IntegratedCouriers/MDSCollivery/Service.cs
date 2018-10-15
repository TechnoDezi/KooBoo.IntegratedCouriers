using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.MDSCollivery
{
    public class Service
    {
        /// <summary>
        /// the id of the service
        /// </summary>
        public int service_id { get; set; }

        /// <summary>
        /// the name of the service
        /// </summary>
        public string service_name { get; set; }
    }

    class ServiceConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(List<Service>);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // deserialize as object
            var roles = serializer.Deserialize<JObject>(reader);
            var result = new List<Service>();

            // create an array out of the properties
            foreach (JProperty property in roles.Properties())
            {
                var service = new Service();
                service.service_id = int.Parse(property.Name);
                service.service_name = property.Value.ToString();
                result.Add(service);
            }

            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
