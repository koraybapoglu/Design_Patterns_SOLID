namespace Solid_SingleResponsibility_Princible
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//SINGLE RESPONSIBILITY PRINCIPLE(SRP)(TEK SORUMLULUK PRENSİBİ),OOP tasarımlarında bir sınıfı mümkün mertebe tek bir sorumluluğa odaklı inşa edilmesi gerektiğini ilke olarak savunan bir prensiptir.

			//Bir sınıfın,değiştirilmesi gereken birden fazla sebebi varsa eğer işte bu durum ilgili birden fazla sorumluluğu olduğu anlamına gelmektedir

			//SRP,Bir sınıfın değişmesi için tek bir nedeni olması gerektiğini ifade etmekte ve inşa edilen kodun bu hassasiyetle üretilmesini savunmaktadır.

			//Bir sınıfın değişmesi için yalnızca tek bir nedeni olması gerekmektedir.
		}
	}

	//YANLIŞ KULLANIM
	class Database
	{
		public void Connect()
		{
			Console.WriteLine("Veritabanı bağlantısı Yapılmıştır.");
		}
		public void Disconnect()
		{
			Console.WriteLine("Veritabanı bağlantısı kesilmiştir.");
		}
		public void GetPersons()
		{
            Console.WriteLine("Personeller Getirildi !");
        }
	}
	//Doğru Kullanım
	class Veritabanı 
	{
		public void Connect()
		{
			Console.WriteLine("Veritabanı bağlantısı Yapılmıştır.");
		}
		public void Disconnect()
		{
			Console.WriteLine("Veritabanı bağlantısı kesilmiştir.");
		}
	}
	class Personel
	{
		public void GetPersons() 
		{
            Console.WriteLine("Personel Getirildi !");
        }
		public void AddPersons() 
		{
            Console.WriteLine("Personel Eklendi !");
        }
		public void DeletePersons(string adi) 
		{
            Console.WriteLine(adi+"Adlı Personel Silindi !");
        }
		public void UpdatePersons(string adi) 
		{
            Console.WriteLine(adi+"Adlı Personel Güncellendi !");
        }
	}
}
