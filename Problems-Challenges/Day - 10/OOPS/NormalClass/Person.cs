
namespace ProgramClass
{
	public class Person
	{
		private string strName;
		private int nAge;

		public string Name
		{
			get { return strName;}
			set{ strName = value; }				
		}

		public int Age 
		{
			get { return nAge;}
			set{ nAge = value; }
		}


		public Person(string strName, int nAge)
		{
			this.strName = strName;
			this.nAge = nAge;
		}

		    public void Introduce()
		{
				Console.WriteLine($"My name is {strName} and Age is {nAge} "); 
		}
	}

	//class Program
	//{
	//	static void Main(string[] args)
	//	{
	//		Person obj1 = new Person("Kabi", 21);
	//		obj1.Introduce();

	//	}

	//}
}

