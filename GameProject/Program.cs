using System;

namespace GameProject
{
	class Program
	{
		static void Main(string[] args)
		{
			GamerManager gamerManager = new GamerManager(new UserValidationManager());
			GameManager gameManager = new GameManager();
			CampaignManager campaignManager = new CampaignManager();

			Gamer gamer = new Gamer();
			gamer.FirstName = "Aybüke";
			gamer.LastName = "Okkay";
			gamer.Id = 1;
			gamer.BirthYear = 1998;
			gamer.IdentityNumber = 12345;

			Game game = new Game();
			game.GameName = "Mafia";
			game.GameCategory = "Tek oyuncu";
			game.GamePrice = 140;

			Campaign campaign = new Campaign();
			campaign.CampaignName = "Ogrenci Kampanyasi";
			campaign.CampaignDiscount = 40;

			gamerManager.Add(gamer);
			gameManager.Add(game);
			campaignManager.Add(campaign);

			GameSaleManager gameSaleManager = new GameSaleManager();
			gameSaleManager.Sale(gamer, game, campaign);
		}
	}
}
