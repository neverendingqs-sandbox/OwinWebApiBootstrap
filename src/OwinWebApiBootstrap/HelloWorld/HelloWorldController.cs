using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace OwinWebApiBootstrap.HelloWorld {
    public sealed class HelloWorldController : ApiController {

        public IHelloWorldResponse m_helloWorld { get; }

        public HelloWorldController(
            IHelloWorldResponse helloWorld
        ) {
            m_helloWorld = helloWorld;
        }

        [HttpGet]
        [Route( "" )]
        public IHelloWorldResponse Hello() {
            return m_helloWorld;
        }
    }
}
