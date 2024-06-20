namespace RandomNumber;

public class GenerateRandomNumber
{
	public static void Solution()
	{
		Console.WriteLine("Enter the FirstValue: ");
		int nFirstValue = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the SecondValue: ");
		int nSecondValue = int.Parse(Console.ReadLine());

		int nResult = (nFirstValue + nSecondValue);

		int nOutput = nResult / 2;

		Console.WriteLine($"The Random number is : {nOutput}");
	}
}