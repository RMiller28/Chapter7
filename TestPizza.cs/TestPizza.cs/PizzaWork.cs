using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Pizza
    {
        private string topping;
        private double price;
        private double diameter;


        public Pizza(double Diameter)
        {
            this.Diameter = diameter;
        }

        public double Diameter
        {
            get
            {
                return diameter = 12;
            }

            set
            {
                diameter = value;
            }
        }
        public string Topping
        {
            get
            {
                return topping;
            }
            set
            {
                topping = value;
            }

        }

        public double Price
        {
            get
            {
                return price = 13.99;
            }

            set
            {
                price = value;
            }
        }

    }
}