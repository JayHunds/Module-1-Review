namespace Module_1_Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            double area = CalculateCircleArea(radius);

            Console.WriteLine($"The area of the circle with radius {radius} is: {area}");
        }

        static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
