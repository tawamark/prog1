using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Trabalho_Week.Models;

namespace Trabalho_Week.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string getDay(int x)
        {
            int[] days = [1, 2, 3, 4, 5, 6, 7];
            string retorno = string.Empty;

            if (x == 1)
            {
                retorno = "x é domingo";
            }
            else if (x == 2)
            {
                retorno = "x é segunda";
            }
            else if (x == 3)
            {
                retorno = "x é terça";
            }
            else if (x == 4)
            {
                retorno = "x é quarta";
            }
            else if (x == 5)
            {
                retorno = "x é quinta";
            }
            else if (x == 6)
            {
                retorno = "x é sexta";
            }
            else if (x == 7)
            {
                retorno = "x é sábado";
            }
            else
            {
                retorno = "digite um número válido";
            }    
                return retorno;
        }
        public IActionResult Index()
        {
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
