namespace DescendingProgram;

public class OddNumber
{
	public static void Solution()
	{
		Console.WriteLine("Enter the FirstInteger: ");
		int nFirstInteger = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the SecondInteger: ");
		int nSecondInteger = int.Parse(Console.ReadLine());

		if(nFirstInteger < nSecondInteger)
		{
			int nTemp = nFirstInteger;
			nFirstInteger = nSecondInteger;
			nSecondInteger = nTemp;
		}
		Console.WriteLine("Odd numbers from" + nFirstInteger + "to " + nSecondInteger + " in descending order: ");
		for(int i = nFirstInteger; i >= nSecondInteger; i--)
		{
			if(i % 2 != 0)
			{
				Console.Write(i + " ");
			}
		}
		Console.WriteLine();
	}
}