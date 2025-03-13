namespace IceTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Rectangle
            Shape rectangle = new Rectangle("Rectangle", 5, 10);

            Console.WriteLine();
            Console.WriteLine("********************************");
            Console.WriteLine();


            // Create an instance of Circle
            Shape circle = new Circle("Circle", 7);
            circle.Display();

            Console.ReadKey();
        }
    }
}
