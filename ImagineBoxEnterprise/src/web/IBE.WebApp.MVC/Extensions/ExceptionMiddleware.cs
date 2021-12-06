﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace IBE.WebApp.MVC.Extensions
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (CustomHttpResquestException ex)
            {
                HandleRequestExceptionAsync(httpContext, ex);
            }
        }

        private static void HandleRequestExceptionAsync(HttpContext context, CustomHttpResquestException httpResquestException)
        {
            if(httpResquestException.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                context.Response.Redirect($"/login?ReturnUrl={context.Request.Path}");
                return;
            }

            context.Response.StatusCode = (int)httpResquestException.StatusCode;
        }
    }
}