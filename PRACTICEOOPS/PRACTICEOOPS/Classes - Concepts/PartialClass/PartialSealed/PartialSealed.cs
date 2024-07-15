

//namespace PartialSealedProgram
//{
//	public sealed partial class SealedPartialPerson
//	{
//		public string FirstName { get; set; }
//		public string LastName { get; set; }

//		public void PrintFullName()
//		{
//			Console.WriteLine($"{FirstName} {LastName}");
//		}
//	}
//	public sealed class SealedPartialPerson1
//	{
//		public string FirstName1 { get; set; }
//		public string LastName1 { get; set; }
//		public int Age { get; set; }
//		public string Address { get; set; }

//		public void PrintFullName()
//		{
//			Console.WriteLine($"{FirstName1} {LastName1}");
//		}

//		public void PrintDetails()
//		{
//			Console.WriteLine($"Name: {FirstName1} {LastName1}, Age: {Age}, Address: {Address}");
//		}
//	}
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			// Creating an instance of SealedPartialPerson
//			SealedPartialPerson person = new SealedPartialPerson();
//			person.FirstName = "John";
//			person.LastName = "Doe";
//			person.PrintFullName();

//			// Adding more details
//			SealedPartialPerson1 person1 = new SealedPartialPerson1();
//			person1.Age = 30;
//			person1.Address = "123 Main St";
//			person1.PrintDetails();

//			Console.ReadKey();
//		}
//	}
//}
