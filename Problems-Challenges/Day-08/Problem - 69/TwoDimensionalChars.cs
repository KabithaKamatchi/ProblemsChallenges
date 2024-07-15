

namespace TwoDimensionCharProgram
{
	public  class TwoDimensionalChars
	{
		public static void Solution()
		{
			Console.Write("Enter number of rows: ");
			int rows = int.Parse(Console.ReadLine());

			Console.Write("Enter number of columns: ");
			int columns = int.Parse(Console.ReadLine());

			char Letter = 'x';

			int[,] matrix = new int[rows, columns];

            Console.WriteLine("Array1: ");
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					Console.Write($"{Letter}");
				}
				Console.WriteLine();
			}
        }
	}
}
