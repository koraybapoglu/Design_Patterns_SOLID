using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
	internal class NotIdealCode
	{

	}
	abstract class Cloud
	{
		public abstract void MachineLearning();
		public abstract void Translate();
	}
	class AWS : Cloud
	{
		public override void MachineLearning()
		{
			Console.WriteLine("AWS MACHİNE LEARNİNG ÇALIŞTI ");
		}

		public override void Translate()
		{
			Console.WriteLine("AWS TRANSLATE ÇALIŞTI ");
		}
	}

	class AZURE : Cloud
	{
		public override void MachineLearning()
		{
			Console.WriteLine("AZURE MACHİNE LEARNİNG ÇALIŞTI ");
		}

		public override void Translate()
		{
			throw new NotImplementedException();   //BURADA AZUREDE TRANSLATE İŞLEMİ OLMADIĞI İÇİN BOŞ İMPLEMENT EXCEPTİON HATASI YOLLAMASI GEREKTİĞİNİ SÖYLEDİK.

			//FAKAT BU KULLANIM LİSKOV PRENSİBİNE UYMAYAN BİR HAREKETTİR.EĞER BU İMPLEMENT EDİLİCEKSE KULLANILMASI GEREKTİĞİNİ KULLANILMAYAN BOŞ VEYA EXCEPTİON HATASI FIRLATAN BİR KOD OLDUĞUNDA BU KODUN İLERİDE BİZE SIKINTILAR ÇIKARABİLECEĞİNİ BAŞKA YERLERİ PATLATIP BOZABİLECEĞİNİ SÖYLER.BUNDAN DOLAYI BU KULLANIM HATALI KULLANIMDIR.
		}
	}
	class Google : Cloud
	{
		public override void MachineLearning()
		{
			Console.WriteLine("GOOGLE MACHİNE LEARNİNG ÇALIŞTI ");
		}

		public override void Translate()
		{
			Console.WriteLine("GOOGLE TRANSLATE ÇALIŞTI ");
		}
	}
}
