using Moq;
using NUnit.Framework;
using OwinWebApiBootstrap.HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinWebApiBootstrap.UnitTests.HelloWorld {

    [TestFixture]
    internal sealed class HelloWorldControllerTests {
        Mock<IHelloWorldResponse> m_helloWorldResponse;
        HelloWorldController m_helloWorldController;

        [SetUp]
        public void SetUp() {
            m_helloWorldResponse = new Mock<IHelloWorldResponse>( MockBehavior.Strict );
            m_helloWorldController = new HelloWorldController(
                helloWorld: m_helloWorldResponse.Object
            );
        }

        [Test]
        public void Hello_ReturnsHelloWorld() {
            m_helloWorldResponse
                .Setup( x => x.Hello )
                .Returns( "World" );

            IHelloWorldResponse response = m_helloWorldController.Hello();

            Assert.AreEqual(
                "World",
                response.Hello
            );
        }
    }
}
