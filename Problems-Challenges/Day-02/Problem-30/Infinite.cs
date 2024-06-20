namespace SumInfiniteProgram;

public class  Infinite
{
	public static void Solution()
	{
		int nSum = 0;
		int nFirstnumber;
		do
		{
			Console.WriteLine("Enter the value of Firstnumber: ");
			 nFirstnumber = int.Parse(Console.ReadLine());

			nSum = nSum + nFirstnumber;

			if(nFirstnumber != 0)
			{
				Console.WriteLine(nSum);
			}

		}
		while (nFirstnumber != 0);

		Console.WriteLine("Finished");
	}
}