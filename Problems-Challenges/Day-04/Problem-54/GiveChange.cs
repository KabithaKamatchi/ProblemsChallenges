namespace GiveChangeProgram;

public class GiveChange
{
    public static void Solution()
    {
        

             Console.WriteLine("Enter the total amount of money in the cash register:");
             bool bIsSuccess1 = int.TryParse(Console.ReadLine(), out int nCashAmount);

             Console.WriteLine("Enter the purchase value:");
            bool bIsSuccess2 = int.TryParse(Console.ReadLine(), out int nPurchaseValue);

            int nChange = nCashAmount - nPurchaseValue;

            int[] nBills = { 100, 50, 20, 10, 5, 2, 1 };

            Console.WriteLine("Change to be returned: " + nChange);

        
            foreach (int newbill in nBills)
            {
                if (nChange >= newbill)
                {
                    int billCount = nChange / newbill;
                    nChange -= billCount * newbill;
                    Console.WriteLine($"{billCount} bill(s) of {newbill}");
                }
            }
            if (nChange > 0)
            {
                Console.WriteLine("Remaining change: " + nChange);
            }
        }
    }


