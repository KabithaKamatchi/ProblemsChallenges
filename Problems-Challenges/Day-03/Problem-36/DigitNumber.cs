using System.Globalization;

namespace DigitProgram;

public class DigitNumber
{
	public static void Solution()
	{
		Console.WriteLine("Enter the Positive integer: ");
		int nPositive = int.Parse(Console.ReadLine());

		if(nPositive < 0)
		{
			Console.WriteLine("warning : It is a negative number: ");
			nPositive = -nPositive;
		}

		int nDigitNumber = 0;

		if(nPositive == 0)
		{
			nDigitNumber = 1;
		}

		else 
		{
			int nTemp = nPositive;
			while(nTemp != 0)
			{
				nTemp /= 10;
				nDigitNumber++;
			}
		}

		Console.WriteLine($"{nDigitNumber} digits");
	}
}
