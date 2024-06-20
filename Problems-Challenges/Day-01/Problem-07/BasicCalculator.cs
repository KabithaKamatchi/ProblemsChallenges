using System;

namespace Calculator;

public class BasicCalculator()
{
	public static void  Solution(int x, int y)
	{
		Console.WriteLine($"nAddition:{ x + y}");
		Console.WriteLine($"nSubtraction:{x - y}");
		Console.WriteLine($"nMultiplication:{x * y}");
		Console.WriteLine($"nDivision:{x /  y}");
		Console.WriteLine($"nModulo:{x % y}");

	}
}
	