using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibApp_Gr3.Models;
using LibApp_Gr3.ViewModels;
using LibApp_Gr3.Services;

namespace LibApp_Gr3.Controllers
{
    public class CustomersController : Controller
    {
        protected CustomerService CustomerService { get; }
        public CustomersController(CustomerService customerService)
        {
            CustomerService = customerService;
        }
        public ViewResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var _entity = CustomerService.GetItem(id);

            return View(_entity);
        }

        public IActionResult Form(int? id)
        {
            if(id.HasValue)
            {
                var _entity = CustomerService.GetItem(id.Value);
                return View(_entity);
            }
            else
            {
                return View(null);
            }
        }
    }
}