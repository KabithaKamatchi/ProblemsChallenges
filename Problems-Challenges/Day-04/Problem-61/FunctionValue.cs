public class FunctionValue
{
    public static void Solution()
    {
        Console.WriteLine("Enter the integer: ");
        bool bIsSucess1 = int.TryParse(Console.ReadLine(), out int nNum1);


        Console.WriteLine("Enter the integer: ");
        bool bIsSucess2 = int.TryParse(Console.ReadLine(), out int nNum2);

        int nSum = Sum(nNum1,nNum2);
        Console.WriteLine(nSum);
    }

    public static int Sum(int nNum1, int nNum2)
    {
        return nNum1 + nNum2;
    }
}