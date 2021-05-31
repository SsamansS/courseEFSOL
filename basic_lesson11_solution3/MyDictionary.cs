using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson11_solution3
{
    class MyDictionary<TKey, TValue>
    {
        List<TKey> keys;

        List<TValue> values;

        public int Count;
        public TValue this[TKey key]
        {
            get
            {
                return values[LookForIndex(key)];
            }
        }

        public MyDictionary(int lenght)
        {
            this.Count = lenght;
            this.keys = new List<TKey>(lenght);
            this.values = new List<TValue>(lenght);
        }
        public MyDictionary()
        {
            this.Count = 1;
            this.keys = new List<TKey>(1);
            this.values = new List<TValue>(1);
        }


        public void Add(TKey key, TValue value)
        {
            this.keys.Add(key);
            this.values.Add(value);
            this.Count = values.Count;
        }

        int LookForIndex(TKey key)
        {
            int index = -1;
            for (int i = 0; i < Count; i++)
            {
                if ($"{this.keys[i]}" == $"{key}")
                    index = i;
            }
            
            return index;
        }

    }
}
