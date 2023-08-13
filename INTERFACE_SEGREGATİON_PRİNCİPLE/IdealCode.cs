using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
	internal class IdealCode
	{
	}
	//INTERFACE SEGREGATİON PRİNCİPLE'A UYARAK BURADA BÜTÜN İŞLEVLERİ AYRI AYRI İNTERFACE'LERDE TANIMLAYARAK.İŞLEVİ OLAN PRİNTERLARDA IMPLEMENT ETTİK OLMAYANLARDA ZORLA IMPLEMENT ETMEK ZORUNDA KALMADIK.

	//BU SAYEDE INTERFACE SEGREGATİON PRİNCİPLE'A UYMUŞ OLDUK.
	interface IScan
	{
		public void Scan();
	}
	interface IPrint
	{
		public void Print();
	}
	interface IFax
	{
		public void Fax();
	}
	interface IPrintDublex
	{
		public void PrintDuplex();
	}


	class HpPrinter2 : IScan, IPrint, IFax, IPrintDublex
	{
		public void Fax()
		{
			Console.WriteLine("HP Printer Tarafından Fax İşlemi Başarıyla Gerçekleştirildi.");
		}

		public void Print()
		{
			Console.WriteLine("HP PRİNTER TARAFINDAN FAX İŞLEMİ BAŞARIYLA GERÇEKLEŞTİRİLDİ");
		}

		public void PrintDuplex()
		{
			Console.WriteLine("HP PRİNTER TARAFINDAN PRİNTDUPLEX İŞLEMİ BAŞARIYLA GERÇEKLEŞTİRİLDİ.");
		}

		public void Scan()
		{
			Console.WriteLine("HP PRİNTER TARAFINDAN SCAN İŞLEMİ BAŞARIYLA GERÇEKLEŞTİRİLDİ.");
		}
	}

	class SamsungPrinter2 : IPrint, IFax
	{
		public void Fax()
		{
			Console.WriteLine("SAMSUNG PRİNTER TARAFINDAN FAX İŞLEMİ BAŞARIYLA GERÇEKLEŞTİRİLDİ.");
		}

		public void Print()
		{
			Console.WriteLine("SAMSUNG PRİNTER TARAFINDAN PRİNT İŞLEMİ BAŞARIYLA GERÇEKLEŞTİRİLDİ.");
		}
		//SAMSUNG PRİNTER'DA BULUNAN İŞLEVLERİ BURADA TANIMLADIK.OLMAYAN İŞLEVLERİ IMPLEMENT ETMEK ZORUNDA KALMADIK.
	}
	class LexmarkPrinter2 : IPrint, IScan, IFax
	{
		public void Fax()
		{
			Console.WriteLine("LEXMARK PRİNTER TARAFINDAN FAX İŞLEMİ BAŞARIYLA GERÇEKLEŞTİRİLDİ.");
		}

		public void Print()
		{
			Console.WriteLine("LEXMARK PRİNTER TARAFINDAN PRİNT İŞLEMİ BAŞARIYLA GERÇEKLEŞTİRİLDİ.");
		}

		public void Scan()
		{
            Console.WriteLine("LEXMARK PRİNTER TARAFINDAN SCAN İŞLEMİ BAŞARIYLA GERÇEKLEŞTİRİLDİ.");
        }
		//BURADA LEXMARK PRİNTER'IN YAPABİLDİĞİ İŞLEVLERİ AYRI AYRI INTERFACE'LER TANIMLAYARAK YAPTIK. YAPAMDIĞI İŞLEVLERİ İÇİNDE BULUNDURMADIK.
	}
}
