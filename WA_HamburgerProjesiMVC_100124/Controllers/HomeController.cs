using BLL.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WA_HamburgerProjesiMVC_100124.Models;

namespace WA_HamburgerProjesiMVC_100124.Controllers
{
    // authorize
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly MenuService menuService;



        // Layout olacak 
        // Navbar Profil  -  Burger Menu (�izgi)  -  Search butonu  -  
        // Profil (Bilgiler  -  �nceki sipari�ler  -  Sepetim  -  ��k�� )
        // Hamburger Menu (Ana sayfa  -  Hakk�m�zda  -  �leti�im  -  Sipari� ver  )
        // Uygulama a��ld���nda giri� ekran� kar��las�n. Giri� yapmadan devam edilmesin.


        public HomeController(ILogger<HomeController> logger,MenuService menuService )
        {
            this.logger = logger;
            this.menuService = menuService;
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
            List<Menu> menus = menuService.GetMenusIncludeProducts();
            return View(menus);
        }

        







         public async Task<IActionResult> Bilgiler( )
         {
            // Kullanıcı bilgileri burada yer alacak. Kullanıcının adını ,  mail adresini ,  şifresini güncelleyebildiği ekran olacak
            // UserVM login yapılan kullanıcıya eşitlenecek.
            UserVM user = new UserVM(){
                Name = "Tarik",
                SurName = "Kaya",
                Address = "Karıköy",
                Password = "123",
                EMail = "asd@gmail.com"
            };
            
            
            return View(user);
         }
         public async Task<IActionResult> OncekiSiparisler( )
         {
            // Admin onayından geçen siparişler teslim edildi olduktan sonra burada göster Liste şeklinde. Tarih ve sipariş bbilgisi lazım
            return View();
         }
         public async Task<IActionResult> Sepetim( )
         {

            //Güncel Sepet bilgileri gösterilecek. Onaylanmamış haliyle.


            return View();
         }

         public async Task<IActionResult> CikisYap( )
         {
            //Logout Kısmı burada çağıralacak. Service de yaz.
            return View();
         }





    }
}