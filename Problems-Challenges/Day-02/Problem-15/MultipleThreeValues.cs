
namespace ProductThreeFactors;

public  class MultipleThreeValues
{
	public static void Solution()
	{
		Console.WriteLine("Enter the FirstValue: ");
		int nFirstValue = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the SecondValue: ");
		int nSecondValue = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the ThirdValue: ");
		int nThirdValue = int.Parse(Console.ReadLine());

		int nProduct = (nFirstValue * nSecondValue * nThirdValue);

		Console.WriteLine($"Multiplication of three Factors: {nProduct} ");

	}

}
