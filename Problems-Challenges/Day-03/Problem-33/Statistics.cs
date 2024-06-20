using System.Windows.Markup;
using GeometrySquare;

namespace MathematicalStatistics;

public class Statistics
{
	public static void Solution()
	{
		Console.WriteLine("Enter the 5 intergers, one at a time");

		int[] nInput = new int[5];
		


		for(int i = 0; i < 5; i++)
		{
			nInput[i] = int.Parse(Console.ReadLine());
		}

		int nSum = 0;

		for (int i = 0;i < 5; i++)
		{
			int nFirst = nInput[i];

			nSum = nSum + nFirst;
		}
		Console.WriteLine($"The Sum of 5 Integers: {nSum}");


		int nAvg = (nSum / 5);
		Console.WriteLine($"The arithmetic mean is : {nAvg}");

		int nMax = nInput[0];
		int nMin = nInput[0];

		for (int i = 1; i < 5; i++)
		{
			if(nInput[i] > nMax)
			{
				nMax = nInput[i];
			}
			else if(nInput[i] < nMin)
			{
				nMin = nInput[i];
			}
		}

		Console.WriteLine($"The max number is : {nMax}");

		Console.WriteLine($"The min number is : {nMin}");

	}
}