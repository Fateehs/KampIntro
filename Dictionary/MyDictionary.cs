using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class MyDictionary<K,V>
    { 
        KeyValuePair<K,V>[] items;

        public MyDictionary() 
        {
            items = new KeyValuePair<K, V>[0];
        }

        public void Add(K _key, V _value)
        {
            KeyValuePair<K, V>[] tempArray = items;
            items = new KeyValuePair<K,V>[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = new KeyValuePair<K, V>();

            Console.WriteLine(items[items.Length-1]);
        }

        public void ListItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.Key + " = " + item.Value);
            }
        }

        public int Count
        {
            get { return items.Length; }
        }
      
    }
}
