//using System;

//namespace ProgramInherit
//{
//	static class StaticInherit1
//	{
//		public static string StrName = "Kabitha";

//		public static void Eat()
//		{
//			Console.WriteLine($"{StrName} is eating.");
//		}
//	}

//				// Static class cannot inherit from another class

//				//class StaticInherit2 : StaticInherit1
//				//{
//				//	public void Friends()
//				//	{

//				//		Console.WriteLine($"{strName} and Jenifar are friends ");
//				//	}
//				//}                                                // This line is incorrect and will cause a compilation error

//static class StaticInherit2
//{
//	public static void Friends()
//	{
//		Console.WriteLine($"{StaticInherit1.StrName} and Jenifar are friends.");
//	}
//}

//public class Program
//{
//	static void Main(string[] args)
//	{
//		StaticInherit1.Eat(); // Accessing static method from NonStaticInherit1
//		StaticInherit2.Friends(); // Accessing static method from NonStaticInherit2
//	}
//}
//}









//public class MyClass
//{
//	public static int instanceField = 42;
//	public int staticField = 100;


//	public class program
//	{
//		public static void Main()
//		{
//////////////////MyClass obj1 = new MyClass();
//////////////////Console.WriteLine(obj1.staticField);

//Console.WriteLine($"{instanceField}");

//        }
//	}


//}



