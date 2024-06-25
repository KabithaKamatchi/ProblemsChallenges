namespace ReverseProgram;

public class EvenNumbers
{
	public static void Solution()
	{
		int[] nValue1 = new int[10];

        Console.WriteLine("Enter the integer: ");

		for(int i = 0; i < nValue1.Length ; i++)
		{
			Console.Write("Enter integer {0}: ", i + 1);
			 nValue1[i] = int.Parse(Console.ReadLine());

			if(nValue1[i] % 2 == 0)
			{
				
                Console.WriteLine($"{nValue1}");
            }

		}

    }
}