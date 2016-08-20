using NUnit.Framework;
using OwinWebApiBootstrap.HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinWebApiBootstrap.UnitTests.HelloWorld {
    [TestFixture]
    internal sealed class HelloWorldResponseTests {

        [Test]
        public void Hello_ReturnsWorld() {
            Assert.AreEqual(
                "World",
                new HelloWorldResponse().Hello
            );
        }
    }
}
