using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingThing
{
    class LawnMower : iShippable
    {
        public decimal ShipCost
        {
            get { return 24; }
        }

        public string Product
        {
            get { return "LawnMower"; }
        }

    }
}
