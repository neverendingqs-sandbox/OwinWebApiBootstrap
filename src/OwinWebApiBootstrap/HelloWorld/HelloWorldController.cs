using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace OwinWebApiBootstrap.HelloWorld {
    public class HelloWorldController : ApiController {

        public IHelloWorld m_helloWorld { get; }

        public HelloWorldController(
            IHelloWorld helloWorld
        ) {
            m_helloWorld = helloWorld;
        }

        [HttpGet]
        [Route( "" )]
        public IHelloWorld Hello() {
            return m_helloWorld;
        }
    }
}
