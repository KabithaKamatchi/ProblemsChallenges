namespace InfiniteMultiple;

public class MultiplesNumber
{
	public static void Solution()
	{
		Console.WriteLine("Enter the FirstInteger: ");
		int nFirstInteger = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the SecondInteger: ");
		int nSecondInteger = int.Parse(Console.ReadLine());	

		for(int i = 1; i <=500;  i++)
		{
			int nResult = nFirstInteger * i;
			Console.WriteLine(nSecondInteger * nResult);
		}
	}
}