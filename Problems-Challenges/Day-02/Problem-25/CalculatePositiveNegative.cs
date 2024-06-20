namespace  PositiveNegative;


public class CalculatePositiveNegative
{
	public static void Solution()
	{
		Console.WriteLine("Enter the value of Firstnumber: ");
		int nFirstnumber = int.Parse(Console.ReadLine());

		if(nFirstnumber > 0)
		{
			Console.WriteLine("Positive Number");
		}
		else
		{
			Console.WriteLine("Negative Number");
		}
	}
}