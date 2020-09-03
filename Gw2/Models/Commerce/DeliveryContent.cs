using System;
using System.Collections.Generic;
using System.Text;

namespace Gw2.Models.Commerce
{
    /// <summary>
    /// GW2 Delivery Content
    /// </summary>
    public class DeliveryContent
    {
        /// <summary>
        /// Quantity of coins for delivery
        /// </summary>
        public int Coins { get; set; }

        /// <summary>
        /// Items available for delivery
        /// </summary>
        public ICollection<Item> Items { get; set; }
    }
}
