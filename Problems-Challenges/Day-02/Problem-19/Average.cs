
namespace Average
{
	public class AverageProgram
	{
		public static void Solution()
		{
			Console.WriteLine("Enter the FirstNo: ");
			int nFirstNo = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter the SecondNo: ");
			int nSecondNo = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter the ThirdNo: ");
			int nThirdNo = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter the FourthNo: ");
			int nFourthNo = int.Parse(Console.ReadLine());


			int nAvg = (nFirstNo + nSecondNo + nThirdNo + nFourthNo) / 4;

			Console.WriteLine($"Average is : {nAvg}");
		}
	}
}
