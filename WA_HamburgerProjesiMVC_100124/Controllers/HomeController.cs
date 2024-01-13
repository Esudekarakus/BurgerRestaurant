using BLL.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WA_HamburgerProjesiMVC_100124.Models;

namespace WA_HamburgerProjesiMVC_100124.Controllers
{
    // authorize
    public class HomeController : Controller
    {
        static public List<Menu> onaysizMenu = new List<Menu>();
        static public List<Menu> onayliMenu = new List<Menu>();
        private readonly ILogger<HomeController> logger;
        private readonly MenuService menuService;
        private readonly ProductService productService;
        private readonly UserManager<AppUser> userManager;



        // Layout olacak 
        // Navbar Profil  -  Burger Menu (�izgi)  -  Search butonu  -  
        // Profil (Bilgiler  -  �nceki sipari�ler  -  Sepetim  -  ��k�� )
        // Hamburger Menu (Ana sayfa  -  Hakk�m�zda  -  �leti�im  -  Sipari� ver  )
        // Uygulama a��ld���nda giri� ekran� kar��las�n. Giri� yapmadan devam edilmesin.


        public HomeController(ILogger<HomeController> logger,MenuService menuService,ProductService productService , UserManager<AppUser> userManager )
        {
            this.userManager = userManager;
            this.logger = logger;
            this.menuService = menuService;
            this.productService = productService;
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
        public IActionResult GetDesserts()
        {
            List<Product> desserts = productService.GetDesserts();
            return PartialView("_GetProducts", desserts);
        }
        







         public async Task<IActionResult> Bilgiler( )
         {
            // Kullanıcı bilgileri burada yer alacak. Kullanıcının adını ,  mail adresini ,  şifresini güncelleyebildiği ekran olacak
            // UserVM login yapılan kullanıcıya eşitlenecek.
            AppUser user = await userManager.GetUserAsync(HttpContext.User);
            UserVM userVM = new UserVM(){
                EMail = user.Email,
                Name= user.FirstName,
                SurName = user.LastName,
                Password = user.PasswordHash
                
            };

            // Password farklı şekilde yazdırılabilir. Ona sonra bak.
            
            
            return View(userVM);
         }
         public async Task<IActionResult> OncekiSiparisler( )
         {
            
            // Admin onayından geçen siparişler teslim edildi olduktan sonra burada göster Liste şeklinde. Tarih ve sipariş bbilgisi lazım
            return View();
         }
         public async Task<IActionResult> Sepetim( )
         {

            //Güncel Sepet bilgileri gösterilecek. Onaylanmamış haliyle.

            if (onaysizMenu.Count > 0)
            {
                return View(onaysizMenu);
            }
            else
            {
                //boş liste sayfası yazılacak.
                return View();
            }
         }

         public async Task<IActionResult> CikisYap( )
         {
            //Logout Kısmı burada çağıralacak. Service de yaz.
            return View();
         }





    }
}