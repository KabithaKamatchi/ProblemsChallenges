namespace CondtionalOperatorProgram;

public class ConditionalOperator
{
    public static void Solution()
    {
        Console.WriteLine("Enter the first integer : ");
        bool bIsSuccess1 = int.TryParse(Console.ReadLine(),out int nFirstInteger);


        Console.WriteLine("Enter the second integer : ");
        bool bIsSuccess2 = int.TryParse(Console.ReadLine(), out int nSecondInteger);

        if ((nFirstInteger % 2 == 0) && (nSecondInteger % 2 == 0))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }



    }
}