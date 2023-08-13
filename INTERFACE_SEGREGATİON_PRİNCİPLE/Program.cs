namespace Interface_Segregation_Principle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region NOTIDEALCODE
			Printer hpprinter = new HPPrinter();
			hpprinter.Print();
			hpprinter.Fax();
			hpprinter.Scan();
			hpprinter.PrintDuplex();

			Printer samsungprinter = new SamsungPrinter();
			samsungprinter.PrintDuplex(); //Desteklemiyor ama yazabiliyoruz ve bu hatalara önayak hazırlıyor.(SOLİD PRENSİPLERİNDE BULUNAN INTERFACE_SEGREGATİON PRENSİBİNE AYKIRI AYNI ZAMANDA LİSKOV PRENSİBİNEDE AYKIRIDIR.
			samsungprinter.Fax();
			samsungprinter.Scan(); //Desteklemiyor ama yazabiliyoruz ve bu hatalara önayak hazırlıyor.(SOLİD PRENSİPLERİNDE BULUNAN INTERFACE_SEGREGATİON PRENSİBİNE AYKIRI AYNI ZAMANDA LİSKOV PRENSİBİNEDE AYKIRIDIR.
			samsungprinter.Print();

			Printer lexmarkprinter = new LexmarkPrinter();
			lexmarkprinter.Print();
			lexmarkprinter.Fax();
			lexmarkprinter.Scan();
			lexmarkprinter.PrintDuplex(); //Desteklemiyor ama yazabiliyoruz ve bu hatalara önayak hazırlıyor.(SOLİD PRENSİPLERİNDE BULUNAN INTERFACE_SEGREGATİON PRENSİBİNE AYKIRI AYNI ZAMANDA LİSKOV PRENSİBİNEDE AYKIRIDIR.
			#endregion

			//ISP(INTERFACE SEGREGATİON PRİNCİPLE) DAHA ÇOK GEREKSİZ METOTLARI VEYA ÖZELLİKLERİ ALMAMASINI SAĞLAR.LSP İSE SINIF MİRASI VE POLİMORFİZM KAVRAMLARINA ODAKLANIR.

			#region IDEALCODE

			SamsungPrinter2 samsungprinter2 = new();
			samsungprinter2.Print();
			samsungprinter2.Fax();
			//BURADA SADECE SAMSUNG PRİNTER'A AİT İŞLEVLERİ ÇAĞIRABİLİYORUZ.DİĞER İŞLEVLER SAMSUNG PRİNTER'DA BULUNMADIĞI İÇİN ÇAĞIRAMIYORUZ.

			LexmarkPrinter2 lexmarkprinter2 = new();
			lexmarkprinter2.Print();
			lexmarkprinter2.Fax();
			lexmarkprinter2.Scan();
			//BURADA SADECE LEXMARK PRİNTER'A AİT İŞLEVLERİ ÇAĞIRABİLİYORUZ.DİĞER İŞLEVLER SAMSUNG PRİNTER'DA BULUNMADIĞI İÇİN ÇAĞIRAMIYORUZ.

			HpPrinter2 hpPrinter2 = new();
			hpPrinter2.Print();
			hpPrinter2.Fax();
			hpPrinter2.Scan();
			hpPrinter2.PrintDuplex();
			//BURADA HP PRİNTER'DA BÜTÜN İŞLEVLER BULUNDUĞU İÇİN HP PRİNTER'DA BÜTÜN İŞLEVLERİ ÇAĞIRABİLİYORUZ.
			#endregion
		}
	}
}