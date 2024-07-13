using introduceDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace introduceDotNetCore.Controllers
{
    public class HomeController : Controller
    {
        //Home/Index
        public IActionResult Index()
        {
            ViewBag.Name = "Furkan";
            ViewBag.Hour = DateTime.Now.Hour;
            ViewBag.Country = "Tr";
            ViewBag.Products = new List<string>
            {
                "A","B","C"
            };

            var products = new List<Product>()
            {
                new() {Id=1,Name="X",Price=1},
                new() {Id=2,Name="Y",Price=2}
            };

            return View(products);
        }

        public IActionResult Response()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Response(UserResponse response)
        {
            if (ModelState.IsValid)
            {
                //return Redirect("/"); //anasayfaya gönder.
                return View("Result", response); //result view'ına response modeli ile gönder.

            }
            return View();
        }
    }
}
