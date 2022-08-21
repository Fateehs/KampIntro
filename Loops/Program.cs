using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] courses = new string[]
                { "Software Development Camp", 
                    "Developer Camp", 
                    "JavaScript Camp",
                    "Python",
                    "C#"
                };
            // courses.Lenght courses'ın eleman sayısı kadar
            for (int i = 0; i < courses.Length; i ++)
            {
                Console.WriteLine(courses[i]);
            }

            Console.WriteLine("For bitti!");

            // arraylere uygulanır
            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("Footer!");
            Console.ReadLine();
        }
    }
}




