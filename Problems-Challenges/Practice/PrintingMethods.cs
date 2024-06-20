

using System.Diagnostics;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Xml;

namespace ProgramOutput
{
	public  class PrintingMethods
	{

		public static void Solution2()
		{
			// Console.WriteLine
			Console.WriteLine("Hello, World!");
			System.Console.WriteLine("Nice to meet you");
			
			//Console.Write
			Console.Write("Hiii, ");
			Console.Write("everyone!");


			// String Interpolation
			//Purpose: Embeds expressions directly within string literals.
			// embedding variables and expressions in the string.
			int x = 10;
			Console.WriteLine($"The value of x is: {x}");

			//StringFormat
			//Formats strings using placeholders.
			//when dealing with multiple variables.
			int a = 5;
			int b = 10;
			Console.WriteLine(String.Format("The sum of {0} and {1} is {2}", a,b, a + b));

		}

	}
}
