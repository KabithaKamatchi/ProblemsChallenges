

namespace    PatternProgram
{
	public  class Patterns1
	{
		public static void Solution()
		{
			Console.WriteLine("Enter the integer: ");
			int nValue = int.Parse(Console.ReadLine());

			for (int i = 0; i < nValue; i++)
			{
				for (int j = 0; j <= i; j++)
				{
					Console.Write($"{nValue} ");
				}

				Console.WriteLine(" ");
			}


		}	

	}
}
