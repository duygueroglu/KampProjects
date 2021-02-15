using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        //keep in memory
        //constructor, works automatically when class renewed
        public MyList()
        {
            //array created with 0 element
            items = new T[0];

        }
        public void Add(T item)
        {
            T[] tempArray = items; //tempArray, keep items's reference
            items = new T[items.Length + 1]; // new array created
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            //last added element
            items[items.Length - 1] = item;
        }
        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
    