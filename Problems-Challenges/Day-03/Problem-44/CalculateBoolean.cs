namespace BooleanProgram;

public class CalculateBoolean
{
	public static void Solution()
	{
		Console.WriteLine("Enter the value of Firstnumber: ");
		int nFirstnumber = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the value of Secondnumber: ");
		int nSecondnumber = int.Parse(Console.ReadLine());

		bool bResult = (nFirstnumber % 2 == 0 && nSecondnumber % 2 == 0) ? true : false;

		Console.WriteLine($"{bResult} ");
	}
}