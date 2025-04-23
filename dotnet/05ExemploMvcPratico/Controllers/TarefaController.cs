using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _05ExemploMvcPratico.Models;
using Microsoft.AspNetCore.Mvc;
namespace _05ExemploMvcPratico.Controllers;
public class TarefaController : Controller
{
    private readonly ILogger<HomeController> _logger;

        public IActionResult Index()
        {
            return View();
        }
     
}
