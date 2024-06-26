

////namespace TwoDimensionprogram
////{
////	public  class TwoDimensionArray
////	{
////		public static void Solution()
////		{
////			int[] nFirstArray = new int[20];

////            Console.WriteLine("Enter the 20 integer: ");

////			for(int i = 0; i < nFirstArray.Length; i++)
////			{
////				Console.Write("Enter integer {0}: ", i + 1);
////				bool bIsSuccess = int.TryParse(Console.ReadLine(), out nFirstArray[i]);
////				Console.WriteLine(nFirstArray[i]);
////            }


////        }
////	}
////}



//namespace MultiDArray
//{
//	public static class TwoDimensionArray
//	{
//		public static void Demo()
//		{

//			int[,] numbers =new int[2,4];

//			int[] nNum1 = new int[5];

//			int[] nNum2 = new int[5];

//			Console.WriteLine("Please enter 5 integers:");
//			for (int i = 0;  i < nNum1.Length; i++)
//			{
//				Console.WriteLine("Enter the integer");
//				 nNum1[i] = int.Parse(Console.ReadLine());
//                Console.WriteLine($"{nNum1}");
//            }

//			for (int j=0; j <= nNum2.Length;j++)
//			{
//				Console.WriteLine("Enter the integer: ");
//				nNum2[j]=int.Parse(Console.ReadLine());
//				Console.WriteLine($"{nNum2}");
//			}

//			for (int i = 0; i < numbers.GetLength(0); i++)
//			{
//				Console.Write("Row:" );

//				for(int j = 0; j < numbers.GetLength(1); j++)
//				{
//					Console.Write(numbers[i, j] + " ");

//				}
//				Console.WriteLine();

//			}
//		}
//	}
//}
