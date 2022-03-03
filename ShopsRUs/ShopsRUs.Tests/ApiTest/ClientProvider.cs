using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using ShopsRUs.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Tests.ApiTest
{
    public class ClientProvider
    {
        public HttpClient Client { get; set; }

        public ClientProvider()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = server.CreateClient();
        }
    }
}
