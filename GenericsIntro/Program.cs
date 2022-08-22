using System;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Fatih");

            Console.Write(names.Lenght);

            names.Add("Selin");

            Console.WriteLine(names.Lenght);

            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }

        }
    }
}
