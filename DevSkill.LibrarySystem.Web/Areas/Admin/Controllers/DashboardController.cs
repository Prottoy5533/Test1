using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevSkill.LibrarySystem.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevSkill.LibrarySystem.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var model = new DashboardModel();
            return View(model);
        }
    }
}