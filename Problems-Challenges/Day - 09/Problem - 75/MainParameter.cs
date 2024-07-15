

namespace FunctionParameter;

public class MainParameter
{
	public static void Solution()
	{

		static void MainParam(String[] args )
		{

			if(args.Length < 3)
			{
				Console.WriteLine("<number1> <operation> <number2>");
				return;
			}

			int num1, num2;
			if(!int.TryParse(args[0], out num1))
			{
				Console.WriteLine("Invalid number format for num1.");
				return;
			}

			char operation;
			if(!char.TryParse(args[1], out operation))
			{
				Console.WriteLine("Invalid operation format.");
				return;
			}

			if(!int.TryParse(args[2], out num2))
			{
				Console.WriteLine("Invalid number format for num2.");
				return;
			}


		switch(operation)
		{
			case '+':
				Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
				break;
			case '-':
				Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
				break;
			case '*':
				Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
				break;
			case '/':
				if(num2 != 0)
				{
					Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
				}
				else
				{
					Console.WriteLine("Division by zero is not allowed.");
				}
				break;


		}
		}

	}

}