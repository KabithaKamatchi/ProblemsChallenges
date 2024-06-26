

namespace CharacterPyramidPattern;

public class CharacterPyramid
{
	public static void Solution()
	{
		Console.WriteLine("Enter the string: ");
		string strName = Console.ReadLine();


		for(int i = 0; i < strName.Length; i++)
		{
			for(int s = 0; s < strName.Length - i ; s++)
			{
				Console.Write(" ");
			}
			for(int j = 0; j < i + 1; j++)
			{
				Console.Write($"{strName} ");
			}

			Console.WriteLine(" ");
		}
	}

}
