using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLAB.Entities
{
    public class Campaign
    {
        public string CampaignId { get; set; }
        public string CampaignName { get; set; }
        public string CampaignGame { get; set; }
        public double CampaignDiscount { get; set; }
    }
}
