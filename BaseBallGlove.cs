using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingThing
{
    class BaseBallGlove : iShippable
    {
        public decimal ShipCost
        {
            get { return 3.23M; }
        }

        public string Product
        {
            get { return "BaseBallGlove"; }
        }
    }
}