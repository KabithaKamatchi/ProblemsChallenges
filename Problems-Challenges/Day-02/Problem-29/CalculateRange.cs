namespace  RangeProgram;

public class CalculateRange
{
	public static void Solution()
	{
		Console.WriteLine("Enter the value of Firstnumber: ");
		int nFirstnumber = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the value of Secondnumber: ");
		int nSecondnumber = int.Parse(Console.ReadLine());

		for(int i = nFirstnumber;  i <= nSecondnumber; i++)
		{
			Console.WriteLine(i);
		}
	}
}
