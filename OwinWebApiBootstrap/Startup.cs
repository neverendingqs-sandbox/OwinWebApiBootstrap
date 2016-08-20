using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using Ninject.Web.Common.OwinHost;
using Ninject;
using System.Reflection;
using Ninject.Web.WebApi.OwinHost;

[assembly: OwinStartup( typeof( OwinWebApiBootstrap.Startup ) )]

namespace OwinWebApiBootstrap {
    public class Startup {

        public void Configuration( IAppBuilder appBuilder ) {
            HttpConfiguration config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();

            appBuilder
                .UseNinjectMiddleware( CreateKernel )
                .UseNinjectWebApi( config );
        }

        private static IKernel CreateKernel() {
            IKernel kernel = new StandardKernel();
            kernel.Load( Assembly.GetExecutingAssembly() );
            return kernel;
        }
    }
}
