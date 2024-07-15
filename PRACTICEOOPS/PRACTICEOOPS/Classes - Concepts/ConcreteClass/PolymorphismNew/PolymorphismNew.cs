
////Without virtual we use new Keyword -//The new keyword is used to indicate that the Draw method in the derived class
////hides the Draw method in the base class.

//// New Keyword is used - you want to hide the base class method ,
//// when you have a specific reason to hide a base class method.

////Method Hiding: The new keyword hides the base class method instead of overriding it. The method in the derived class is not considered an override.

//namespace WithoutVirtual
//{
//	public class Shape
//	{
//		public void Draw()
//		{
//			Console.WriteLine("Drawing a Shape");
//		}
//	}

//	public class Circle : Shape
//	{
//		public new void Draw()
//		{
//			Console.WriteLine("Drawing a circle");
//		}
//	}

//	public class Square : Shape
//	{
//		public new void Draw()
//		{
//			Console.WriteLine("Drawing a square");
//		}
//	}

//	public class Program
//	{
//		public static void Main(string[] args)
//		{
//			Circle obj = new Circle();
//			obj.Draw();

//			Square obj1 = new Square();
//			obj1.Draw();
//		}
//	}
//}
