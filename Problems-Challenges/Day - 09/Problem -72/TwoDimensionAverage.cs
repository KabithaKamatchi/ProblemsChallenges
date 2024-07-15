

namespace AverageProgram;

	public  class TwoDimensionAverage
	{
		public static void Solution()
		{
			int[,] nFirstArray1 = new int[2, 5];
			Console.WriteLine("Enter the elements of nFirstArray: ");

		    for (int i = 0; i < 2; i++)
			{
				for(int j = 0; j < 5; j++)
				{
					Console.Write($"Enter the element at position [{i},{j}]:" );
					nFirstArray1[i,j] = int.Parse(Console.ReadLine());
				}
			}


		Console.WriteLine("Array1: ");
			for(int i = 0;i < 2; i++)
			{
				int nSum = 0;

				for(int j = 0;j < 5; j++)
				{
					nSum += nFirstArray1[i, j];
				}

				float nAverage = nSum / 5;

				Console.WriteLine($"Sum: {nSum}");
				Console.WriteLine($"Average: {nAverage}");
			}
		}
	}
