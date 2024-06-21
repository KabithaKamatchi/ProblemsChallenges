namespace ConditionalProgram;

public class Conditional
{
	public static void Solution()
	{
		Console.WriteLine("Enter the FirstInteger: ");
		int nFirstInteger = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the SecondInteger: ");
		int nSecondInteger = int.Parse(Console.ReadLine());

		string strResult = (nFirstInteger > 0) ? "The postive number" : "Negative";
		Console.WriteLine($"{strResult}");

		string strResult1 = (nSecondInteger < 0) ? "The postive number" : "Negative";
		Console.WriteLine($"{strResult1}");

		string strResult3 = (nFirstInteger > 0 && nSecondInteger > 0) ? "Both are positive " : "Negative";
		Console.WriteLine($"{strResult3}");
	}
}


