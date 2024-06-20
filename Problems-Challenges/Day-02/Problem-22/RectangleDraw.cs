namespace GeometryRectangle;

public class RectangleDraw
{
	public static void Solution()
	{
		Console.WriteLine("Enter the value of Firstnumber: ");
		int nFirstnumber = int.Parse(Console.ReadLine());

		for(int row = 0; row < 5 ; row++)
		{
			for(int col = 0; col < 3 ; col++)
			{
				Console.Write($"{nFirstnumber}");
			}
			Console.WriteLine();
		}

	}
}