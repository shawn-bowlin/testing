using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace tn_nextgen_helloworld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
        .UseUrls($"http://*:{Environment.GetEnvironmentVariable("PORT")}");

    }
}
