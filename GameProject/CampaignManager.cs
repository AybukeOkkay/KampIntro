using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class CampaignManager : ICampaignService
	{
		public void Add(Campaign campaign)
		{
			Console.WriteLine(campaign.CampaignName + "Kampanya Eklendi");
			Console.WriteLine("Kampanya İndirimi : % "+ campaign.CampaignDiscount);
		}

		public void Delete(Campaign campaign)
		{
			Console.WriteLine(campaign.CampaignName + " Kampanya silindi");
		}

		public void Update(Campaign campaign)
		{
			Console.WriteLine(campaign.CampaignName + " Kampanya güncellendi");
			Console.WriteLine("Kampanya indirimi : %" + campaign.CampaignDiscount);
		}
	}
}
