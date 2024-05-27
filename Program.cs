
using Triangles;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose mode (1 - for equilateral triangle or 2 - for any triangle):");
        char userChoose = Convert.ToChar(Console.ReadLine());


        if (userChoose == '1')
        {
            Console.WriteLine("Enter side length of the equilateral triangle:");
            double sideLengthEquilateral = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Equilateral Triangle Characteristics:");
            EquilateralTriangle dynamicTriangle = new EquilateralTriangle();
            dynamicTriangle.SetValues(sideLengthEquilateral, 60);

            Console.WriteLine("Side Lengths: " + string.Join(", ", dynamicTriangle.GetSideLengths()));
            Console.WriteLine("Perimeter: " + dynamicTriangle.CalculatePerimeter());
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Enter side length of the triangle:");
            double sideLengthTriangle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter first angle of the triangle:");
            double firstAngleTriangle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second angle of the triangle:");
            double secondAngleTriangle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Triangle Characteristics:");

            Triangle dynamicTriangle = new Triangle();
            dynamicTriangle.SetValues(sideLengthTriangle, firstAngleTriangle, secondAngleTriangle);
            Console.WriteLine("Side Lengths: " + string.Join(", ", dynamicTriangle.GetSideLengths()));
            Console.WriteLine("Angles: " + string.Join(", ", dynamicTriangle.GetAngles()));
            Console.WriteLine("Perimeter: " + dynamicTriangle.CalculatePerimeter());
        }


        

        

        
    }
}