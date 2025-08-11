using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.Generics
{
    public class GenericValueType<T> where T : struct
    {
        private T? _value;

        public GenericValueType()
        {
           
        }
        public void Nullable(T val)
        {
            _value = val;
        }

        public Boolean HasValue
        {
            get { return _value != null; }
        }
        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }

    }
}
