using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinWebApiBootstrap.HelloWorld {
    public class HelloWorld : IHelloWorld {

        public string Hello() {
            return "Hello";
        }
    }
}
