
using BLL.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging;
using System.Diagnostics;
using WA_HamburgerProjesiMVC_100124.Models;

namespace WA_HamburgerProjesiMVC_100124.Controllers
{




    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> logger;
        private readonly MenuService menuService;
        private readonly ProductService productService;
        private readonly UserManager<AppUser> userManager;
        private readonly MessageService messageService;
        private readonly SignInManager<AppUser> signInManager;
        private readonly OrderService orderService;

        //sipariş oluşturmadan önce
        public static List<Menu> onaylanmayanMenuler = new List<Menu>();
        public static List<Product> onaylanmayanUrunler = new List<Product>();

        // Layout olacak 
        // Navbar Profil  -  Burger Menu ( izgi)  -  Search butonu  -  
        // Profil (Bilgiler  -   nceki sipari ler  -  Sepetim  -    k   )
        // Hamburger Menu (Ana sayfa  -  Hakk m zda  -   leti im  -  Sipari  ver  )
        // Uygulama a  ld   nda giri  ekran  kar  las n. Giri  yapmadan devam edilmesin.


        public HomeController(ILogger<HomeController> logger, MenuService menuService, ProductService productService, UserManager<AppUser> userManager, MessageService messageService, SignInManager<AppUser> signInManager, OrderService orderService)
        {
            this.userManager = userManager;
            this.messageService = messageService;
            this.signInManager = signInManager;
            this.orderService = orderService;
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
        [Authorize(Roles = "Standard User, admin")]
        public async Task<IActionResult> Contact()
        {
            AppUser user = await userManager.GetUserAsync(HttpContext.User);
            ContactVm contactVm = new ContactVm();
            if (user != null)
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

            if (contactVm.User != null)
            {
                message.UserId = contactVm.User.Id.ToString();
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
            List<Product> drinks = productService.GetBeverages();
            return PartialView("_GetProducts", drinks);
        }
        public IActionResult AddMenuToCard(int id)
        {
            Menu addMenu = menuService.GetMenuById(id);
            onaylanmayanMenuler.Add(addMenu);
            return RedirectToAction("Order");

        }
        public IActionResult AddProductToCard(int id)
        {

            Product product = productService.GetProductById(id);
            onaylanmayanUrunler.Add(product);
            return RedirectToAction("Order");


        }

        public IActionResult GetShoppingCard()
        {

            SiparisVM siparisVM = new SiparisVM()
            {
                menus = onaylanmayanMenuler,
                products = onaylanmayanUrunler,
            };
            return PartialView("_ShoppingCardPartialView", siparisVM);

        }
        [HttpPost]
        public IActionResult DeleteProduct(int id)
        {
            Product product = onaylanmayanUrunler.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                product.Quantity = 1;
                productService.UpdateChanges(product);
                onaylanmayanUrunler.Remove(product);
                return Json("ok");

            }
            else
            {
                return Json("failed");
            }
        }
        public IActionResult DeleteMenu(int id)
        {
            Menu menu = onaylanmayanMenuler.FirstOrDefault(p => p.Id == id);
            if (menu != null)
            {
                menu.Quantity = 1;
                menuService.UpdateChanges(menu);
                onaylanmayanMenuler.Remove(menu);
                return Json("ok");

            }
            else
            {
                return Json("failed");
            }
        }
        public IActionResult ChangeQuantity(int id, int newQuantity)
        {

            Product product = productService.GetProductById(id);


            if (product != null)
            {

                product.Quantity = newQuantity;
                productService.UpdateChanges(product);
                UpdateProductInList(id, newQuantity);
                return Json("ok");
            }


            return Json("error");
        }
        private void UpdateProductInList(int productId, int newQuantity)
        {
            Product productInList = onaylanmayanUrunler.FirstOrDefault(p => p.Id == productId);

            if (productInList != null)
            {
                productInList.Quantity = newQuantity;
            }
        }
        public IActionResult ChangeQuantityMenu(int id, int newQuantity)
        {
            Menu menu = menuService.GetMenuById(id);

            if (menu != null)
            {
                menu.Quantity = newQuantity;
                menuService.UpdateChanges(menu);
                UpdateMenuInList(id, newQuantity);
                return Json("ok");
            }

            return Json("error");
        }
        private void UpdateMenuInList(int menuId, int newQuantity)
        {
            Menu menuInList = onaylanmayanMenuler.FirstOrDefault(m => m.Id == menuId);

            if (menuInList != null)
            {
                menuInList.Quantity = newQuantity;
            }
        }

        [Authorize(Roles = "Standard User, admin")]
        public async Task<IActionResult> Bilgiler()
        {
            // Kullanıcı bilgileri burada yer alacak. Kullanıcının adını ,  mail adresini ,  şifresini güncelleyebildiği ekran olacak
            // UserVM login yapılan kullanıcıya eşitlenecek.
            AppUser user = await userManager.GetUserAsync(HttpContext.User);
            UserVM userVM = new UserVM()
            {
                UserName = user.UserName,
                EMail = user.Email,
                Name = user.FirstName,
                SurName = user.LastName,
                Id = user.Id,

            };

            // Password change butonu olacak Account/Update yönlendirilecek.            
            return View(userVM);
        }
        public async Task<IActionResult> OncekiSiparisler()
        {
            // Admin onayından geçen siparişler teslim edildi olduktan sonra burada göster Liste şeklinde. Tarih ve sipariş bbilgisi lazım

            AppUser user = await userManager.GetUserAsync(HttpContext.User);
            if (user.Id != null)
            {
                return View(orderService.GetOrderListByUserId(user.Id));
            }
            else
            {
                return View();
            }

        }

        [Authorize(Roles = "Standard User, admin")]
        public async Task<IActionResult> Sepetim()
        {
            AppUser user = await userManager.GetUserAsync(HttpContext.User);
            //Quantity kısmı statik olarak viewde güncellenicek.
            SiparisVM siparisVM = new SiparisVM()
            {
                UserId = user.Id,
                menus = onaylanmayanMenuler,
                products = onaylanmayanUrunler,
            };
            return View(siparisVM);


        }
        [HttpPost]
        public async Task<IActionResult> ApproveOrder(List<int> menuIds, string userId)
        {
            List<Menu> menus = new List<Menu>();
            foreach (int id in menuIds)
            {
                Menu menu = menuService.GetMenuByIdIncludeProducts(id);
                menus.Add(menu);
            }

            AppUser user = await userManager.FindByIdAsync(userId);
            decimal totalPrice = 0;

            foreach (Menu menu in menus)
            {
                totalPrice += (decimal)menu.Price;
            }

            Order order = new Order();
            order.Menus = menus;
            order.AppUser = user;
            order.TotalPrice = totalPrice;
            orderService.SaveOrders(order);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> CikisYap()
        {

            return RedirectToAction("Logout", "Account");
        }





    }
}