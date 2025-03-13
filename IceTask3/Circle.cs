using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask3
{
    public class Circle : Shape, ICalculateArea
    {
        // Property to store Radius
        public double Radius { get; set; }


        // Custom Constructor
        public Circle(string name, double radius) : base(name)
        {
            this.Radius = radius;
        }

        // Implementing CalculateArea from ICalculateArea
        public double CalculateArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);  
            return area;  
        }

        // Overriding the Display method 
        public override void Display()
        {
           
            Console.WriteLine($"Shape: {Name}");
            Console.WriteLine($"Radius of the Circle: {Radius}");
            double area = CalculateArea();  
            Console.WriteLine($"Area of the Circle is: {area:F2}");  
        }
    }


}
