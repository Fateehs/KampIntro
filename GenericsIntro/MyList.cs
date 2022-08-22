using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        public MyList()//contructor
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; // geçici ref tutmak için
            items = new T[items.Length + 1]; // eleman sayısı olmadığı için array'e eleman sayısı yaratıyor
            for (int i = 0; i < tempArray.Length; i++) //geçici tutulan refleri almak için
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; //eklemek istediğin item burada eklenmiş oluyor
        }
        public int Lenght
        {
            get
            {
                return items.Length;
            }
        }
        public T[] Items
        {
            get
            {
                return items;
            }
        }
    }
}
