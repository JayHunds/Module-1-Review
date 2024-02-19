namespace Module_1_Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Circle
            Console.WriteLine("Enter the radius of the circle:");
            double circleRadius = double.Parse(Console.ReadLine());
            double circleArea = CalculateCircleArea(circleRadius);
            Console.WriteLine($"Area of the circle with radius {circleRadius} is: {circleArea}");
            //Triangle
            Console.WriteLine("Enter the base length of the triangle:");
            double triangleBase = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the triangle:");
            double triangleHeight = double.Parse(Console.ReadLine());
            double triangleArea = CalculateTriangleArea(triangleBase, triangleHeight);
            Console.WriteLine($"Area of the triangle with base {triangleBase} and height {triangleHeight} is: {triangleArea}");
            //Rectangle
            Console.WriteLine("Enter the length of the rectangle:");
            double rectangleLength = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle:");
            double rectangleWidth = double.Parse(Console.ReadLine());
            double rectangleArea = CalculateRectangleArea(rectangleLength, rectangleWidth);
            Console.WriteLine($"Area of the rectangle with length {rectangleLength} and width {rectangleWidth} is: {rectangleArea}");
            //Square
            Console.WriteLine("Enter the side length of the square:");
            double squareSide = double.Parse(Console.ReadLine());
            double squareArea = CalculateSquareArea(squareSide);
            Console.WriteLine($"Area of the square with side length {squareSide} is: {squareArea}");
        }

        static double CalculateCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        static double CalculateTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        static double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }

        static double CalculateSquareArea(double side)
        {
            return Math.Pow(side, 2);
        }
    }
}

