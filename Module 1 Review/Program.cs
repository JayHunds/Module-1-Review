namespace Module_1_Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the side length of the square: ");
            double side = double.Parse(Console.ReadLine());


            // Call the method to calculate the area
            double area = CalculateSquareArea(side);

            // Display the result
            Console.WriteLine($"The area of the square with side length {side} is : {area}");
        }

        static double CalculateSquareArea(double side)
        {
            return side * side;
        }
    }
}
