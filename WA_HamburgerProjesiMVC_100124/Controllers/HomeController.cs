using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WA_HamburgerProjesiMVC_100124.Models;

namespace WA_HamburgerProjesiMVC_100124.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		
		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}



        // Layout olacak 
        // Navbar Profil  -  Burger Menu (Çizgi)  -  Search butonu  -  
        // Profil (Bilgiler  -  Önceki siparişler  -  Sepetim  -  çıkış )
        // Hamburger Menu (Ana sayfa  -  Hakkımızda  -  İletişim  -  Sipariş ver  )
        // Uygulama açıldığında giriş ekranı karşılasın. Giriş yapmadan devam edilmesin.







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