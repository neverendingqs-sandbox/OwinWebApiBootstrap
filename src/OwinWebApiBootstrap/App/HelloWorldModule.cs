using Ninject.Modules;
using OwinWebApiBootstrap.HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinWebApiBootstrap.App {
    public class HelloWorldModule : NinjectModule {

        public override void Load() {
            Bind<IHelloWorldResponse>().To<HelloWorldResponse>().InSingletonScope();
        }
    }
}
