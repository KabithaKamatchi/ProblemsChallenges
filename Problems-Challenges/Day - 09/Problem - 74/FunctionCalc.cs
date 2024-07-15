

namespace FunctionCalculator
{
	public  class FunctionCalc
	{
		public static void Solution()
		{
			Console.WriteLine("Enter the integer: ");
			bool bIsSucess = int.TryParse(Console.ReadLine(), out int nNum1);

			Console.WriteLine("Enter the integer: ");
			bool bIsSucess1 = int.TryParse(Console.ReadLine(), out int nNum2);

			Console.WriteLine("Enter the Operation(+,-,*,/): ");
			string Operation = Console.ReadLine();



			switch (Operation)
			{
				case "+":
					Console.WriteLine(nNum1 + nNum2);
					break;

				case "-":
                    Console.WriteLine(nNum1 - nNum2);
					break;

				case "*":
                    Console.WriteLine(nNum1 * nNum2);
					break;

				case "/":
                    Console.WriteLine(nNum1 / nNum2);
					break;

            }
		}
		
	}
}
