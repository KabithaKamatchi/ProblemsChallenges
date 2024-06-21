namespace  TriangleNE;

public class NorthEastTriangle
{
	public static void Solution()
	{
		char cStart = '*';

		Console.WriteLine("Enter the integer: ");
		int nInput = int.Parse(Console.ReadLine());

		for (int i = 0; i < nInput; i++)
		{
			for (int j = 0; j < i ; j++)
			{
				Console.Write(" ");
			}
			for (int k = 0; k < nInput - 1 ; k++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}