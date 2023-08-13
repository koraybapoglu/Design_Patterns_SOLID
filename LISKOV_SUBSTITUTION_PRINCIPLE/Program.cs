namespace Liskov_Substitution_Principle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//NOT IDEAL CODE
			Cloud  cloud =new Google();
			cloud.MachineLearning();
			cloud.Translate();

			cloud = new AWS();
			cloud.MachineLearning();
			cloud.Translate();

			cloud = new AZURE();
			cloud.MachineLearning();
			cloud.Translate();

			//IDEAL CODE
			Cloud2 cloud2 = new Google2();
			cloud2.MachineLearning();
			(cloud2 as ITranslate)?.Translate();

			cloud2=new AWS2();
			cloud2.MachineLearning();
			(cloud2 as ITranslate)?.Translate();

			cloud2=new AZURE2();
			cloud2.MachineLearning();
			(cloud2 as ITranslate)?.Translate();

			Console.ReadLine();


			
		}
	}
}