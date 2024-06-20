
namespace EquivalentProgram
{
	public class Equivalent
	{
		public static void Solution()
		{
			Console.WriteLine("Enter the FirstNo: ");
			int nFirstNo = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter the SecondNo: ");
			int nSecondNo = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter the ThirdNo: ");
			int nThirdNo = int.Parse(Console.ReadLine());

			int nResult1 = (nFirstNo + nSecondNo) * nThirdNo;
			int nResult2 = (nFirstNo* nThirdNo) + (nSecondNo* nThirdNo);

			Console.WriteLine($"Equivalent : {nResult1}");
			Console.WriteLine($"Equivalent : {nResult2}");
		}
	}
}
