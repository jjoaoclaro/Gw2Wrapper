using System;
using System.Collections.Generic;
using System.Text;

namespace Gw2.Models.Commerce
{
    /// <summary>
    /// Exchange information of Gems
    /// </summary>
    public class ExchangeInformation
    {
        /// <summary>
        /// Number of coins for a gem
        /// </summary>
        public int CoinsPerGem { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        public int Quantity { get; set; }
    }
}
