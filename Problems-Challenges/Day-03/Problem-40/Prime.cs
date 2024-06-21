namespace PrimeProgram;

public class CalculatePrime
{
	public static void Solution()
	{
		Console.WriteLine("Enter the FirstInteger: ");
		int nFirstInteger = int.Parse(Console.ReadLine());

		for(int i = 2;  i < 3; i++)
		{
			if(nFirstInteger % 2 == 0)
			{
				Console.WriteLine("IsNotPrime");
			}
			else
			{
				Console.WriteLine("Prime");
			}
		}

	}
}

