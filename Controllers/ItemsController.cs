using Microsoft.AspNetCore.Mvc;
using MyNewApp.Models;

namespace MyNewApp.Controllers
{
    public class ItemsController : Controller
    {
        //http://localhost:5171/items/overview
        public IActionResult Overview()
        {
            var item = new Item() { Name = "Printer", Description = "It's a great printer"};
            return View(item);
        }

          

        //http://localhost:5171/items/edit?id= 100
        public IActionResult Edit(int itemID)
        {
            return Content("id=" + itemID);
        }

    }
}
