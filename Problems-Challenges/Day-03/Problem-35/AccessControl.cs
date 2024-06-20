namespace  ProgramAccess;

public class AccessControl
{
	public static void Solution()
	{
		
		int nMaxAttempts = 3;

		for(int nAttempt = 0; nAttempt < nMaxAttempts; nAttempt++)
		{

			Console.WriteLine("Enter the username: ");
			int nLogin = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the password: ");
			int nPassword = Convert.ToInt32(Console.ReadLine());

			if(nLogin == 12 && nPassword == 1234)
			{
				Console.WriteLine("LoginSuccessfull");

			}
			else
			{
				Console.WriteLine("LoginFailed");
			}

		}
		Console.WriteLine("Maximum attempt exceeded");
		
	}
}