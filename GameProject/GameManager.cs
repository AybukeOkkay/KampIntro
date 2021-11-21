using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class GameManager : IGameService
	{
		public void Add(Game game)
		{
			Console.WriteLine(game.GameName + " Eklendi\n" +
			   "Fiyat: " + game.GamePrice +
			   "\nKAtegori: " + game.GameCategory);
		}

		public void Delete(Game game)
		{
			Console.WriteLine(game.GameName + " silindi");
		}

		public void Update(Game game)
		{
			Console.WriteLine(game.GameName + " Güncellendi");
		}
	}
}
