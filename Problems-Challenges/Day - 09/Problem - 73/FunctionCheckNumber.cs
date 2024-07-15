
namespace  FunctionValidateNumber
{
	public  class CheckNumber
	{
		  public static void Solution()
		{
            Console.WriteLine(" Enter the nValues: ");
			_ = int.TryParse(Console.ReadLine(), out int  nResult);


			bool bIsSuccess = IsNumber(nResult);


			Console.WriteLine(bIsSuccess);
        }

		public static bool IsNumber(int nValues)
		{
			return  nValues > 0;

		}
		}
	}

