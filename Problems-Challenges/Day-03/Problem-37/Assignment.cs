namespace AssignmentProgram;

public class Assignment
{
	public static void Solution()
	{
		Console.WriteLine("Enter the number: ");
		int nNumber = int.Parse(Console.ReadLine());

		switch(nNumber)
		{
			case 10:
				Console.WriteLine("A+");
				break;

			case 9:
				Console.WriteLine("A");
				break;

			case 7:
				Console.WriteLine("B");
				break;

			case 8:
			Console.WriteLine("B");
			break;

			case 6:
				Console.WriteLine("C");
				break;

			case 5:
				Console.WriteLine("E");
				break;

			default:
				Console.WriteLine("F");
				break;

		}
	}
}