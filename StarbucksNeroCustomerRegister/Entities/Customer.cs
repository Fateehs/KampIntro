using System;
using StarbucksNeroCustomerRegister.Abstract;

namespace StarbucksNeroCustomerRegister.Entities
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDateTime { get; set; }
        public string NationalityId { get; set; }
    }
}