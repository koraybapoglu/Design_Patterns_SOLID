namespace Loose_Coupling_Principles
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ne Göndermek istiyorsunuz ?\nHOTMAİL İSE 1\n YANDEX İSE 2\n GMAİL İSE 3 TUŞLAYINIZ");
			ConsoleKeyInfo key = Console.ReadKey();
			int a = int.Parse(key.KeyChar.ToString());
			Console.WriteLine("Göndermek istediğiniz Mail Adresini Giriniz:");
			string MailAdresi = Console.ReadLine();
			Console.WriteLine("Göndermek istediğiniz Mesajı Giriniz:");
			string mesaj = Console.ReadLine();
			MailSender mailSender = new MailSender();
			if (a == 1)
			{
				mailSender.SendMail(new Mail(), MailAdresi, mesaj);
			}
			else if (a == 2)
			{
				mailSender.SendMail(new Yandex(), MailAdresi, mesaj);
			}
			else if (a == 3)
			{
				mailSender.SendMail(new Gmail(), MailAdresi, mesaj);
			}
			else
			{
				Console.WriteLine("HATA KODU 101 TEKRAR DENEYİNİZ");
			}
			Console.ReadLine();
		}
		class MailSender
		{
			public void SendMail(IMailService mailService, string to, string body)
			{
				mailService.Send(to, body);
			}
		}
		interface IMailService
		{
			public void Send(string to, string body);
		}
		class Gmail : IMailService
		{

			public void Send(string to, string body)
			{
				Console.WriteLine("Gönderilen:" + to + " " + "Mesaj:" + body);
				Console.WriteLine("Gmail Gönderimi Başarılı");
			}
		}
		class Mail : IMailService
		{
			public void Send(string to, string body)
			{
				Console.WriteLine("Gönderilen:" + to + " " + "Mesaj:" + body);
				Console.WriteLine("Hotmail Gönderimi Başarılı");
			}
		}
		class Yandex : IMailService
		{
			public void Send(string to, string body)
			{
				Console.WriteLine("Gönderilen:" + to + " " + "Mesaj:" + body);
				Console.WriteLine("Yandex Mail Gönderimi Başarılı");
			}
		}
		/*
		 --------------------------------------------------EKRAN ÇIKTISI------------------------------------------------------
		Ne Göndermek istiyorsunuz ?
        HOTMAİL İSE 1
        YANDEX İSE 2
        GMAİL İSE 3 TUŞLAYINIZ
        2
		Göndermek istediğiniz Mail Adresini Giriniz:
        koraybapoglu@yandexmail.ru^S
        Göndermek istediğiniz Mesajı Giriniz:
        yandex nasıl ?
        Gönderilen:koraybapoglu@yandexmail.ru Mesaj:yandex nasıl ?
        Yandex Mail Gönderimi Başarılı
		 */

	}
}