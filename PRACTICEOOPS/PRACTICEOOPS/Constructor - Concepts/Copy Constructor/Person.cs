
//namespace CopyConstructor
//{
//	public class Person
//	{
//		public string Name { get; set; }
//		public int Age { get; set; }

//		// Parameterized constructor
//		public Person(string name, int age)
//		{
//			Name = name;
//			Age = age;
//		}

//		// Copy constructor
//		public Person(Person person)
//		{
//			Name = person.Name;
//			Age = person.Age;
//		}

//		public void Display()
//		{
//			Console.WriteLine($"Name: {Name}, Age: {Age}");
//		}
//	}

//	public class Program
//	{
//		public static void Main()
//		{

//			Person person1 = new Person("John Doe", 30);    // parameterized constructor
//			person1.Display();


//			Person person2 = new Person(person1);           // copy constructor
//			person2.Display();
//		}
//	}

//}
