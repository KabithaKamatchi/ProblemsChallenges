namespace WhileProgram;

public class InstructionWhile
{
	public static void Solution()
	{
		Console.WriteLine("Enter the value of Firstnumber: ");
		int nFirstnumber = int.Parse(Console.ReadLine());

		while(nFirstnumber != 0) 
		{
				Console.WriteLine($"{10 * nFirstnumber}");
		}
	}
}