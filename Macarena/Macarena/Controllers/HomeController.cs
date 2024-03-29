﻿using MACARENA.Models;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;

namespace MACARENA.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
  
        public ActionResult About()
        {
            return View();
        }
  
        public ActionResult Turizim()
        {
            return View();
        }
        public ActionResult Blog()
        {
            using (MacarenaDBContext context = new MacarenaDBContext())
            {
                List<Blog> blog = context.Blog.OrderByDescending(x => x.BlogTarih).ToList();
                return View(blog);
            }
        }
        public ActionResult ChangeCulture(string lang, string returnUrl)
        {
            Session["Culture"] = new CultureInfo(lang);
            return Redirect(returnUrl);
        }
    }


}