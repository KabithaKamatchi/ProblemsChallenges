namespace ReverseProgram;

public class ReverseOrder
{
	public static void Solution()
	{
		int[] nValues = new int[5];

		Console.WriteLine("Please enter 5 integers:");

		for(int i = 0; i < nValues.Length; i++)
		{
			Console.Write("Enter integer {0}: ", i + 1 );
			nValues[i] = int.Parse(Console.ReadLine());
		}

		Console.WriteLine("The numbers in reverse order are:");

		for(int i = nValues.Length - 1; i >= 0; i--)
		{
			Console.Write(nValues[i] + " ");
		}

		Console.WriteLine();
	}
}