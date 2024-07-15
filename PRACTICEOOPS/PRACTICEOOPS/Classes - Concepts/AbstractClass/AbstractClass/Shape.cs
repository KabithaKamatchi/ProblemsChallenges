
//namespace AbstractProgram

//{
//	public abstract class Shape
//	{
//		public abstract double Area { get; }
//		public abstract double Perimeter { get; }

//		public abstract void Draw();
//	}

//	public class Circle : Shape
//	{
//		public double Radius { get; set; }

//		public Circle(double radius)
//		{
//			Radius = radius;
//		}

//		public override double Area => Math.PI * Radius * Radius;
//		public override double Perimeter => 2 * Math.PI * Radius;

//		public override void Draw()
//		{
//			Console.WriteLine("Drawing a circle.");
//		}
//	}

//	public class Square : Shape
//	{
//		public double Side { get; set; }

//		public Square(double side)
//		{
//			Side = side;
//		}

//		public override double Area => Side * Side;
//		public override double Perimeter => 4 * Side;

//		public override void Draw()
//		{
//			Console.WriteLine("Drawing a square.");
//		}
//	}

//	class Program
//	{
//		static void Main()
//		{
//			Shape circle = new Circle(5);
//			circle.Draw();
//			Console.WriteLine($"Area: {circle.Area}, Perimeter: {circle.Perimeter}");

//			Shape square = new Square(4);
//			square.Draw();
//			Console.WriteLine($"Area: {square.Area}, Perimeter: {square.Perimeter}");
//		}
//	}

//}