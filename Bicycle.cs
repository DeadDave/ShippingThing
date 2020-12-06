using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingThing
{
    class Bicycle : iShippable
    {
        // Using the count in each class instead of on call:

        //private static int Count =0;

        //public Bicycle()
        //{
        //    Count++;
        //}

        public decimal ShipCost
        {
            get { return 20.50M; }
        }

        public string Product
        {
            get { return "Bicycle"; }
        }

    }
}
