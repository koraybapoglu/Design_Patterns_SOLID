using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Solid_Open_Closed_Principle
{
	public class ParaGonderıcı
	{
		public void ParaGonder(IBanka banka, int tutar, string hesapno)
		{
			banka.ParaTransfer(tutar, hesapno);
		}
	}
	public interface IBanka
	{
		bool ParaTransfer(int tutar, string hesapno);
	}
	public class _Garanti : IBanka
	{
		public string HesapNo { get; set; }
		public void ParaGonder(int tutar)
		{
			Console.WriteLine(HesapNo + "Adlı Hesaba" + " " + tutar + "Para Gonderildi");
			Console.WriteLine("Garanti Bankası Tarafından Gönderildi.");
		}
		public bool ParaTransfer(int tutar, string hesapno)
		{
			try
			{
				HesapNo = hesapno;
				ParaGonder(tutar);
				return true;
			}
			catch (Exception)
			{

				return false;
			}
		}
	}
	public class _Halkbank:IBanka
	{
		public string HesapNo { get; set; }
		public void ParaGonder(int tutar)
		{
			Console.WriteLine(HesapNo + "Adlı Hesaba" + " " + tutar + "Para Gonderildi");
			Console.WriteLine("Halkbank Tarafından Gonderildi.");
		}
		public bool ParaTransfer(int tutar, string hesapno)
		{
			try
			{
				HesapNo = hesapno;
				ParaGonder(tutar);
				return true;
			}
			catch (Exception)
			{

				return false;
			}
		}
	}
	class AhmetBank:IBanka
	{
		public string HesapNo { get; set; }
		public void ParaGonder(int tutar)
		{
			Console.WriteLine(HesapNo + "Adlı Hesaba" + " " + tutar + "Para Gonderildi");
			Console.WriteLine("AhmetBank Tarafından Gonderildi.");
		}
		public bool ParaTransfer(int tutar, string hesapno)
		{
			try
			{
				HesapNo = hesapno;
				ParaGonder(tutar);
				return true;
			}
			catch (Exception)
			{

				return false;
			}
		}
	}
}
