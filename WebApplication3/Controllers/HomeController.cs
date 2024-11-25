using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly SalesDbContext _SalesDbContext;

        public HomeController(SalesDbContext context)
        {
            _SalesDbContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetTotalOrders()
        {
            List<object> data = new List<object>();
            List<string> labels = _SalesDbContext.Orders.Select(m => m.MonthName).ToList();
            List<int> total = _SalesDbContext.Orders.Select(t => t.TotalOrders).ToList();
            data.Add(labels);
            data.Add(total);
            return Json(data);
        }
    }
}
