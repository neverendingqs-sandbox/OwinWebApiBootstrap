using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace OwinWebApiBootstrap.HelloWorld {
    public class HelloWorldController : ApiController {

        [HttpGet]
        [Route( "" )]
        public IHttpActionResult Hello() {
            return Ok( "Hello!" );
        }
    }
}
