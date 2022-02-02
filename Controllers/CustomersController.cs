using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibApp_Gr3.Models;
using LibApp_Gr3.ViewModels;

namespace LibApp_Gr3.Controllers
{
    public class CustomersController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View(id);
        }

    }
}