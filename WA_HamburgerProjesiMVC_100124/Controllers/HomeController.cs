using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WA_HamburgerProjesiMVC_100124.Models;

namespace WA_HamburgerProjesiMVC_100124.Controllers
{
    // authorize
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;

        // Layout olacak 
        // Navbar Profil  -  Burger Menu (Çizgi)  -  Search butonu  -  
        // Profil (Bilgiler  -  Önceki sipariþler  -  Sepetim  -  çýkýþ )
        // Hamburger Menu (Ana sayfa  -  Hakkýmýzda  -  Ýletiþim  -  Sipariþ ver  )
        // Uygulama açýldýðýnda giriþ ekraný karþýlasýn. Giriþ yapmadan devam edilmesin.


        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Order()
        {
            return View();
        }

    }
}