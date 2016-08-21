using NUnit.Framework;
using OwinWebApiBootstrap.HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OwinWebApiBootstrap.IntegrationTests.HelloWorld {

    [TestFixture]
    internal sealed class HelloWorldControllerTests {
        private HttpClient m_httpClient;

        [SetUp]
        public void SetUp() {
            m_httpClient = SetUpFixture.GetHttpClient();
        }

        [Test]
        public async Task Hello_ReturnsHelloWorld() {
            using( HttpResponseMessage response = await m_httpClient.GetAsync( "" ) ) {
                IHelloWorldResponse helloWorldResponse = await response
                    .Content
                    .ReadAsAsync<HelloWorldResponse>();

                Assert.AreEqual(
                    "World",
                    helloWorldResponse.Hello
                );
            }
        }
    }
}
