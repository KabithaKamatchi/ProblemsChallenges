namespace Switch;

public class SwitchCalculator
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

		switch (Operation)
		{
			case "+":
				nResult = nFirstnumber + nSecondnumber;
				break;

			case "-":
				nResult = nFirstnumber - nSecondnumber;
				break;

			case "*":	
				nResult = nFirstnumber * nSecondnumber;
				break;

			case "/":
				nResult = nFirstnumber / nSecondnumber;
				break;

			default:
				Console.WriteLine("Unrecognized Character");
				break;
		}
		Console.WriteLine($"Operation of nResult:{nResult}");
	}

}

