using System.Diagnostics;
using System.Globalization;
using Aula_03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula_03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public string Getif(int x)
        {
            /*
                Estrutura sintática do IF
                if(expressão booleana)
                {
                    Sentença de código a ser executada caso  a condição seja verdadeira
                }
                
                Caso o if tenha apenas uma linha de comando a ser executada na condicional
                não há necessidade do uso das cahves, sendo então:

                if(expressão booleana)
                    Apenas um comando
            */

            string retorno = string.Empty;
            //int x = 10;

            if (x < 9)
            {
                retorno = "x é maior que 9";
            }

            //x = 8;

            if (x > 9)
            {
                retorno = "x é maior que 9";
            }
            else
            {
                retorno = "x é menor que 9";
            }

            //x = 11;

            if (x == 10)
            {
                retorno = "Ora ora";
                retorno += "x é igual a 10";
            }
            else if (x == 9)
            {
                retorno = "Hmmmmmmm";
                retorno += "x é igual a 9";
            }
            else if (x == 8)
            {
                retorno = "Bahhhhh";
                retorno = "x é igual a 8";
            }
            else
            {
                retorno = "Sei lá que número é x";
            }
                return retorno;


        }

        [HttpGet]
        public string getSwitch(int x)
        {
            string retorno = string.Empty;

            switch (x)
            {
                case 0:
                    retorno = "x é zero";
                    break;
                case 1:
                    retorno = "x é um";
                    break;
                case 2:
                    retorno = "x é dois"; 
                    break;
            }

            return string.Empty;
        }

        [HttpGet]
        public string GetFor()
        {
            /*O comando de repetição for possui a seguinte sintaxe:
            for( <inicializador>; <expressão condicional>; <expressão de repetição>)
            {
                Comandos a serem executados
            }
            Inicializador: elemento contador
            Expressão condicional: Especifica o teste a ser verificado quando o loop estiver executado 
            o número definido de interações (flag);
            Expressão de repetição: Especifica a ação a ser executada com a variável contadora.
            geralmente um acúmulo ou decréscimo (acumulador);
            */

            string retorno = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                retorno += $"{i}; ";
            }

            return retorno;


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
