namespace Module_1_Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the base length of the triangle: ");
            double baseLength = double.Parse(Console.ReadLine());

            Console.Write("Enter the height of the triangle: ");
            double height = double.Parse(Console.ReadLine());

            // Call the method to calculate the area
            double area = CalculateTriangleArea(baseLength, height);

            // Display the result
            Console.WriteLine($"The area of the triangle with base length {baseLength} and height {height} is: {area}");
        }

        static double CalculateTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }
    }
}
