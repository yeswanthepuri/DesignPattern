using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Adapter
{
    public class JsonParser<T> : IJsonParser<T>
    {
        public string ConvertToJson(T obj)
        {
            return JsonSerializer.Serialize(obj,new JsonSerializerOptions { WriteIndented = true });
        }

        public T Parse(string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
