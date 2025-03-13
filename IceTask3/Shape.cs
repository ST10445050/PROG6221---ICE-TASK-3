using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask3
{
   public abstract class Shape
    {
        // Property to store Name
        public string Name { get; set; }  

        // Constructor 
        public Shape(string name)
        {
            this.Name = name;
        }

        // Virtual Display Method
        public virtual void Display()
        {
            Console.WriteLine($"Shape: {Name}");
        }
    }

}
