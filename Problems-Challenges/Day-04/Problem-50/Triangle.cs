namespace TriangleProgram;

public class Triangle
{
	public static void Solution()
	{
		int nFirst = 3;
		int nSecond = 4;

		for(int i = 0; i < nSecond; i++)
		{
			for(int j = 0; j < nSecond - i; j++)
			{
				Console.Write($" {nFirst} ");
			}	
			
			Console.WriteLine();
		}
	}
}
