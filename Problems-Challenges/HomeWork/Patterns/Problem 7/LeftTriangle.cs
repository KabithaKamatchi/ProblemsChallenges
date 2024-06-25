
using System;

namespace LeftTrianglePattern;

public class LeftTriangle
{
	public static void Solution()
	{
		//Console.WriteLine("Enter the integer: ");
		//bool bIsSuccess1 = int.TryParse(Console.ReadLine(), out int nValue1);

		//Console.WriteLine("Enter the integer: ");
		//bool bIsSuccess2 = int.TryParse(Console.ReadLine(), out int nValue2);

		for (int i = -1 ; i <= 8; i++)
		{
			int y = (i - 4) * ( i - 4);

			for (int j = -1; j <= y; j++)
			{
                Console.Write("* ");
            }
		}	
			Console.WriteLine();
		}
	}


           