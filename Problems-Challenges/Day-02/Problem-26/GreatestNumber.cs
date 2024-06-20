namespace LargestNumber;

public class GreatestNumber
{
	public static void Solution()
	{
		Console.WriteLine("Enter the value of Firstnumber: ");
		int nFirstnumber = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the value of Secondnumber: ");
		int nSecondnumber = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter the value of Thirdnumber: ");
		int nThirdnumber = int.Parse(Console.ReadLine());

		int nGreatest;

		if(nFirstnumber >= nSecondnumber && nFirstnumber >= nThirdnumber)
		{
			nGreatest = nFirstnumber;
		}
		else if(nSecondnumber >= nFirstnumber && nSecondnumber >= nThirdnumber)
		{
			nGreatest = nSecondnumber;
		}
		else
		{
			nGreatest = nThirdnumber;
		}

		Console.WriteLine($"The greatest number : {nGreatest}");
	}
}