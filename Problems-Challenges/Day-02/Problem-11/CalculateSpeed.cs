using System;

namespace Distance;

public class CalculateSpeed
{
	public static void Solution()
	{
		Console.WriteLine("Enter the distance: ");
		float fDistance = float.Parse(Console.ReadLine());

		Console.WriteLine("Enter the hours: ");
		float fHours = float.Parse(Console.ReadLine());

		Console.WriteLine("Enter the minutes: ");
		float fMinutes = float.Parse(Console.ReadLine());

		Console.WriteLine("Enter the Seconds: ");
		float fSeconds = float.Parse(Console.ReadLine());

		float fTotalTime = (fHours * 3600) + (fMinutes * 60) + fSeconds;

		float fSpeedInMeters = fDistance / fTotalTime;

		float fSpeedInKilometers = (fDistance / 1000) / (fTotalTime * 3600);

		float fSpeedInMiles = (fDistance / 1609) / (fTotalTime / 3600);
		

		Console.WriteLine($"SpeedInMeterPerSecond: {fSpeedInMeters:F2} ");
		Console.WriteLine($"SpeedInKilometersPerSecond: {fSpeedInKilometers:F2}");
		Console.WriteLine($"SpeedInMilesPerSecond: {fSpeedInMiles:F2}");
	}
}