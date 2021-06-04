using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson11_solution2
{
    class CarCollection<T>
    {
        T[] Collection = new T[1];

        int _Count;
        public int Count { get { return _Count; } }

        public T this[int index]
        {
            get { return Collection[index]; }
            set { Collection[index] = value; }
        }
        public void Add(T car)
        {
            T[] _collection = new T[Collection.Length + 1];
            _collection[^1] = car;
            
            this.Collection = _collection;
            this._Count = Collection.Length;
        }
        public void Delete()
        {
            this.Collection = null;
        }
    }
}
