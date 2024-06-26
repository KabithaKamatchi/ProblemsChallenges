

namespace Exception;

public  class NumberException
{
    public static void Solution()
    {
        Console.WriteLine("Enter the Text : "); ;
        string strName = Console.ReadLine();

        try
        {
            Convert.ToInt32(strName);
            Console.WriteLine("It is a number ");
        }
        catch 
        {
            Console.WriteLine("It is not a number ");
         }

    }
}
