namespace EvenProgram;

public class EvenNumbers1
{
	public static void Solution()
	{
		int[] nValue1 = new int[10];

        Console.WriteLine("Enter the integer: ");

		for(int i = 0; i < nValue1.Length; i++)
		{
			Console.Write("Enter integer {0}: ", i + 1);
			bool bIsSuccess = int.TryParse(Console.ReadLine(), out  nValue1[i]);

		}
		Console.WriteLine("The even numbers are: ");
		foreach(int num in nValue1)
		{
			if(num % 2 == 0)
			{
				Console.WriteLine(num);
			}
		}
    }
}