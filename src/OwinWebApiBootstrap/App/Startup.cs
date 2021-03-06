﻿using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using Ninject.Web.Common.OwinHost;
using Ninject;
using System.Reflection;
using Ninject.Web.WebApi.OwinHost;
using System.Net.Http.Formatting;

[assembly: OwinStartup( typeof( OwinWebApiBootstrap.App.Startup ) )]

namespace OwinWebApiBootstrap.App {
    public class Startup {

        public void Configuration( IAppBuilder appBuilder ) {
            HttpConfiguration config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();

            config.Formatters.Clear();
            config.Formatters.Add( new JsonMediaTypeFormatter() );

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
