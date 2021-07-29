using System;

namespace ClassIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			string adi = "Aybüke";
			int yas = 23;

			Kurs kurs1 = new Kurs();
			kurs1.KursAdi = "c#";
			kurs1.Egitmen = "aybüke";
			kurs1.İzlemeOrani = 68;

			Kurs kurs2 = new Kurs();
			kurs2.KursAdi = "python";
			kurs2.Egitmen = "ayca";
			kurs2.İzlemeOrani = 62;

			Kurs kurs3 = new Kurs();
			kurs3.KursAdi = "c++";
			kurs3.Egitmen = "ayse";
			kurs3.İzlemeOrani = 48;

			//Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
			Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
			foreach (var kurs in kurslar)
			{
				Console.WriteLine(kurs.KursAdi+ ": " +kurs.Egitmen);
			}
		}
	}

	class Kurs
	{
		public string KursAdi { get; set; }
		public string Egitmen { get; set; }
		public int İzlemeOrani { get; set; }
	}
}