using System;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> items = new MyDictionary<int, string>();
            items.Add(1,"Termos");
            items.Add(2,"Küllük");
            items.Add(3,"Su Şişesi");

            Console.WriteLine(items.Count);
            Console.WriteLine();
            items.ListItems();
        }
    }
}
