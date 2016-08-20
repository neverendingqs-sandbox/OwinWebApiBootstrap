using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinWebApiBootstrap {
    public sealed class Program {
        public static void Main( string[] args ) {
            // Specify the URI to use for the local host:
            const string baseUri = "http://localhost:8080";

            Startup( baseUri: baseUri );
        }

        public static void Startup( string baseUri ) {
            Console.WriteLine( "Starting web Server..." );
            WebApp.Start<App.Startup>( baseUri );
            Console.WriteLine( "Server running at {0} - press Enter to quit. ", baseUri );
            Console.ReadLine();
        }
    }
}
