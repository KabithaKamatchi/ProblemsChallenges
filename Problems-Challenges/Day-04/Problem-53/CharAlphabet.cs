namespace AlphabetProgram;

public class CharAlphabet
{
	public static void Solution()
	{
		char[] cAlphabet = new char[] {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

		for (int i = 0; i < cAlphabet.Length; i++)
		{
			Console.Write($"{cAlphabet[i]} ");
		}
		
	}
}