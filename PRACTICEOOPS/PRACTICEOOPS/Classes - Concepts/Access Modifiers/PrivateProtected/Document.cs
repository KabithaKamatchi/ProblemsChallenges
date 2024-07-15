

//namespace MyNamespace
//{
//	class PrivateProtected
//	{
//		private protected int privateProtectedField = 30;

//		private protected void PrivateProtectedMethod()
//		{
//			Console.WriteLine("Private protected method in BaseClass");
//		}
//	}

//	class DerivedClass : PrivateProtected
//	{
//		public void AccessPrivateProtectedMembers()
//		{
			
//			Console.WriteLine($"Private Protected Field: {privateProtectedField}");
//			PrivateProtectedMethod();
//		}
//	}

//	class AnotherClassInSameAssembly
//	{
//		public void AccessBaseClassMembers()
//		{
//			PrivateProtected baseObj = new PrivateProtected();

//			// The following lines will cause a compilation error because they are not accessible
//			// Console.WriteLine(baseObj.privateProtectedField);
//			// baseObj.PrivateProtectedMethod();
//		}
//	}

//	class Program
//	{
//		static void Main()
//		{
//			DerivedClass derivedObj = new DerivedClass();

//			// This will work because it's in the derived class within the same assembly
//			derivedObj.AccessPrivateProtectedMembers();

//			AnotherClassInSameAssembly anotherObj = new AnotherClassInSameAssembly();

//			// This will cause a compilation error
//			// anotherObj.AccessBaseClassMembers();
//		}
//	}
//}

