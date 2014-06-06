using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HousePlant
{
    class HousePlants
    {
        
        private bool fed;
        private string name;
        private double price;
        

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public bool Fed
        {
            get
            {
                return fed;
            }

            set
            {
                fed = value;
            }

        }


    }
}