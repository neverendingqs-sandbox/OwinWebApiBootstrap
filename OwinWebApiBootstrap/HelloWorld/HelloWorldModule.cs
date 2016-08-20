﻿using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinWebApiBootstrap.HelloWorld {
    public class HelloWorldModule : NinjectModule {

        public override void Load() {
            Bind<IHelloWorld>().To<HelloWorld>().InSingletonScope();
        }
    }
}
