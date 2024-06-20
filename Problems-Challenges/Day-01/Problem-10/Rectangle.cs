using System;

namespace CalculateRectangle 
{
	public class Rectangle
	{
		public static void Solution()
		{
			Console.WriteLine("Enter the width:");
			int nWidth = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter the height:");
			int nHeight = int.Parse(Console.ReadLine());

			int nPerimeter = 2 * (nWidth / nHeight);

			int nArea = nWidth * nHeight;

			double dDiagonal = Math.Sqrt(nWidth * nWidth) + (nHeight * nHeight);

			Console.WriteLine($"Perimeter:{nPerimeter}");
			Console.WriteLine($"Area:{nArea}");
			Console.WriteLine($"Diagonal:{dDiagonal}");
		}
	}
}



