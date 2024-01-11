using Microsoft.AspNetCore.Mvc;

namespace WA_HamburgerProjesiMVC_100124.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
