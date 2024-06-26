namespace CalculatePositiveNegative;

public class PositiveNegative1
{
	public static void Solution()
	{
		int[] nValues = new int[10];

		Console.WriteLine("Please enter 10 integers:");

		for(int i = 0; i < nValues.Length; i++)
		{
			Console.Write("Enter integer {0}: ", i + 1);
			bool bIsSuccess = int.TryParse(Console.ReadLine(), out nValues[i]);
		}

		int totalNegative = 0;
		int totalPositive = 0;
		int countNegative = 0;
		int countPositive = 0;

		for(int i = 0; i < nValues.Length; i++)
		{
			if(nValues[i] < 0)
			{
				totalNegative += nValues[i];
				countNegative++;
			}
			else if(nValues[i] > 0)
			{
				totalPositive += nValues[i];
				countPositive++;
			}
		}

		if(countNegative > 0)
		{
			Console.WriteLine("Average negative number is: " + (double) totalNegative / countNegative);
		}
		if(countPositive > 0)
		{
			Console.WriteLine("Average positive number is: " + (double) totalPositive / countPositive);
		}
	}
}





