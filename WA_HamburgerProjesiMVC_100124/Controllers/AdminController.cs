using AutoMapper;
using BLL.Services;
using DAL.Context;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WA_HamburgerProjesiMVC_100124.Models;

namespace WA_HamburgerProjesiMVC_100124.Controllers
{
    public class AdminController : Controller
    {
        private readonly AdminService adminService;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IMapper mapper;

        public AdminController(AdminService adminService, IWebHostEnvironment webHostEnvironment,IMapper mapper)
        {
            this.adminService = adminService;
            this.webHostEnvironment = webHostEnvironment;
            this.mapper = mapper;
        }

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

            DashboardVM dashboardVM = new DashboardVM();
            dashboardVM.UserCount = adminService.GetAllUsers().Count;
            dashboardVM.TotalProductsPayment = adminService.GetTotalPaymentFromProducts();
            dashboardVM.TotalPayment = adminService.GetTotalPayment();
            dashboardVM.MenuCount = adminService.GetTotalMenuCount();
            dashboardVM.ProductCount = adminService.GetTotalProductCount();
            return View(dashboardVM);
        }
        public IActionResult Menus()
        {
            // Butun menulerin listesi 
            // Menu ekle butonu 
            // Update butonu 
            // Delete butonu

            List<Menu> menuList = new List<Menu>();
            menuList = adminService.GetAllMenus().ToList();

            return View(menuList);
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

            adminService.AddMenu(menu);

            return View();
        }
        public IActionResult UpdateMenu(int id)
        {
            // Menu update ekrani
            // Menuye ait bilgilerin geldigi ve degisikligin yapilacagi form
            // Menuye ait fotografin  goruntulendigi + degistirilebildigi alan
            // Guncelle butonu

            Menu menu = adminService.GetMenuById(id);

            return View(menu);
        }

        [HttpPost]
        public IActionResult UpdateMenu(Menu menu)
        {
            // Servisten metot cagirip databaseden gelen menu guncellenip tekrar databaseye gonderilecek.

            adminService.UpdateMenu(menu);

            return View();
        }
        public IActionResult DeleteMenu(int id)
        {
            // Servisten metot cagirip databaseden gelen menu silinecek.

            Menu menu = adminService.GetMenuById(id);
            adminService.DeleteMenu(menu);

            return View();
        }
        public IActionResult Products()
        {

            // Butun urunlerin listesi 
            // Urun ekle butonu 
            // Update butonu 
            // Delete butonu

            List<Product> productList = new List<Product>();
            productList = adminService.GetAllProducts().ToList();

            return View(productList);
        }
        public IActionResult CreateProduct()
        {
            // Urun ekleme ekrani
            // Urune ait bilgilerin girildigi form
            // Urune ait fotografin eklenebildigi + goruntulendigi alan
            // Ekle butonu
            List<Category> categories = adminService.GetAllCategories().ToList();
            CreateProductVM createProductVM = new CreateProductVM();
            createProductVM.Categories = new SelectList(categories, "Id", "Name");

            return View(createProductVM);
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductVM productVM)
        {
            // Servisten metot cagirip product databaseye eklenecek. 

            bool isAdded = adminService.AddProduct(mapper.Map<Product>(productVM));
            if (isAdded)
            {
                return RedirectToAction("Products");
            }
            else return View();
        }
        public IActionResult UpdateProduct(int id)
        {
            // Urun update ekrani
            // Urune ait bilgilerin geldigi ve degisikligin yapilacagi form
            // Urune ait fotografin  goruntulendigi + degistirilebildigi alan
            // Guncelle butonu

            Product product = adminService.GetProductById(id);

            return View(product);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            // Servisten metot cagirip databaseden gelen urun guncellenip tekrar databaseye gonderilecek.

            bool isUpdated = adminService.UpdateProduct(product);

            if (isUpdated)
            {
                return RedirectToAction("Products");
            }
            else return View();

        }
        public IActionResult DeleteProduct(int id)
        {
            // Servisten metot cagirip databaseden gelen product silinecek.

            Product product = adminService.GetProductById(id);
            bool isDeleted = adminService.DeleteProduct(product);
            if (isDeleted)
            {
                return RedirectToAction("Products");
            }

            return RedirectToAction("Products");
        }
        public IActionResult Categories()
        {
            // Butun kategorilerin listesi 
            // Kategori ekle butonu 
            // Update butonu 
            // Delete butonu

            List<Category> categoryList = new List<Category>();
            categoryList = adminService.GetAllCategories().ToList();

            return View(categoryList);
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

            adminService.AddCategory(category);

            return View();
        }
        public IActionResult UpdateCategory(int id)
        {
            // Kategori update ekrani
            // Kategoriye ait bilgilerin geldigi ve degisikligin yapilacagi form
            // Guncelle butonu

            Category category = adminService.GetCategoryById(id);

            return View(category);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            // Servisten metot cagirip databaseden gelen kategori guncellenip tekrar databaseye gonderilecek.

            adminService.UpdateCategory(category);

            return View();
        }
        public IActionResult DeleteCategory(int id)
        {
            // Servisten metot cagirip databaseden gelen product silinecek.

            Category category = adminService.GetCategoryById(id);
            adminService.DeleteCategory(category);

            return View();
        }
        public IActionResult Users()
        {

            // Butun kullanicilarin listesi
            // Kullanicilarin durumu -- aktif/pasif e cekilebilecek
            // Kullanicinin kayit olusturma tarihi 
            // Her bir kullanicinin toplam siparis miktari + toplam yaptigi odeme 
            // Toplam kullanici sayisi

            List<AppUser> userList = adminService.GetAllUsers().ToList();

            return View(userList);
        }
        public IActionResult Orders()
        {
            // Butun siparislerin goruntulendigi liste 
            // Siparis id + siparis tarihi + siparis edilen urunler + kullanici ismi + fiyat + siparis durumu
            // Siparisin iptal edilebilecegi bir iptal butonu (opsiyonel)

            List<Order> orderList = adminService.GetAllOrdersWithUsers().ToList();

            return View(orderList);
        }
        public IActionResult Messages()
        {
            // Kullanicilardan gelen mesajlarin goruntulenebildigi ekran 

            return View();
        }
    }
}
