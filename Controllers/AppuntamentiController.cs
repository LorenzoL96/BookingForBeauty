using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BookingForBeauty.Models.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookingForBeauty.Controllers
{
    [Route("[controller]")]
    public class AppuntamentiController : Controller
    {
        private readonly ILogger<AppuntamentiController> _logger;
        private readonly AppuntamentoService _appuntamentiService;

        public AppuntamentiController(ILogger<AppuntamentiController> logger, AppuntamentoService appuntamentiService)
        {
            _logger = logger;
            _appuntamentiService = appuntamentiService;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}