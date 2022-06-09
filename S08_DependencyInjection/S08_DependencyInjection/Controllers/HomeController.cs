using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using S08_DependencyInjection_Models;
using S08_DependencyInjection_Models.ViewModels;
using S08_DependencyInjection_Services.Interfaces;
using System.Collections.Generic;
using System.Diagnostics;

namespace S08_DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServiceAbc _svcAbc;
        private readonly IServiceXyz _svcXyz;

        public HomeController(ILogger<HomeController> logger, IServiceAbc svcAbc, IServiceXyz svcXyz)
        {
            _logger = logger;
            _svcAbc = svcAbc;
            _svcXyz = svcXyz;
        }

        public IActionResult Index()
        {
            _svcAbc.DoSomething();
            _svcXyz.DoSomething();

            return View(new HomeIndexVM(new List<MonitoringServiceInfosVM> { _svcAbc.GetInfos, _svcXyz.GetInfos }));
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
