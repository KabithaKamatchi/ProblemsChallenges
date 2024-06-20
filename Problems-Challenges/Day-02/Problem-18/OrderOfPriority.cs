
namespace Priority;

public class OrderOfPriority
{
	public static void Solution()
	{
		Console.WriteLine("Enter the Value: ");
		int nValue = int.Parse(Console.ReadLine());

		int nFirstOperation = -6 + nValue * 5;
		int nSecondOperation = (13 - 2) * nValue;
		int nThirdOperation = (nValue + 2) * (20 / 10);
		int nFourthOperation = (12 + nValue) / (5 - 4);

		Console.WriteLine($"{nFirstOperation}");
		Console.WriteLine($"{nSecondOperation}");
		Console.WriteLine($"{nThirdOperation}");
		Console.WriteLine($"{nFourthOperation}");

	}
}