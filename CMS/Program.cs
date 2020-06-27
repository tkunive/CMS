using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.ApplicationInsights;

namespace CMS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            //var logger = host.Services.GetRequiredService<ILogger<Program>>();
            // This will be picked up by AI
            //logger.LogInformation("From Program. Running the host now..");
            //host.Run();
        }

         public static IHostBuilder CreateHostBuilder(string[] args) =>
             Host.CreateDefaultBuilder(args)
                 .ConfigureWebHostDefaults(webBuilder =>
                 {
                     webBuilder.UseStartup<Startup>();
                 }).ConfigureLogging(logging => {
                     logging.AddApplicationInsights("f5cc8ecb-4b99-413f-ae88-cc8b343f7d6d");
                     logging.AddFilter<ApplicationInsightsLoggerProvider>("", LogLevel.Trace);            });
        /* public static IHostBuilder CreateHostBuilder(string[] args) =>
             Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
             {
                 webBuilder.UseStartup<Startup>();
             })
             .ConfigureLogging(
             builder =>
             {
                 // Providing an instrumentation key here is required if you're using
                 // standalone package Microsoft.Extensions.Logging.ApplicationInsights
                 // or if you want to capture logs from early in the application startup
                 // pipeline from Startup.cs or Program.cs itself.
                 builder.AddApplicationInsights();

                 // Optional: Apply filters to control what logs are sent to Application Insights.
                 // The following configures LogLevel Information or above to be sent to
                 // Application Insights for all categories.
                 builder.AddFilter<Microsoft.Extensions.Logging.ApplicationInsights.ApplicationInsightsLoggerProvider>
                                  ("", LogLevel.Information);
                 builder.AddFilter<Microsoft.Extensions.Logging.ApplicationInsights.ApplicationInsightsLoggerProvider>
                              (typeof(Startup).FullName, LogLevel.Trace);
             }
         );*/


    }
}
