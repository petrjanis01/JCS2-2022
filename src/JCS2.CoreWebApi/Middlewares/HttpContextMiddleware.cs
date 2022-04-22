using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace JCS2.CoreWebApi.Middlewares
{
    public class HttpContextMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<HttpContextMiddleware> _logger;

        public HttpContextMiddleware(RequestDelegate next, ILogger<HttpContextMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine(context.Request.Path);
            Console.WriteLine(context.Request.Method);

            await _next(context);

            _logger.LogInformation(context.Request.Path);
            _logger.LogInformation(context.Request.Method);
        }
    }
}
