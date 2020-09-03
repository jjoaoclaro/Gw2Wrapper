using System;
using System.Collections.Generic;
using System.Text;

namespace Gw2.Models.Commerce
{
    /// <summary>
    /// Listing item information
    /// </summary>
    public class ListingItem
    {
        /// <summary>
        /// Id of the item
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Collection of Buying Listings
        /// </summary>
        public IEnumerable<Listing> Buys { get; set; }

        /// <summary>
        /// Collection of Selling Listings
        /// </summary>
        public IEnumerable<Listing> Sells { get; set; }
    }
}
