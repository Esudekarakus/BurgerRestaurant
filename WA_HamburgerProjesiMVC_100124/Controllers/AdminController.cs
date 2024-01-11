using Microsoft.AspNetCore.Mvc;

namespace WA_HamburgerProjesiMVC_100124.Controllers
{
	public class AdminController : Controller
	{
        // Layout olusturulacak ( Side bar + header + footer)
        // Viewlar layoutun icinde main kismina RenderBody ile gelecek.
        // Header kisminda giris yapan adminin ismi + logout + bildirim butonu + mesaj butonu  olacak.
        // SideBar'da Restorana ait istatistikler + Menu crud + Urun crud + Kategori crud + Kullanicilari goruntuleme + Siparisleri goruntuleme + Mesajlari goruntuleme 

        public IActionResult Index()
		{
			return View();
		}

		
	}
}
