using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
	class SepetManager
	{ 
	
		//naming convention - yazım kuralı E büyük yazdık
		//syntax
		public void Ekle(Urun urun)
		{
		Console.WriteLine("tebrikler!! sepete eklendi :  "+urun.Adi);
		}
		public void Ekle2(string urunAdi,string Aciklama,double fiyat,int stokAdedi)
		{
			Console.WriteLine("Tebrikler.. Sepete eklendi: " +urunAdi);
		}
	}
}
