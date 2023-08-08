using System.Net.Http.Headers;

namespace Solid_Open_Closed_Principle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//OPEN CLOSED PRINCIPLE KISACA KODUN DEĞİŞTİRİLMESİNİ DEĞİL GENİŞLEMESİNİ ÖNEREN BİR PRENSİPTİR.

			#region YANLIŞ KULLANIM
			//Garanti garanti = new Garanti();
			//garanti.ParaGonder(1500,"TR004200400424242");

			//Halkbank halkbank = new Halkbank();
			//halkbank.GonderılecekHesapNo("TR230583215132");
			//halkbank.Gonder(3500);
			#endregion


			#region DOĞRU KULLANIM
			ParaGonderıcı paraGonderıcı = new ParaGonderıcı();
			paraGonderıcı.ParaGonder(new _Garanti(), 1500, "TR004200200550776");
			//paraGonderıcı.ParaGonder(new _Halkbank(),2500,"TR00500500024242214"); //PROJENİN DEĞİŞKENLİĞİNE GÖRE BU ŞEKİLDE KOLAYCA BANKAYI DEĞİŞTİREBİLİRİZ.

			//BU ŞEKİLDE ESKİ BANKAYI SİLİP YENİ BANKANIN KODLARINI YAZIP TEKRAR SİLİP TEKRAR YAZMADAN KAÇIP PROJEYİ GENİŞLETME UYGULAMASINA GİDİYORUZ VE BUNADA OPEN CLOSED PRİNCİPLE DENİLİYOR.

			Console.ReadLine();
			//---------------------------EKRAN ÇIKTISI------------------------------
			/*
			 TR004200200550776 Adlı Hesaba 1500 Para Gonderildi
             Garanti Bankası Tarafından Gönderildi.
			 */
			#endregion
		}
	}
}