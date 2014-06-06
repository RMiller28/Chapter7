using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HousePlant
{
    class DisplayHousePlants
    {
        static void Main(string[] args)
        {
            HousePlants houseplants, houseplantsA, houseplantsB;
            houseplants = new houseplants();
            houseplantsA = new houseplantsA();
            houseplantsB = new houseplantsB();

            houseplants.Name = "Philodendron";
            houseplants.Fed = true;
            houseplants.Price = 29.99;

            houseplantsA.Name = "Dandelion";
            houseplantsA.Fed = true;
            houseplantsA.Price = 10.99;

            houseplantsB.Name = "Rose";
            houseplantsB.Fed = false;
            houseplantsB.Price = 22.99;

            Console.WriteLine(houseplants.Name);
            Console.WriteLine(houseplants.Fed);
            Console.WriteLine(houseplants.Price);

            Console.WriteLine(houseplantsA.Name);
            Console.WriteLine(houseplantsA.Fed);
            Console.WriteLine(houseplantsA.Price);

            Console.WriteLine(houseplantsB.Name);
            Console.WriteLine(houseplantsB.Fed);
            Console.WriteLine(houseplantsB.Price);

        }
    }
}





        