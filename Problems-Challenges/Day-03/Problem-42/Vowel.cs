namespace VowelsSwitch;

public class Vowel
{
	public static void Solution()
	{
		Console.WriteLine("Enter the Letter : ");
		string strLetter = Console.ReadLine();

		char cLowerInput = char.ToLower(strLetter[0]);

		switch(cLowerInput)
		{
			case 'a':
			case 'e':
			case 'i':
			case 'o':
			case 'u':
				Console.WriteLine("Vowel");
				break;

			default:
				Console.WriteLine("Other symbol");
				break;

		}
	}
}