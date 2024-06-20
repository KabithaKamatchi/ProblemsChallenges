using System;

namespace Storeinput;

public class UserInput
{
	public static void Solution()
	{
		Console.WriteLine("What is your name? ");
		string x = Console.ReadLine();

		Console.WriteLine("Nice to meet you, " + x);	
	}
}

