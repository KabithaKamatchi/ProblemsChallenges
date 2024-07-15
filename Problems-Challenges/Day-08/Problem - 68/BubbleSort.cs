
namespace BubbleSortProgram
{
	public class BubbleSort
	{

		public static void Solution()
		{

			int[] nArrayValues = { 7, 8, 6, 2, 3, 2, 4, 1, 8, 4 };

			bool flag;

			int nTemp;

			for(int i = 0; i < nArrayValues.Length - 1; i++)
			{
				flag = false;

				for(int j = 0; j < nArrayValues.Length - 1; j++)
				{

					if(nArrayValues[j] > nArrayValues[j + 1])
					{
						nTemp = nArrayValues[j];
						nArrayValues[j] = nArrayValues[j + 1];
						nArrayValues[j + 1] = nTemp;
						flag = true;
					}
				}

				if(!flag)
				{
					break;

				}
			}

			foreach(int nResult in nArrayValues)
			{
				Console.Write($"{nResult}  ");
			}

            Console.WriteLine();
        }
	}

}