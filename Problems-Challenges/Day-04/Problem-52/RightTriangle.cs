namespace RightAngleTriangle;

public class RightTriangle
{
	public static void Solution()
	{
		string strInput = "Jonny";

		for(int i = strInput.Length - 1; i >= 0; i--)
		{
			for(int j = i; j < strInput.Length; j++)
			{
				Console.Write(strInput[j]);
			}
			Console.WriteLine();
		}
	}
}

