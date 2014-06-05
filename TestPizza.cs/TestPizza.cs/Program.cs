using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Pizza pizza = new Pizza(12);
            pizza.Topping = "Pepperoni";
            double PP = pizza.Price;
            
            double PD = pizza.Diameter;
            
            Console.Write("{0}in ", pizza.Diameter);
            Console.WriteLine(pizza.Price);
            Console.WriteLine(pizza.Topping);
        }
    }
}    
   