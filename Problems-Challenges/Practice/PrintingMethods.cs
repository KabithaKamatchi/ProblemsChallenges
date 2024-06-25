

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


			int number = 12345;
			double value = 1234.5678;
			DateTime date = DateTime.Now;

			Console.WriteLine(number.ToString("D"));   // Output: 12345 (Decimal format)
			Console.WriteLine(value.ToString("F2"));   // Output: 1234.57 (Fixed-point format with 2 decimal places)
			Console.WriteLine(date.ToString("d"));     // Output: 6/24/2024 (Short date format)


		}

	}
}
