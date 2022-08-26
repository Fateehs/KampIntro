using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLAB.Abstract;
using GameLAB.Entities;

namespace GameLAB.Concrete
{
    public class GamerCheckManager:IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
