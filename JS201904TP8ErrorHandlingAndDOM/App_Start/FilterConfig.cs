﻿using System.Web;
using System.Web.Mvc;

namespace JS201904TP8ErrorHandlingAndDOM
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
