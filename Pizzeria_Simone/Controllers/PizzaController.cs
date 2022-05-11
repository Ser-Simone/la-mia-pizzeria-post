using Microsoft.AspNetCore.Mvc;
using Pizzeria_Simone.Models;
using Pizzeria_Simone.Utils;

namespace Pizzeria_Simone.Controllers
{
    
    public class PizzaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Pizza> pizza = PizzaData.GetPizza();
            return View("HomePage", pizza);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("FormPizza");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pizza nuovaPizza)
        {
            if(!ModelState.IsValid)
            {
                return View("FormPizza", nuovaPizza);
            }

            Pizza pizza = new Pizza(PizzaData.GetPizza().Count, nuovaPizza.Title, nuovaPizza.Description, nuovaPizza.Image, nuovaPizza.Price);
            // il mio modello è corretto
            
            PizzaData.GetPizza().Add(nuovaPizza);
                return RedirectToAction("Index");
        }

    }
}
