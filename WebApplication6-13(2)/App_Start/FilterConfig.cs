﻿using System.Web;
using System.Web.Mvc;

namespace WebApplication6_13_2_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
