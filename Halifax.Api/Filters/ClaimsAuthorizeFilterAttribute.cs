﻿using Halifax.Core.Exceptions;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Halifax.Api.Filters
{
    public abstract class ClaimsAuthorizeFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var claims = context.HttpContext.User?.Claims?.ToList();

            if (claims == null || !IsAuthorized(claims, context))
            {
                throw new HalifaxUnauthorizedException("Request is unauthorized");
            }
        }

        protected abstract bool IsAuthorized(List<Claim> claims, ActionExecutingContext context);
    }
}