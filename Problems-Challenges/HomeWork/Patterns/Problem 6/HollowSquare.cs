namespace HollowSquarePattern;

public class HollowSquare
{
	public static void Solution()
	{
		Console.WriteLine("Enter the integer: ");
		bool bIsSucess = int.TryParse(Console.ReadLine(), out int nNum1);

		for (int i = nNum1 - 1; i >= 0; i--)
		{
			for(int j = 0; j < nNum1; j++)
			{
				if(i == 0 || i == nNum1 - 1)
				{
					Console.Write($"{nNum1}");
				}
				else
				{
					if(j == 0 || j == nNum1 - 1)
					{
						Console.Write($"{nNum1}");
					}
					else
					{
						Console.Write(" ");
					}
				}
			}

            Console.WriteLine();
        }

	}
}