namespace ProgramDoWhile;

public class InstructionDoWhile
{
	public static void Solution()
	{
		int nFirstnumber;
		
		do
		{
			Console.WriteLine("Enter the value of Firstnumber: ");
			 nFirstnumber = int.Parse(Console.ReadLine());
			Console.WriteLine($"{10 * nFirstnumber}");

		}

		while(nFirstnumber != 0);
	}
}
