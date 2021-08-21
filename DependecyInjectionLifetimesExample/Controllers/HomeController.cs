using DependecyInjectionLifetimesExample.Models;
using DependecyInjectionLifetimesExample.Service;
using DependecyInjectionLifetimesExample.Service.SubService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DependecyInjectionLifetimesExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly SingletonService _singletonService;
        private readonly ScopedService _scopedService;
        private readonly TransientService _transientService;
        private readonly SingletonSubService _singletonSubService;
        private readonly ScopedSubService _scopedSubService;
        private readonly TransientSubService _transientSubService;

        public HomeController(
            SingletonService singletonService, 
            ScopedService scopedService, 
            TransientService transientService,
            SingletonSubService singletonSubService,
            ScopedSubService scopedSubService,
            TransientSubService transientSubService
            )
        {
            _singletonService = singletonService;
            _scopedService = scopedService;
            _transientService = transientService;

            _singletonSubService = singletonSubService;
            _scopedSubService = scopedSubService;
            _transientSubService = transientSubService;
        }

        public IActionResult Index()
        {
            ViewBag.SingletonService = _singletonService.GetValue();
            ViewBag.ScopedService = _scopedService.GetValue();
            ViewBag.TransientService = _transientService.GetValue();


            ViewBag.SingletonSubService = _singletonSubService.GetValue();
            ViewBag.ScopedSubService = _scopedSubService.GetValue();
            ViewBag.TransientSubService = _transientSubService.GetValue();

            return View();
        }

        public IActionResult Privacy()
        {

            ViewBag.SingletonService = _singletonService.GetValue();
            ViewBag.ScopedService = _scopedService.GetValue();
            ViewBag.TransientService = _transientService.GetValue();


            ViewBag.SingletonSubService = _singletonSubService.GetValue();
            ViewBag.ScopedSubService = _scopedSubService.GetValue();
            ViewBag.TransientSubService = _transientSubService.GetValue();

            return View();
        }


    }
}
