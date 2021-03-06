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

        public int Count { get; private set; }
        public TValue this[TKey key]
        {
            get
            {
                return values[LookingForIndex(key)];
            }
        }

        public MyDictionary(int lenght)
        {
            this.Count = lenght;
            this.keys = new List<TKey>(Count);
            this.values = new List<TValue>(Count);
        }
        public MyDictionary()
        {
            this.Count = 1;
            this.keys = new List<TKey>(Count);
            this.values = new List<TValue>(Count);
        }


        public void Add(TKey key, TValue value)
        {
            if (!keys.Contains(key))
            {
                this.keys.Add(key);
                this.values.Add(value);
                this.Count = values.Count;
            }
            else
                Console.WriteLine("Ключи должны быть уникальными");
        }

        int LookingForIndex(TKey key)
        {
            int index = -1;
            for (int i = 0; i < Count; i++)
            {
                if (key.Equals(values[i]))
                    index = i;
            }
            
            return index;
        }

    }
}
