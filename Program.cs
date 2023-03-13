// C# program to find total area of two
// overlapping Rectangles
using System;

class GFG {
	public class Point {
		public double x, y;

		public Point(double x, double y)
		{
			this.x = x;
			this.y = y;
		}
	};

	// Returns Total Area of two overlap
	// rectangles
	static double overlappingArea(Point l1, Point r1, Point l2,
							Point r2)
	{
		// Area of 1st Rectangle
		double area1
			= Math.Abs(l1.x - r1.x) * Math.Abs(l1.y - r1.y);

		// Area of 2nd Rectangle
		double area2
			= Math.Abs(l2.x - r2.x) * Math.Abs(l2.y - r2.y);

		// Length of intersecting part i.e
		// start from max(l1.x, l2.x) of
		// x-coordinate and end at min(r1.x,
		// r2.x) x-coordinate by subtracting
		// start from end we get required
		// lengths
		double x_dist
			= (Math.Min(r1.x, r2.x) - Math.Max(l1.x, l2.x));
		double y_dist
			= (Math.Min(r1.y, r2.y) - Math.Max(l1.y, l2.y));
		double areaI = 0;
		if (x_dist > 0 && y_dist > 0) {
			areaI = x_dist * y_dist;
		}

		return (area1 + area2 - areaI);
	}

	// Driver Code
	public static void Main(String[] args)
	{
		Console.Write("Please input x-coordinate of the center of rectangle 1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please input y-coordinate of the center of rectangle 1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please input width of rectangle 1: ");
        double w1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please input height of rectangle 1: ");
        double h1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please input x-coordinate of the center of rectangle 2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please input y-coordinate of the center of rectangle 2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please input width of rectangle 2: ");
        double w2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please input height of rectangle 2: ");
        double h2 = Convert.ToDouble(Console.ReadLine());
        
        double xl1 = x1 - (w1/2);
        double xl2 = x2 - (w2/2);
        double yl1 = y1 + (h1/2);
        double yl2 = y2 + (h2/2);

        double xr1 = x1 + (w1/2);
        double xr2 = x2 + (w2/2);
        double yr1 = y1 - (h1/2);
        double yr2 = y2 - (h2/2);

        
        Point l1 = new Point(xl1, yl1), r1 = new Point(xr1, yr1);
		Point l2 = new Point(xl2, yl2), r2 = new Point(xr2, yr2);

		Console.WriteLine(overlappingArea(l1, r1, l2, r2));
		if (overlappingArea(l1, r1, l2, r2)>8)
        {
            Console.WriteLine("Too Much Overlaping");
        }
        else if (overlappingArea(l1, r1, l2, r2)>0)
        {
            Console.WriteLine("Not Much Overlapping");
        }
        else
        {
            Console.WriteLine("No Overlapping");
        }
        
	}
}


