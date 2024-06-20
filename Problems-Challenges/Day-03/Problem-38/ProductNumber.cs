namespace Product;

public class ProductNumber
{
	public static void Solution()
	{
		Console.WriteLine("Enter the firstvalue: ");
		int  nFirst = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the secondvalue: ");
		int nSecond = int.Parse(Console.ReadLine());

		int nConsecutive = 0;

		for(int i = 0; i < nSecond; i++)
		{
			nConsecutive = nConsecutive + nFirst;
		}

		Console.WriteLine($"The product of consecutive number {nFirst} * {nSecond} = {nConsecutive}");
	}
}