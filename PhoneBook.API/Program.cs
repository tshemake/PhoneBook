using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Serilog;

namespace PhoneBook.API
{
    public class Program
    {
        public static int Main(string[] args)
        {
             try
            {
                BuildWebHost(args).Run();
                return 0;
            }
            catch
            {
                return 1;
            }
        }

        public static IWebHost BuildWebHost(string[] args) =>
            CreateWebHostBuilder(args)
                .ConfigureLogging((context, logging) =>
                {
                    logging.AddSerilog(
                        new LoggerConfiguration()
                            .ReadFrom.Configuration(context.Configuration)
                            .CreateLogger());
                })
                .Build();

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
