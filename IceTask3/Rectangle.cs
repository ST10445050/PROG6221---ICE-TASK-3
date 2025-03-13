using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask3
{
    public class Rectangle : Shape, ICalculateArea
    {
        // Properties to store Length and Width
        public double Length { get; set; }
        public double Width { get; set; }

        // Custom Constructor 
        public Rectangle(string name, double length, double width) : base(name)
        {
            this.Length = length;
            this.Width = width;
        }

        // Implementing CalculateArea from ICalculateArea
        public double CalculateArea()
        {
            double area = Length * Width;
            return area;
        }

        // Overriding the Display method
        public override void Display()
        {
            Console.WriteLine($"Shape: {Name}");
            Console.WriteLine($"Length: {Length} \nWidth: {Width}");
            double area = CalculateArea();
            Console.WriteLine($"Area of the Rectangle is: {area:F2}");  // Corrected the formatting for area
        }
    }
}






