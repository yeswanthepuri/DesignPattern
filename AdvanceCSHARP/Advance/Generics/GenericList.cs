using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.Generics
{
    /// <summary>
    /// Where T: IComparable
    /// Where T: product
    /// Where T: struck --> Value type
    /// Where T: class --> Reference type
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericList<T> where T : IComparable
    {
        private readonly List<T> list;
        public void Add(T item) { }
        public void Clear() { }
        public T this[int i] { get { return list[1]; } }
        public T Get(int index)
        {
            return list[index];
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
