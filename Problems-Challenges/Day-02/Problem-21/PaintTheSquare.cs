
namespace  GeometrySquare;

public class PaintTheSquare
{
	public static void Solution()
	{
		Console.WriteLine("Enter the value of Firstnumber: ");
		int nFirstnumber = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the width: ");
		int nWidth = int.Parse(Console.ReadLine());

		for(int i = 0; i < nWidth; i++)
		{
			for(int j = 0; j < nWidth; j++)
			{
				Console.Write($"{nFirstnumber}");
			}
			Console.WriteLine();
		}
	}
}
