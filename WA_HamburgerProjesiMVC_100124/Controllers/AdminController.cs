using Domain.Entities;
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
        public IActionResult Dashboard()
        {
            // Toplam kullanici sayisi
            // Ekstra urunlerden edilen toplam ciro
            // Gunluk alinan siparis grafigi
            // Alinan toplam siparis miktari
            // Ciro grafigi
            // Toplam ciro
            // Toplam menu miktari
            // Toplam urun miktari

            return View();
        }
        public IActionResult Menus()
        {
            // Butun menulerin listesi 
            // Menu ekle butonu 
            // Update butonu 
            // Delete butonu

            return View();
        }
        public IActionResult CreateMenu()
        {
            // Menu ekleme ekrani
            // Menuye ait bilgilerin girildigi form
            // Menuye ait fotografin eklenebildigi + goruntulendigi alan
            // Ekle butonu

            return View();
        }
        [HttpPost]
        public IActionResult CreateMenu(Menu menu)
        {
            // Servisten metot cagirip menu databaseye eklenecek. 

            return View();
        }
        public IActionResult UpdateMenu(int id)
        {
            // Menu update ekrani
            // Menuye ait bilgilerin geldigi ve degisikligin yapilacagi form
            // Menuye ait fotografin  goruntulendigi + degistirilebildigi alan
            // Guncelle butonu

            return View();
        }

        [HttpPost]
        public IActionResult UpdateMenu(Menu menu)
        {
            // Servisten metot cagirip databaseden gelen menu guncellenip tekrar databaseye gonderilecek.
            
            return View();
        }
        public IActionResult DeleteMenu(int id)
        {
            // Servisten metot cagirip databaseden gelen menu silinecek.

            return View();
        }
        public IActionResult Products()
        {

            // Butun urunlerin listesi 
            // Urun ekle butonu 
            // Update butonu 
            // Delete butonu

            return View();
        }
        public IActionResult CreateProduct()
        {
            // Urun ekleme ekrani
            // Urune ait bilgilerin girildigi form
            // Urune ait fotografin eklenebildigi + goruntulendigi alan
            // Ekle butonu

            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            // Servisten metot cagirip product databaseye eklenecek. 

            return View();
        }
        public IActionResult UpdateProduct(int id)
        {
            // Urun update ekrani
            // Urune ait bilgilerin geldigi ve degisikligin yapilacagi form
            // Urune ait fotografin  goruntulendigi + degistirilebildigi alan
            // Guncelle butonu

            return View();
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            // Servisten metot cagirip databaseden gelen urun guncellenip tekrar databaseye gonderilecek.

            return View();
        }
        public IActionResult DeleteProduct(int id)
        {
            // Servisten metot cagirip databaseden gelen product silinecek.

            return View();
        }
        public IActionResult Categories()
        {
            // Butun kategorilerin listesi 
            // Kategori ekle butonu 
            // Update butonu 
            // Delete butonu

            return View();
        }
        public IActionResult CreateCategory()
        {
            // Kategori ekleme ekrani
            // Kategoriye ait bilgilerin girildigi form
            // Ekle butonu

            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            // Servisten metot cagirip kategori databaseye eklenecek. 

            return View();
        }
        public IActionResult UpdateCategory(int id)
        {
            // Kategori update ekrani
            // Kategoriye ait bilgilerin geldigi ve degisikligin yapilacagi form
            // Guncelle butonu

            return View();
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            // Servisten metot cagirip databaseden gelen kategori guncellenip tekrar databaseye gonderilecek.

            return View();
        }
        public IActionResult DeleteCategory(int id)
        {
            // Servisten metot cagirip databaseden gelen product silinecek.

            return View();
        }
        public IActionResult Users()
        {
            // Butun kullanicilarin listesi
            // Kullanicilarin durumu -- aktif/pasif e cekilebilecek
            // Kullanicinin kayit olusturma tarihi 
            // Her bir kullanicinin toplam siparis miktari + toplam yaptigi odeme 
            // Toplam kullanici sayisi

            return View();
        }
        public IActionResult Orders()
        {
            // Butun siparislerin goruntulendigi liste 
            // Siparis id + siparis tarihi + siparis edilen urunler + kullanici ismi + fiyat + siparis durumu
            // Siparisin iptal edilebilecegi bir iptal butonu (opsiyonel)
            return View();
        }
        public IActionResult Messages()
        {
            // Kullanicilardan gelen mesajlarin goruntulenebildigi ekran 

            return View();
        }
    }
}
