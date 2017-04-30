using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace HugoSite_aspnetCore.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger _logger;
        //   private readonly Stopwatch _stopWatch;

        // public HomeController(ILogger<HomeController> logger){
        //     _logger=logger;
        //    _stopWatch = new Stopwatch();
        // }

        public  IActionResult Index()
        {
            // _stopWatch.Start();
            return  View();
        }

        public IActionResult Services()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        // public override void OnActionExecuted(ActionExecutedContext filterContext)
        // {
        //     _stopWatch.Stop();
        //     _logger.LogWarning($"Total do tempo decorrido {_stopWatch.ElapsedMilliseconds} ms", null);
        
        //     base.OnActionExecuted(filterContext);
        //  // 
        // }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
