using Gw2.Connector;
using Gw2.Mapper;
using Gw2.Models.Commerce;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gw2.Commerce
{
    /// <summary>
    /// Object for commerce calls
    /// </summary>
    public class Commerce
    {
        private static string commerceEndpoint = "v2/commerce/";
        private static string deliveryEndpoint = "v2/commerce/delivery";
        private static string exchangeCoinsEndpoint = "v2/commerce/exchange/coins";
        private static string exchangeGemsEndpoint = "v2/commerce/exchange/gems";
        private static string listingsEndpoint = "v2/commerce/listings";
        private IApiConnector apiConnector;
        private IApiMapper apiMapper;

        public Commerce(IApiConnector apiConnector, IApiMapper apiMapper)
        {
            this.apiConnector = apiConnector;
            this.apiMapper = apiMapper;
        }

        /// <summary>
        /// Gets the Delivery Content from the delivery endpoint of GW2 API
        /// </summary>
        public DeliveryContent GetDeliveryContent()
        {
            return this.apiMapper.MapTo<DeliveryContent>(apiConnector.ApiCall(deliveryEndpoint, Gw2.ApiKey));
        }

        /// <summary>
        /// Gets the Exchange information of coins to gems exchange rate
        /// </summary>
        /// <returns></returns>
        public ExchangeInformation GetCoins(int coinsQuantity)
        {
            return this.apiMapper.MapTo<ExchangeInformation>(apiConnector.ApiCall($"{exchangeCoinsEndpoint}/{coinsQuantity}", Gw2.ApiKey));
        }

        /// <summary>
        /// Gets the Exchange information of gems to coins exchange rate
        /// </summary>
        /// <returns></returns>
        public ExchangeInformation GetGems(int coinsQuantity)
        {
            return this.apiMapper.MapTo<ExchangeInformation>(apiConnector.ApiCall($"{exchangeGemsEndpoint}/{coinsQuantity}", Gw2.ApiKey));
        }

    }
}
