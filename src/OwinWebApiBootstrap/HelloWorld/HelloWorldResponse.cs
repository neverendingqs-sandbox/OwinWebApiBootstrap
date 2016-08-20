using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinWebApiBootstrap.HelloWorld {
    internal class HelloWorldResponse : IHelloWorldResponse {
        public string Hello { get; } = "World";
    }
}
