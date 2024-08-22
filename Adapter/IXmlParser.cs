using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// adapte --> Intergace that is not compatible with other interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IXmlParser<T>
    {
        T Parse(string xml);
        string ConvertToXML(T obj);
    }
}
