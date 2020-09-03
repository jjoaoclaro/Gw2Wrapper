using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Gw2.Connector
{
    /// <summary>
    /// Guild Wars 2 Api Connector
    /// </summary>
    public class ApiConnector : IApiConnector
    {
        private string ApiKey = "092F6929-EF22-C546-82FF-49A3C5DB1D5EFE0DEC94-979F-4A61-9347-445DB917606F";
        private static readonly HttpClient client = new HttpClient();

        /// <summary>
        /// Constructor for the Connector
        /// </summary>
        /// <param name="ApiKey"></param>
        public ApiConnector(string ApiKey)
        {
            this.ApiKey = ApiKey;
        }

        /// <summary>
        /// Makes the Api Call for a specific endpoint
        /// </summary>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        public string ApiCall(string endpoint)
        {
            return ApiCall(endpoint, this.ApiKey);
        }

        /// <summary>
        /// Makes the Api Call for a specific endpoint
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="apiKey"></param>
        /// <returns></returns>
        public string ApiCall(string endpoint, string apiKey)
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

            string requestUri = @"https://api.guildwars2.com/" + endpoint;
            var stringTask = client.GetAsync(requestUri);
            stringTask.Wait();
            var result = stringTask.Result;

            return result.Content.ReadAsStringAsync().Result;
        }

        //public string ApiCallWithParams(string endpoint, params object[] parameters)
        //{
        //    client.DefaultRequestHeaders.Clear();
        //    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {this.ApiKey}");
            
        //    string requestUri = @"https://api.guildwars2.com/" + endpoint;
        //    var stringTask = client.GetAsync(requestUri);
        //    stringTask.Wait();
        //    var result = stringTask.Result;

        //    return result.Content.ReadAsStringAsync().Result;
        //}
    }
}
