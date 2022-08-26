using System;
using GameLAB.Concrete;
using GameLAB.Entities;

namespace GameLAB
{
    public class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            Gamer gamer1 = new Gamer()
            {
                DateOfBirth = new DateTime(2000, 9, 13), FirstName = "Fatih", LastName = "Selvi",
                NationalityId = "18214048794"
                
            };
            gamerManager.Register(gamer1);

            SellManager sellManager = new SellManager(new Gamer());
            Game game1 = new Game()
            {
                DiscountedPrice = 49.99, GameName = "Diablo", GamePrice = 79.99
            };
            Game game2 = new Game()
            {
                DiscountedPrice = 499.99,GameName = "FIFA2029", GamePrice = 799.99
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.AddCampaign(new Campaign { CampaignDiscount = 25, CampaignName = "%25'e varan yaz fırsatları!", CampaignGame = "FIFA2024", CampaignId = "1" });

            Campaign campaign1 = new Campaign{CampaignDiscount = 75, CampaignName = "%75'e varan yaz fırsatları!",CampaignGame = "FIFA2029", CampaignId = "2"};

            sellManager.Sell(gamer1,game1);
            
            sellManager.Sell(gamer1,game2,campaign1);
        }
    }
}
