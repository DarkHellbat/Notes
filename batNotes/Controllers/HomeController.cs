﻿using batNotes.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace batNotes.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(UserMethods userRepository) :
            base(userRepository)
        {
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}