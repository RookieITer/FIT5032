﻿using System.Web;
using System.Web.Mvc;

namespace FIT5032_MyIdentity2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
