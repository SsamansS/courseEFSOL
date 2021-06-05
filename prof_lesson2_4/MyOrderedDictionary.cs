using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prof_lesson2_4
{
    class MyOrderedDictionary
    {
        OrderedDictionary dictionary = new OrderedDictionary();
        public List<object> Keys;
        public object this[object key]
        {
            get { return dictionary[key]; }
            set {
                Keys.Add(key);
                dictionary[key] = value; }
        }

        public bool Equals(ICollection key2)
        {
            if (this.dictionary.Keys == key2)
                return true;
            return false;
        }

        public int GetHashCode(object obj)
        {
            throw new NotImplementedException();
        }
        public void Add(object key, object value)
        {
            this.dictionary.Add(key, value);
            this.Keys.Add(key);
        }
    }
}
