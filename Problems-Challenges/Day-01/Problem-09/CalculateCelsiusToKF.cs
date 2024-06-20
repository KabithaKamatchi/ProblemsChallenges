using System;
using System.Net.Security;

namespace KelvinFahrenheit;

public class CalculateCelsiusToKF
{
	public static void  Solution()
	{
		Console.WriteLine("Enter the nCelsius");
		int nCelsius = int.Parse(Console.ReadLine());

		int nKelvin = nCelsius + 273;
		int nFahrenheit = ( nCelsius * (18 / 10)) + 32;

		Console.WriteLine($"{nFahrenheit},{nKelvin}");
		
	}
}