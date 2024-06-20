

namespace  Division
{
	public  class CalculateDivision
	{
		public static void Solution()
		{
			Console.WriteLine("Enter the FirstNo: ");
			int nFirstNo = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter the SecondNo: ");
			int nSecondNo = int.Parse(Console.ReadLine());

			int nDivision = nFirstNo / nSecondNo;
			int nDivisionModulo = nFirstNo % nSecondNo;

			Console.WriteLine($"Division: {nDivision}");
			Console.WriteLine($"Modulo: {nDivisionModulo}");
		}
	}
}
