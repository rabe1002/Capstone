﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capstone.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            return View();
        }
    }
}