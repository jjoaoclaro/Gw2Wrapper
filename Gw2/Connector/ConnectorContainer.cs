using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gw2.Connector
{
    /// <summary>
    /// IOT Container
    /// </summary>
    public class ConnectorContainer
    {
        /// <summary>
        /// Configures Services for the connector
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IApiConnector, ApiConnector>();
        }
    }
}
