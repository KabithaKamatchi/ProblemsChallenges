
namespace InterfaceProgram
{
	public  interface IShape
	{
		double dArea();
	}

	public interface IRenderable
	{
		void Render();
	}


	public class Circle : IShape , IRenderable
	{
		public double dRadius
		{
			get;
			set;
		}

		public Circle(double dRadius1)
		{
			dRadius = dRadius1;
		}

		public double dArea()
		{
			return Math.PI * dRadius * dRadius;
		}

		public void Render()
		{
            Console.WriteLine($"Rendering a circle with radius:{dRadius}");
          }
	}

	public class Program
	{
		public static void Main(string[] args)
		{
			Circle myobj = new Circle(10);

			IShape shape = myobj;
			Console.WriteLine($"Area of the circle:{shape.dArea()}");

			IRenderable render = myobj;
		    render.Render();
			
			
		}
	}
}
