namespace AbsoluteProgram;

public class Absolute
{
	public static void Solution()
	{
		Console.WriteLine("Enter the FirstInteger: ");
		int nFirstInteger = int.Parse(Console.ReadLine());

		int nResult;

		if(nFirstInteger < 0 )
		{
			 nResult = nFirstInteger;
		}
		else
		{
			 nResult = nFirstInteger;
		}

		Console.WriteLine($"The absolute value is : {nResult}");
	}
}