﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomViewEngine.Infrastructure
{
    public class CustomViewEngine : IViewEngine
    {
        public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            return new ViewEngineResult(new string[] { "No partial view (Custom View Engine)" });
        }

        public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            if (viewName == "Custom")
            {
                return new ViewEngineResult(new CustomView(), this);
            }
            else
            {
                return new ViewEngineResult(new string[] { "No view (Custom View Engine)" });
            }
        }

        public void ReleaseView(ControllerContext controllerContext, IView view)
        {

        }
    }
}