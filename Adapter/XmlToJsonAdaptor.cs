using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class XmlToJsonAdaptor<T> : IJsonParser<T>
    {
        public T Parse(string json)
        {
            IXmlParser<T> xmlParser = new XmlParser<T>();
            return xmlParser.Parse(json);   
        }
        public string ConvertToJson(T obj)
        {
           IJsonParser<T> jsonParser = new JsonParser<T>();
            return jsonParser.ConvertToJson(obj);
        }

        
    }
}
