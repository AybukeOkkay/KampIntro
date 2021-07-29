using System;

namespace Metotlar
{
	class Program
	{
		static void Main(string[] args)
		{
			Urun urun1 = new Urun();
			urun1.Adi = "elme";
			urun1.Fiyati = 15;
			urun1.Aciklama = "Amasya elması";

			Urun urun2 = new Urun();
			urun2.Adi = "karpuz";
			urun2.Fiyati = 20;
			urun2.Aciklama = "Diyarbakır Karpuzu";

			Urun[] urunler = new Urun[] { urun1,urun2};

			//type safe=>tip güvenli
			foreach (Urun urun in urunler)
			{
				Console.WriteLine(urun.Adi);
				Console.WriteLine(urun.Fiyati);
				Console.WriteLine(urun.Aciklama);
				Console.WriteLine("------------------");
			}
			Console.WriteLine("---------------Metotlar----------");
			//instance - örnek
			//encapsulation - kapsülleme 

			SepetManager sepetManager = new SepetManager();
			sepetManager.Ekle(urun1);
			sepetManager.Ekle(urun2);

			sepetManager.Ekle2("Armut", "yeşil armut", 5,10);
			sepetManager.Ekle2("Elma", "yeşil elma", 12,9);
			sepetManager.Ekle2("karpuz", "tatlı karpuz", 15,8);
		}
	}
}
//Dont repeat yourself - DRY - Clean Code - Best Practice 