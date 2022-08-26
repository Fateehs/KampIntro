using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLAB.Abstract;
using GameLAB.Entities;

namespace GameLAB.Concrete
{
    public class CampaignManager:ICampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adlı kampanya sisteme eklenmiştir!");
        }

        public void RemoveCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adlı kampanya sistemden kaldırılmıştır!");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adlı kampanya güncellenmiştir!");
        }
    }
}
