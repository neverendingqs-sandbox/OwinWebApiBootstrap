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

        private static HttpClient m_httpClient;

        [SetUp]
        public void SetUp() {
            m_httpClient = new HttpClient();
            m_httpClient.BaseAddress = new Uri( uriString: baseUri );

            Program.Startup( baseUri: baseUri );
        }

        public static HttpClient GetSharedHttpClient() {
            return m_httpClient;
        }
    }
}
