﻿

namespace InvertedPattern
{
	public  class InvertedRightTriangle1
	{
		 public static void Solution1()
		{
			Console.WriteLine("Enter the integer: ");
			int nNum1 = int.Parse(Console.ReadLine());

			for (int i = 0; i < nNum1; i++)
			{
				for (int j = 0; j < nNum1 - i ; j++)
				{
					Console.Write($"{nNum1} ");
				}
				Console.WriteLine();
			}
		}
	}
}