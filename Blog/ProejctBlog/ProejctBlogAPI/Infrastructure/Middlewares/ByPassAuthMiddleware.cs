using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProejctBlogAPI.Infrastructure.Middlewares
{
    class ByPassAuthMiddleware
    {
        private readonly RequestDelegate _next;
        private string _currentUserId;

        public ByPassAuthMiddleware(RequestDelegate next)
        {
            _next = next;
            _currentUserId = null;
        }

        public async Task Invoke(HttpContext context)
        {
            var path = context.Request.Path;

           await _next.Invoke(context);

        }
    }
}
