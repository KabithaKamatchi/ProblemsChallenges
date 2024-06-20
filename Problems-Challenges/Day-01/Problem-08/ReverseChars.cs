using System;

namespace Reverse;

public class ReverseChars
{
	public static void Solution()
	{
		Console.WriteLine("Enter the cLetter1: ");
		char cLetter1 = Convert.ToChar(Console.ReadLine());

		Console.WriteLine("Enter the cLetter2: ");
		char cLetter2 = Convert.ToChar(Console.ReadLine());


		Console.WriteLine("Enter the cLetter3: ");
		char cLetter3 = Convert.ToChar(Console.ReadLine());
		

		Console.WriteLine("Reversed characters: {0} {1} {2}", cLetter3, cLetter2, cLetter1);

	}
}