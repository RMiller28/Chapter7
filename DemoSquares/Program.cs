using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            Square[] SideA = new Square[10];

            for (int i = 0; i < SideA.Length; i++)
            {
                SideA[i] = new Square(i + 10);
                Console.WriteLine(SideA[i].Area);
            }
        }
    }
}