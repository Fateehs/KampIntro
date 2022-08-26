using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using GameLAB.Abstract;
using GameLAB.Entities;

namespace GameLAB.Concrete
{
    public class GameManager:IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyunu ekledin!");
        }

        public void Remove(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyunu kaldırdın!");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyunu güncelledin!");
        }
    }
}
