using System;

namespace Dimension;

public class  CalculateSurfaceVolume
{
	public static void   Solution()
	{
		Console.WriteLine("Enter the radius of sphere");
		double dRadius = Convert.ToDouble(Console.ReadLine());

		double dPi = 3.14;
		double dSurface = 4 * dPi * dRadius;

		double dVolume = 4/3 * dPi * dRadius;

		Console.WriteLine($"Surface of the sphere:{dSurface:F2}");
		Console.WriteLine($"Volume of the sphere:{dVolume:F2}");
	}
}