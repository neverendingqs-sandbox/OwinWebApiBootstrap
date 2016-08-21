using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OwinWebApiBootstrap.IntegrationTests {
    [SetUpFixture]
    internal sealed class SetUpFixture {
        const string baseUri = "http://localhost:8081";

        [SetUp]
        public void SetUp() {
            Program.Startup( baseUri: baseUri );
        }

        public static HttpClient GetHttpClient() {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri( uriString: baseUri );
            return httpClient;
        }
    }
}
