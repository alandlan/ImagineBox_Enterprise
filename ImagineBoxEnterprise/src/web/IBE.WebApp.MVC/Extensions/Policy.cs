using Polly;
using Polly.Extensions.Http;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace IBE.WebApp.MVC.Extensions
{
    public static class Policy
    {
        public static IAsyncPolicy<HttpResponseMessage> Retry()
        {
            var retry = HttpPolicyExtensions
                .HandleTransientHttpError()
                .WaitAndRetryAsync(new[]
                {
                    TimeSpan.FromSeconds(1),
                    TimeSpan.FromSeconds(5),
                    TimeSpan.FromSeconds(10)
                }, (outCome, timespan, retryCount, context) =>
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Tentando pea {retryCount} vez!");
                    Console.ForegroundColor = ConsoleColor.White;
                });

            return retry;
        }
    }
}
