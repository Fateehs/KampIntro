using System;

namespace ReferenceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;

            num1 = num2;

            num2 = 100;

            Console.WriteLine(num1);

            Person person1 = new Person(); //101
            Person person2 = new Person(); //102
            person1.FirstName = "Fatih";

            person2 = person1; // 102 = 101
            person1.FirstName = "Selin";

            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            Employee employee = new Employee();


        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer : Person
        {
            public string CreditCardNumber { get; set; }
        }

        class Employee : Person
        {
            public int EmployeeNumber { get; set; }
        }
    }
}
