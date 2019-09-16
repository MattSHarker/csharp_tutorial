using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// This clas
namespace Generics
{
    public class MyList<T>  // the "<T>" says that the class has a generic type
    {
        private T[] items;  // use "T" as the type throughout the class where it is relevant
        
        public MyList()
        {
            items = new T[0];
        }

        public T GetItem(int index)
        {
            return items[index];
        }

        public void Add(T newItem)
        {
            T[] newItems = new T[items.Length + 1];

            for (int i = 0; i < items.Length; ++i)
                newItems[i] = items[i];

            newItems[newItems.Length - 1] = newItem;

            items = newItems;
        }
    }

}
