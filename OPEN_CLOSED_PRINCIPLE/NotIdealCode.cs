using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Open_Closed_Principle
{
	//Yanlış Kullanım
	class Garanti
	{
		public void ParaGonder(int tutar, string hesapno)
		{
			Console.WriteLine(hesapno + "Adlı Hesap No" + tutar + "Gonderildi");
		}
	}
	class Halkbank
	{
		string HesapNo;
		public void GonderılecekHesapNo(string hesapno)
		{
			HesapNo = hesapno;
		}
		public void Gonder(int tutar)
		{
			Console.WriteLine(HesapNo + "Adlı Hesap No" + tutar + "Gonderıldı");
		}
	}
}
