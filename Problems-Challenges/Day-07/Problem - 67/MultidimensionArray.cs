


namespace MultidimensionProgram
{
	public  class MultidimensionArray
	{
		 public static void Solution()
		{
			int[,] nNum = { { 1, 2, 3, }, { 4, 5, 6, } };

			for(int i = 0; i < nNum.Length; i++)
			{
				for(int j = 0; j < nNum.Length; j++)
				{
					Console.WriteLine(nNum[i,j]);
				}
			}
		}
	}
}
