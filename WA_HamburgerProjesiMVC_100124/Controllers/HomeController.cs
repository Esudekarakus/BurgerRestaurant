using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WA_HamburgerProjesiMVC_100124.Models;

namespace WA_HamburgerProjesiMVC_100124.Controllers
{
	// authorize
	public class HomeController : Controller
	{
		// Layout olacak 
		// Navbar Profil  -  Burger Menu (Çizgi)  -  Search butonu  -  
		// Profil (Bilgiler  -  Önceki siparişler  -  Sepetim  -  çıkış )
		// Hamburger Menu (Ana sayfa  -  Hakkımızda  -  İletişim  -  Sipariş ver  )
		// Uygulama açıldığında giriş ekranı karşılasın. Giriş yapmadan devam edilmesin.


		public HomeController()
		{
			
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