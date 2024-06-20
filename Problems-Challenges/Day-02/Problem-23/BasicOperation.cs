namespace BasicCalculatorProgram;

public class BasicOperation
{
	public static void Solution()
	{
		Console.WriteLine("Enter the value of Firstnumber: ");
		int nFirstnumber = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the Operation(+,-,*,/): ");
		string Operation = Console.ReadLine();

		Console.WriteLine("Enter the value of Secondnumber: ");
		int nSecondnumber = int.Parse(Console.ReadLine());

		int nResult = 0;

		if(Operation == "+")
		{
			 nResult = nFirstnumber + nSecondnumber;
		}
		else if(Operation  == "-")
		{
			 nResult = nFirstnumber - nSecondnumber;

		}

		else if(Operation == "*")
		{
			 nResult = nFirstnumber * nSecondnumber;
		}

		else if(Operation == "/")
		{
			 nResult = nFirstnumber / nSecondnumber;
		}
		else
		{
			Console.WriteLine("Unrecognized Character");
		}

		Console.WriteLine($"{nResult}");
	}
}

