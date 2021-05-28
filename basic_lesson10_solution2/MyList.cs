using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson10_solution2
{
    class MyList<T>
    {
        T[] _List;
        int _Count;

        public int Count
        {
            get { return _Count; }
        }

        public T this[int index]
        {
            get
            {
                return _List[index];
            }
            set
            {
                _List[index] = value;
            }
        }

        public MyList(int count)
        {
            this._List = new T[count];
            this._Count = count;
        }
        public MyList()
        {
            this._List = new T[1];
            this._Count = 1;
        }
        public void Add(T NewItem)
        {
            T[] NewList = new T[_List.Length + 1];
            NewList[^1] = NewItem;
            this._List = NewList;
            this._Count = _List.Length;
        }
        public T GetItem(int index)
        {
            T Item = _List[index];
            return Item;
        }
        
    }
}
