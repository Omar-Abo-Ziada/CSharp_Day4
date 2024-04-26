using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class MyList<T> //where T : Employee //T : struct
    {
        T[] items;
        int currentIndex;

        public MyList() 
        {
            items = new T[5];
            currentIndex = -1;
        }

        public void Add(T item) 
        {
            //if(item == null)

            //item.

            if (currentIndex == items.Length - 1)
                Extende();

            currentIndex++;
            items[currentIndex] = item;
        }

        public T GetByIndex(int index)
        {
            return items[index];
        }

        private void Extende()
        {
            
        }
    }
}
