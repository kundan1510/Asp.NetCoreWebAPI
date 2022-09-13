namespace Asp.NetCoreFromScratch
{
    public class CustomMiddleware1 : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello from new file  CustomMiddleware1 1 \n");

            await next(context);

            await context.Response.WriteAsync("Hello from new file CustomMiddleware1 2 \n");
        }
    }
}
