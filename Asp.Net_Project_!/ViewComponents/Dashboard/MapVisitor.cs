﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Project__.ViewComponents.Dashboard
{
    public class MapVisitor:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
