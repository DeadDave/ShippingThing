using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingThing
{
    class Cracker : iShippable
    {
        public decimal ShipCost
        {
            get { return .57M; }
        }

        public string Product
        {
            get { return "Cracker"; }
        }

    }
}