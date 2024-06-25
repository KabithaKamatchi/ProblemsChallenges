namespace FunctionEquation;

public class MathematicalProgram
{
	public static void Solution()
	{
		Console.WriteLine("Enter the first integer: ");
		int nFirst = int.Parse(Console.ReadLine());

		int nResult = nFirst * nFirst + 2* nFirst + 1;
		Console.WriteLine(nResult);

	}
}