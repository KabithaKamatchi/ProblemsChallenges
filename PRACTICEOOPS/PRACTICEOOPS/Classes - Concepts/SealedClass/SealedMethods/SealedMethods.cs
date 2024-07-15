

//namespace SealedMethodsProgram
//{
//	public class BaseClass
//	{
//		public virtual void Display()
//		{
//			Console.WriteLine("BaseClass Display");
//		}
//	}

//	public class DerivedClass : BaseClass
//	{
//		public sealed override void Display()
//		{
//			Console.WriteLine("DerivedClass Display");
//		}
//	}
//	// the Display method in DerivedClass is sealed, which means it cannot be overridden by any class that might derive from DerivedClass.
//	// This will cause a compile-time error because the method is sealed


//	//public class AnotherDerivedClass : DerivedClass
//	//{
//	//	public override void Display()
//	//	{
//	//		Console.WriteLine("Hii everyone");
//	//	}
//	//}

//	class Program
//	{
//		static void Main()
//		{
//			DerivedClass derivedClass = new DerivedClass();
//			derivedClass.Display();
//		}
//	}

//}
