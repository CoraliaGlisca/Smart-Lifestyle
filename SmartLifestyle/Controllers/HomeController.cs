using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartLifestyle.BusinessLogic.Services;
using SmartLifestyle.Models;
using SmartLifestyle.Models.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SmartLifestyle.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MealPlannerService mealPlannerService;
        private readonly UserManager<IdentityUser> userManager;

        public HomeController(ILogger<HomeController> logger, MealPlannerService mealPlannerService, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            this.mealPlannerService = mealPlannerService;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var userId = userManager.GetUserId(User);
            UserOffset userOffset = new UserOffset();
            userOffset.UserId = userId;
            userOffset.Offset = 0;

            mealPlannerService.AddUserOffset(userOffset);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
