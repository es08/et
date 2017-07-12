using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace eTracking.Web.Views.Project
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ProjectList
    {
        private readonly RequestDelegate _next;

        public ProjectList(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ProjectListExtensions
    {
        public static IApplicationBuilder UseMiddlewareClassTemplate(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ProjectList>();
        }
    }
}
