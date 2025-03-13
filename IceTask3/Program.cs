namespace IceTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of Rectangle
            Rectangle r = new Rectangle("Rectangle", 5, 3); 
            r.Display();  

            Console.WriteLine();
            Console.WriteLine("*******************************");
            Console.WriteLine();


           // Creating an instance of Circle
            Circle c = new Circle("Circle", 5);  
            c.Display();  // Display the circle's info and area

            Console.ReadKey(); 
        }
    }
}
