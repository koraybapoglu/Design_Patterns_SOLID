using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
	internal class IdealCode
	{
	}
	interface ITranslate //BURADA ITRANSLATE KULLANARAK ABSTRACT CLASS'TA ZORLA İMPELEMENT ETMEMİZ GEREKEN TRANSLATE ÖZELLİĞİNİ İNTERFACE'DE TANIMLAYARAK TRANSLATE ÖZELLİĞİ TAŞIMAYAN CLASS'LARDA TANIMLAMADIK.BU SAYEDE ARTIK ZORLA İMPELEMENT EDİLİCEK BİR METHOD KALMAMIŞ OLDU.ARTIK TRANSLATE ÖZELLİĞİNİ TAŞIYAN CLASS'LAR OLUCAK VE BÜTÜN CLASSLAR'DA BULUNAN MACHİNE LEARNİNG METHODU ABSTRACT CLASS'DA DURUCAK.

	//BU KULLANIMIDA LİSKOV PRENSİBİ DENİLİYOR.
	{
		public void Translate();
	}
	abstract class Cloud2
	{
		public abstract void MachineLearning();
	}

	class AWS2 : Cloud2, ITranslate
	{
		public override void MachineLearning()
		{
			Console.WriteLine("AWS MACHİNE LEARNİNG ÇALIŞTI ");
		}

		public void Translate()
		{
			Console.WriteLine("AWS TRANSLATE ÇALIŞTI");
		}
	}

	class AZURE2 : Cloud2
	{
		public override void MachineLearning()
		{
			Console.WriteLine("AZURE MACHİNE LEARNİNG ÇALIŞTI ");
		}
	}

	class Google2 : Cloud2, ITranslate
	{
		public override void MachineLearning()
		{
			Console.WriteLine("GOOGLE MACHİNE LEARNİNG ÇALIŞTI ");
		}

		public void Translate()
		{
			Console.WriteLine("GOOGLE ITRANSLATE ÇALIŞTI ");
		}
	}
}
