namespace Module_1_Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the rectangle: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());

            // Call the method to calculate the area
            double area = CalculateRectangleArea(length, width);

            // Display the result
            Console.WriteLine($"The area of the rectangle with length {length} and width {width} is: {area}");
        }

        static double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }
    }
}
