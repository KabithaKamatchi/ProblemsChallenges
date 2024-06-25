

namespace  PyramidProgram;

public  class Pyramid
{
	public static void Solution()
	{
		Console.WriteLine("Enter the integer: ");
		bool bIsSucess = int.TryParse(Console.ReadLine(), out int nNum1);

		
			for(int i = 0; i < nNum1; i++)
			{
			for(int s = 0; s < nNum1 - i - 1; s++)
			{
				Console.Write(" ");
			}
			for(int j = 0; j < i + 1; j++)
				{
					Console.Write($"{nNum1} ");
				}
			
			Console.WriteLine(" ");
			}
		}
		
	 }
	


