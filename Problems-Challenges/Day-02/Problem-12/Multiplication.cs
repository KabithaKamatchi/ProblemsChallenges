

namespace  CalculateTables
{
	public  class Multiplication
	{
		public static void Solution()
		{
			Console.WriteLine("Enter the Number: ");
			int nNumber = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine($"Multiplication Table {nNumber}: ");
			for (int i = 0; i <= 10 ; i++)
			{
				Console.WriteLine($"{nNumber} * {i} = {nNumber * i}");
			}
		}
	}
}
