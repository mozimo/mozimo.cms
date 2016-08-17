using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Mozimo.CMS.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            

            return View();
        }

        public IActionResult Contact()
        {
            string jsonBook = "{'BookID':'123', 'PublishDate':'2011-1-2', 'Price':23.5}";
            Book bk1 = JsonConvert.DeserializeObject<Book>(jsonBook);
           

            ViewData["Message"] = bk1.ToString();

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }

    public class Book
    {
        public string BookID { get; set; }
        public DateTime PublishDate { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return "ID:" + BookID + "; Date:" + PublishDate+ "; Price" + Price.ToString("n");
        }
    }
}
