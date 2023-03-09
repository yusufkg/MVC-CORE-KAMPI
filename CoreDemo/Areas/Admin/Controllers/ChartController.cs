﻿using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();

            list.Add(new CategoryClass
            {
                categoryname = "Teknoloji",
                categorycount = 10
            });
            list.Add(new CategoryClass
            {
                categoryname = "Yazılım",
                categorycount = 15
            }); 
            list.Add(new CategoryClass
            {
                categoryname = "Spor",
                categorycount = 14
            });
            list.Add(new CategoryClass
            {
                categoryname = "Sinema",
                categorycount = 2
            });

            return Json(new { jsonlist=list});
        }
    }
}
