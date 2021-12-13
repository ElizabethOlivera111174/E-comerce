using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using ProjectNC.Domain.Common;
using ProjectNC.Domain.Exceptions;
using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception)
            {
                var response = new Result();
                var exception = context.Features.Get<IExceptionHandlerPathFeature>().Error;
                if (exception.GetType() == typeof(ProjNCException))
                {
                    await response.Fail(exception.Message);
                }
                else
                {
                    await response.Fail("No se ha podido ejecutar la operacion");
                }
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";

                await context.Response.Body.WriteAsync(Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(response)));
            }
        }
    }
}
