using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// Target --> Interface that the client want to use
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IJsonParser<T>
    {
        T Parse(string json);
        string ConvertToJson(T obj);
    }
}
