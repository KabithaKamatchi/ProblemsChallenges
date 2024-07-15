

namespace FunctionMinMax
{
	public  class MinMaxArray
	{
		public static void Solution()
		{
			int[] nValues = new int[5];

			Console.WriteLine("Enter the integers: ");

			for(int i = 0; i < 5; i++)
			{
                Console.WriteLine($"Number: ");
				bool bIsSuccess = int.TryParse( Console.ReadLine(), out nValues[i] );

            }

			int nMinimum = nValues[0];
			int nMaximum = nValues[0];

			for(int i = 0; i < nValues.Length; i++)
			{
				if(nValues[i] < nMinimum)
				{
					nMinimum = nValues[i];
				}

				if(nValues[i] > nMaximum)
				{
					nMaximum = nValues[i];
				}
			}
				Console.WriteLine($"nMinimum: {nMinimum}");
				Console.WriteLine($"nMaximum: {nMaximum}");			
		}
		
	}
}
