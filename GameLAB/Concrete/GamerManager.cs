using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLAB.Abstract;
using GameLAB.Entities;

namespace GameLAB.Concrete
{
    public class GamerManager : IGamerService
    {
        public GamerManager(IGamerCheckService gamerCheckService)
        {
        }

        public void Register(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncu sisteme kaydedildi!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncu güncellendi!");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncu sistemden silindi!");
        }
    }
}
