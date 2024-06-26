
namespace RightTiangleProgram;

public class RightAlignedTriangle
{
	public static void Solution()
	{
		Console.WriteLine("Enter the integer: ");
		bool bIsSucess = int.TryParse(Console.ReadLine(), out int nNum1);

		for(int i = 1; i <= nNum1; i++)
		{

			for(int s = 0; s < nNum1 - i; s++)
			{
				Console.Write(" ");
			}

			for(int j = 0; j < i; j++)
			{
				Console.Write($"{nNum1}");
			}

			Console.WriteLine();
		}
	}
}