using System;

namespace KampIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			//type safety=tip güvenliği
			//Do not repeat yourself=kendini tekrarlama

			string kategoriEtiketi = "kategoriler";
			int ogrencıSayisi = 32000;
			double faizOrani = 1.45;
			bool sistemeGirisYapmisMi = true;
			double dolarDun = 7.45;
			double dolarBugun = 7.45;

			if (dolarDun>dolarBugun)
			{
				Console.WriteLine("Azalış butonu");
			}
			else if (dolarDun<dolarBugun)
			{
				Console.WriteLine("Artış butonu");
			}
			else
			{
				Console.WriteLine("değişmedi butonu");
			}

			if (sistemeGirisYapmisMi==true)
			{
				Console.WriteLine("Kullanıcı ayarları butonu");
			}
			else
			{
				Console.WriteLine("Giriş yap butonu");
			}

			Console.WriteLine(kategoriEtiketi);



		}
	}
}
