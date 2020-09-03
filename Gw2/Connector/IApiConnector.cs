using System;
using System.Collections.Generic;
using System.Text;

namespace Gw2.Connector
{
    /// <summary>
    /// Interface for Api Connector
    /// </summary>
    public interface IApiConnector
    {
        /// <summary>
        /// Makes the Api Call for a specific endpoint
        /// </summary>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        string ApiCall(string endpoint);

        /// <summary>
        /// Makes the Api Call for a specific endpoint
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="apiKey"></param>
        /// <returns></returns>
        string ApiCall(string endpoint, string apiKey);
    }
}
