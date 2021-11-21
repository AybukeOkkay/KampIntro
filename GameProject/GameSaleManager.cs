using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class GameSaleManager : IGameSaleService
	{
		public void Sale(Gamer gamer, Game game, Campaign campaign)
		{
			double newPrice = game.GamePrice - (game.GamePrice * (campaign.CampaignDiscount / 100));
			Console.WriteLine(game.GameName + " satildi " + gamer.FirstName + " " + gamer.LastName);
			Console.WriteLine("İndirimli fiyat : " + newPrice + " $");
		}
	}
}
