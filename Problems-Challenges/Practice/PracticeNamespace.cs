
namespace Library1
{
	public class Helper
	{
		public static void Demo1()
		{
			Console.WriteLine("hi");
			Console.WriteLine("Namespace used to organize code and avoid naming conflicts");
		}
	}
}

namespace Library2
{
	public class Helper
	{
		public static  void Demo1()
		{
			Console.WriteLine("hello");

			double baseNumber = 2;
			double exponent = 3;
			double result = Math.Pow(baseNumber, exponent); 
			Console.WriteLine(result);


			double x = 5.0;
			double dResult = Math.Exp(x);
			Console.WriteLine("e^5 = " + dResult);

		}
	}
}

