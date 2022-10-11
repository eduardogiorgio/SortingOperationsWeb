using Microsoft.AspNetCore.Mvc;
using SortingOperationsWeb.Helper;
using SortingOperationsWeb.Models;
using SortingOperationsWeb.ViewModels;
using System.Diagnostics;

namespace SortingOperationsWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(OrderStringsViewModel orderStringsViewModel)
        {
            var listOutput = new List<string>();
            foreach(var text in orderStringsViewModel.Input.Split("\r\n")){
                listOutput.Add(SortingOperations.Sorting(text));
            }
            orderStringsViewModel.Output = String.Join("\r\n", listOutput);
            return View(orderStringsViewModel);
        }

        public IActionResult Author()
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