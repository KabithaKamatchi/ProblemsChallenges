  namespace  SquarePattern;

public class SquareProgram

{
	public static void Solution()
	{
		Console.WriteLine("Enter the integer: ");
		bool bIsSucess = int.TryParse(Console.ReadLine(), out int nNum1);

		for (int i = 0; i < nNum1; i++)
		{
			for (int j = 0; j < nNum1; j++)
			{      
                Console.Write($"{nNum1} ");
            }

				Console.WriteLine();
		}

	}
}