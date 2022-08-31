using System;
using GamePROJECT.Concrete;
using GamePROJECT.Entities;

namespace GamePROJECT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new ValidateManager());
            gamerManager.Register(new Gamer
            {
                Id = 1, 
                DateOfBirth = 2000,
                FirstName = "FATİH",
                LastName = "SELVİ",
                NationalityID = 222222,
            });
        }
    }
}
