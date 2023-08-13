using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
	public class NotIdealCode
	{

	}
	public abstract class Printer
	{
		public abstract void Print();
		public abstract void Scan();
		public abstract void Fax();
		public abstract void PrintDuplex();
	}
	class HPPrinter : Printer
	{
		public override void Fax()
		{
            Console.WriteLine("Fax İşlemi Gerçekleştirildi.");
        }

		public override void Print()
		{
            Console.WriteLine("Print İşlemi Gerçekleştirildi.");
        }

		public override void PrintDuplex()
		{
            Console.WriteLine("Print Duplex İşlemi Gerçekleştirildi.");
        }

		public override void Scan()
		{
			Console.WriteLine("Scan İşlemi Gerçekleştirildi.");
		}
	}
	class SamsungPrinter : Printer
	{
		public override void Fax()
		{
            Console.WriteLine("Fax İşlemi Gerçekleştirildi.");
        }

		public override void Print()
		{
			Console.WriteLine("Print İşlemi Gerçekleştirildi.");
		}

		public override void PrintDuplex()
		{
			throw new NotImplementedException(); //BURADA SAMSUNGPRİNTER'DA BULUNMAYAN İŞLEV OLAN PRİNTDUPLEX İŞLEVİNİ SAMSUNGPRİNTER NESNESİNDE BULUNDURUYORUZ FAKAT KARŞILIĞINDA BİZE HATA VERİYOR VE BU SOLİD PRENSİPLERİNE AYKIRIDIR.
		}

		public override void Scan()
		{
			throw new NotImplementedException(); ////BURADA SAMSUNGPRİNTER'DA BULUNMAYAN İŞLEV OLAN SCAN İŞLEVİNİ SAMSUNGPRİNTER NESNESİNDE BULUNDURUYORUZ FAKAT KARŞILIĞINDA BİZE HATA VERİYOR VE BU SOLİD PRENSİPLERİNE AYKIRIDIR.
		}
	}
	class LexmarkPrinter : Printer
	{
		public override void Fax()
		{
			Console.WriteLine("Fax İşlemi Gerçekleştirildi.");
		}

		public override void Print()
		{
            Console.WriteLine("Print İşlemi Gerçekleştirildi.");
        }

		public override void PrintDuplex()
		{
			throw new NotSupportedException(); //BURADA LEXMARKPRİNTER'DA BULUNMAYAN İŞLEV OLAN PRİNTDUPLEX İŞLEVİNİ LEXMARKPRİNTER NESNESİNDE BULUNDURUYORUZ FAKAT KARŞILIĞINDA BİZE HATA VERİYOR VE BU SOLİD PRENSİPLERİNE AYKIRIDIR.
		}

		public override void Scan()
		{
            Console.WriteLine("Scan İşlemi Gerçekleştirildi.");
        }
	}
}
