using System;
using System.Collections.Generic;

namespace OOP3
{
	class Program
	{
		static void Main(string[] args)
		{
			IKrediManager IhtiyacKrediManager  = new IhtiyacKrediManager();
			IKrediManager TasitKrediManager  = new TasitKrediManager();
			IKrediManager KonutKrediManager  = new KonutKrediManager();
			IKrediManager EsnafKrediManager = new EsnafKrediManager();

			ILoggerService databaseLoggerService = new DatabaseLoggerService();
			ILoggerService fileLoggerService = new FileLoggerService();
			ILoggerService smsLoggerService = new SmsLoggerService();

			BasvuruManager basvuruManager = new BasvuruManager();
			basvuruManager.BasvuruYap(EsnafKrediManager, new List<ILoggerService> { new DatabaseLoggerService(),new SmsLoggerService()}  );

			List<IKrediManager> krediler = new List<IKrediManager>() { IhtiyacKrediManager,TasitKrediManager};
			//basvuruManager.KrediOnBilgilendirmesiYap(krediler);

		}
	}
}
