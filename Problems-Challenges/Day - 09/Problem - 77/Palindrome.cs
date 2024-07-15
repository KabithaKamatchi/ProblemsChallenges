
namespace PalindromeProgram
{
	public  class Palindrome
	{
		public static void Solution()
		{
			Console.WriteLine("Enter the String: ");
			string strText = Console.ReadLine();

			bool isPalindrome = CalculatePalindrome(strText);

			 if(isPalindrome)
			{
				Console.WriteLine("The String is Palindrome.");
			}
			 else
			{
				Console.WriteLine("The String is not a Palindrome");
			}
		}

		public static bool CalculatePalindrome(string strText)
		{
			int  nLength = strText.Length;

			for (int i = 0; i< nLength / 2; i++)
			{
				if(strText[i] != strText[nLength - 1- i])
				{
					return false;
				}
			}
			return true;
		}
		
	}
}
