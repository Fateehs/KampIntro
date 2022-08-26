using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLAB.Abstract;
using GameLAB.Entities;

namespace GameLAB.Concrete
{
    public class SellManager:ISellService
    {
        public SellManager(Gamer gamer)
        {
        }
        public void Sell(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncuya " + game.DiscountedPrice + " fiyatına " + game.GameName + " adlı oyunu sattınız!");

        }
        public void Sell(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncuya " + campaign.CampaignName + " adlı kampanya ile " + game.GameName + " adlı oyunu " + campaign.CampaignDiscount + " indirimli olarak " + game.DiscountedPrice + " fiyatıyla sattınız!");
        }
    }
}
