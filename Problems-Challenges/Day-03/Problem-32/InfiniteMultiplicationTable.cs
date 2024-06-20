namespace MultiplicationTable;

public class InfiniteMultiplicationTable
{
	public static void Solution()
	{
		Console.WriteLine("Enter the FirstValue: ");
		int nFirstValue = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the SecondValue: ");
		int  nSecondValue = int.Parse(Console.ReadLine());

		for(int i = nFirstValue; i < nSecondValue; i++)
		{
			for(int j = 1; j <= 10; j++)
			{
				Console.WriteLine(i * j);
			}
		}
	}
}