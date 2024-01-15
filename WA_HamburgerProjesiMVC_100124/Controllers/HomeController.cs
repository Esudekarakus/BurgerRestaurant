using BLL.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WA_HamburgerProjesiMVC_100124.Models;

namespace WA_HamburgerProjesiMVC_100124.Controllers
{
    [Authorize(Roles = "Standard User")]
    
    public class HomeController : Controller
    {
      
        private readonly ILogger<HomeController> logger;
        private readonly MenuService menuService;
        private readonly ProductService productService;
        private readonly UserManager<AppUser> userManager;
        private readonly MessageService messageService;

        //sipariş oluşturmadan önce
        public static List<Menu>onaylanmayanMenuler = new List<Menu>();
        public static List<Product>onaylanmayanUrunler=new List<Product>();

        // Layout olacak 
        // Navbar Profil  -  Burger Menu (�izgi)  -  Search butonu  -  
        // Profil (Bilgiler  -  �nceki sipari�ler  -  Sepetim  -  ��k�� )
        // Hamburger Menu (Ana sayfa  -  Hakk�m�zda  -  �leti�im  -  Sipari� ver  )
        // Uygulama a��ld���nda giri� ekran� kar��las�n. Giri� yapmadan devam edilmesin.


        public HomeController(ILogger<HomeController> logger,MenuService menuService,ProductService productService , UserManager<AppUser> userManager,MessageService messageService)
        {
            this.userManager = userManager;
            this.messageService = messageService;
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
        public async Task<IActionResult> Contact()
        { 
            AppUser user = await userManager.GetUserAsync(HttpContext.User);
            ContactVm contactVm = new ContactVm();
           if (user!=null)
            {
                contactVm.User = user;
            }
             
           return View(contactVm);  
        }



        [HttpPost]
        public async Task<IActionResult> Contact(ContactVm contactVm)
        {
            Message message = new Message()
            {
               
                Name = contactVm.Message.Name,
                Content = contactVm.Message.Content

            };

            if(contactVm.User != null)
            {
                message.UserId= contactVm.User.Id.ToString();
            }

           messageService.Save(message);


            return RedirectToAction("Contact");
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
        public IActionResult GetMenus()
        {

            List<Menu> menus = menuService.GetMenusIncludeProducts();
            return PartialView("_GetMenusPartialView", menus);

        }
        public IActionResult GetSnacks()
        {
            List<Product> snacks = productService.GetSnacks();
            
            return PartialView("_GetProducts", snacks);
        }
        public IActionResult GetDrinks()
        {
            List<Product> drinks= productService.GetBeverages();
            return PartialView("_GetProducts", drinks);
        }
        public IActionResult AddMenuToCard(int id)
        {
            Menu addMenu=menuService.GetMenuById(id);
            onaylanmayanMenuler.Add(addMenu);
            return RedirectToAction("Order");

        }
        public IActionResult AddProductToCard(int id)
        {
            
            Product product = productService.GetProductById(id);
            onaylanmayanUrunler.Add(product);
            return RedirectToAction("Order");


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
            if(onaylanmayanMenuler.Count>0 || onaylanmayanUrunler.Count > 0)
            {
                SiparisVM siparisVM = new SiparisVM()
                {
                    menus = onaylanmayanMenuler,
                    products = onaylanmayanUrunler,
                };
                return View(siparisVM);
            }
            else { return View(); }
         }

         public async Task<IActionResult> CikisYap( )
         {
            //Logout Kısmı burada çağıralacak. Service de yaz.
            return View();
         }





    }
}