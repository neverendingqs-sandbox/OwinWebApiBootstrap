using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup( typeof( OwinWebApiBootstrap.Startup ) )]

namespace OwinWebApiBootstrap {
    public class Startup {
        public void Configuration( IAppBuilder appBuilder ) {
            HttpConfiguration config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            appBuilder.UseWebApi( config );
        }
    }
}
