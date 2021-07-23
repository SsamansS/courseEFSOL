using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_lesson10_solution2and4
{
  
    public class MyList<T> 
    {
        public T[] List;
        int _Count;

        public int Count
        {
            get { return _Count; }
        }

        public T this[int index]
        {
            get
            {
                return List[index];
            }
            set
            {
                List[index] = value;
            }
        }

        
           
    public MyList(int count)
        {
            this.List = new T[count];
            this._Count = count;
        }
        public MyList()
        {
            this.List = new T[1];
            this._Count = 1;
        }
        public void Add(T NewItem)
        {
            T[] NewList = new T[List.Length + 1];
            NewList[^1] = NewItem;
            this.List = NewList;
            this._Count = List.Length;
            
        }
        public T GetItem(int index)
        {
            T Item = List[index];
            return Item;
        }

    }
}
