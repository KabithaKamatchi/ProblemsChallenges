namespace NumberRepeated;

public class  CalculateRepeated
{
	public static void Solution()
	{
		Console.WriteLine("Enter the FirstNumber: ");
		int nFirstNumber = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the SecondNumber: ");
		int nSecondNumber = int .Parse(Console.ReadLine());

		for(int i = 0; i < nSecondNumber; i++)
		{
			Console.Write(nFirstNumber);
		}
	}
}
