using System.Diagnostics;

namespace RestaurantAPI.Middleware
{
    public class RequestTimeHandlerMiddleware : IMiddleware
    {
        private readonly ILogger<RequestTimeHandlerMiddleware> logger;

        public RequestTimeHandlerMiddleware(ILogger<RequestTimeHandlerMiddleware> logger )
        {
            this.logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();

                await next.Invoke(context);

                stopwatch.Stop();

                if(stopwatch.ElapsedMilliseconds / 1000 > 4) 
                {
                    logger.LogInformation($"Elapsed time more than 4s for: {context.Request.Method} - {context.Request.Path}");
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
