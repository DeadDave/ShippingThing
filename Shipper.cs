using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingThing
{
    class Shipper
    {
        List<iShippable> products = new List<iShippable>();
        
        public Boolean Add(iShippable newItem)
        {
            products.Add(newItem);
            return true;
        }


        public decimal getCost()
        {
            decimal TotalCost = 0;
            foreach (iShippable item in products)
            {
                TotalCost += item.ShipCost;
            }
            return TotalCost;
        }

        public string Manifest()
        {
            int GloveC = 0;
            int MowerC = 0;
            int CrackerC = 0;
            int BicycleC = 0;
            string listOfStuff =string.Empty;
            foreach (iShippable item in products)
            {
                if (item.Product == "BaseBallGlove")
                    GloveC++;
                if (item.Product == "LawnMower")
                    MowerC++;
                if (item.Product == "Cracker")
                    CrackerC++;
                if (item.Product == "Bicycle")
                    BicycleC++;
                
             
                listOfStuff = listOfStuff + item.Product + Environment.NewLine;
            
            }
            return GloveC + "\t" + (GloveC== 1? " Baseball Glove": " Baseball Gloves") + "\n" +
            MowerC + "\t" + (MowerC== 1? " Lawnmower": " Lawnmowers") + "\n" +
            CrackerC + "\t" + (CrackerC == 1 ? " Cracker Box": " Cracker Boxes") + "\n" +
            BicycleC + "\t" + (BicycleC == 1 ? " Bicycle": " Bicycles") + "\n";

        }
    }
}
