using Microsoft.AspNetCore.Mvc;
using VendasWebMVC.Models;

namespace VendasWebMVC.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento { Id = 1, Nome = "Informatica" });
            list.Add(new Departamento { Id = 2, Nome = "Eletrodomesticos" });
            return View(list);
        }
    }
}
