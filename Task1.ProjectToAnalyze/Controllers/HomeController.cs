using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task1.ProjectToAnalyze.Controllers
{
    public class Home : Controller
    {
        public string Index()
        {
            Home controller = new Home();
            return "Hello";
        }
    }
}