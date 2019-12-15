﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coursmanager.Filters
{
    public class ActionResultExceptionFileAttribute : ActionFilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            if(filterContext.Exception is UnauthorizedException)
            {
                filterContext.Result = new RedirectResult("Account?Login");
            }
        }
    }
}