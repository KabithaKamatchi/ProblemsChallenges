

//public abstract class Account
//{
//	public int AccountNumber { get; set; }
//	public double Balance { get;  set; }

	
//	public abstract void Deposit(double dAmount);
//	public abstract void Withdraw(double dAmount);

	
//	public void DisplayBalance()
//	{
//		Console.WriteLine($"Account Number: {AccountNumber}, Balance: {Balance}");
//	}
//}

//public class SavingsAccount : Account
//{
//	public override void Deposit(double dAmount)
//	{
//		Balance += dAmount;
//		Console.WriteLine($"{dAmount} deposited into Savings Account.");
//	}

//	public override void Withdraw(double dAmount)
//	{
//		if(Balance >= dAmount)
//		{
//			Balance -= dAmount;
//			Console.WriteLine($"{dAmount} withdrawn from Savings Account.");
//		}
//		else
//		{
//			Console.WriteLine("Insufficient funds.");
//		}
//	}
//}
//public class Program
//{
//	public static void Main()
//	{
//		SavingsAccount savings = new SavingsAccount();
//		savings.AccountNumber = 12345;
//		savings.Deposit(1000.0);
//		savings.Withdraw(200.0);
//		savings.DisplayBalance(); 
//	}
//}
