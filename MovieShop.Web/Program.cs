using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShop.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

    // Kestrel Server ...
    // Main method is the entry point which will create a hosting environment so that ASP.NET Core can work inside that one.
    // Its gonna call a class called Startup -->
    // If something is wrong or not working first place to look for is Startup Class.

    // Middleware in ASP.NET Core
    // When you make a request in ASP.NET Core MVC/API... the request will go through some middleware
    // Request -> M1 -> some processing, --> M2 --> M3 --> Destination

    // Response --> M3 --> M2 --> M1

    // ASP.NET Core has some build-in middlewares where every request will go through those middlewares
    // We as a developer can create our own custom middlewares also and plugin to pipeline

    // Routing --> pattern matching technique
    // Traditional based routing/Convention based Routing
    // Attribute based Routing --> Most used one // interview question
}
