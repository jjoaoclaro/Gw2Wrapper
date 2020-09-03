using System;
using System.Collections.Generic;
using System.Text;

namespace Gw2.Models.Commerce
{
    /// <summary>
    /// Listing information
    /// </summary>
    public class Listing
    {
        /// <summary>
        /// Number of individual listings of the same price
        /// </summary>
        public int Listings { get; set; }

        /// <summary>
        /// Unit price 
        /// </summary>
        public int UnitPrice { get; set; }

        /// <summary>
        /// Total quantity of this listing
        /// </summary>
        public int Quantity { get; set; }
    }
}
