using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLAB.Entities;

namespace GameLAB.Abstract
{
    public interface IGamerService
    {
        void Register(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
