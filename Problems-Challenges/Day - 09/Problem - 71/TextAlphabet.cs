
namespace FunctionCheckText
{
	class  TextAlphabet
	{
		public static void Solution()
		{
			Console.WriteLine("Enter the text: ");
			string strResult = Console.ReadLine();

			bool bIsSuccess1 = IsAlphabetic(strResult);
			Console.WriteLine(bIsSuccess1);
		}
		public static  bool IsAlphabetic(string strText)
		{
        foreach (char c in strText)
			{
				if(!char.IsLetter(c))
				{
					return false;
				}
			}
			return true;
		}
	}
}

