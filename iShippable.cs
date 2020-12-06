using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingThing
{
    interface iShippable
    {
        decimal ShipCost { get; }
        string Product { get; }
    }
}
