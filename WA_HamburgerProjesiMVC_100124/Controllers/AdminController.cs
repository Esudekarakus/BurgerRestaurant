using AutoMapper;
using BLL.Services;
using DAL.Context;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Cryptography;
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
        public async Task<IActionResult> Dashboard()
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
            dashboardVM.UserCount = ((List<AppUser>)await adminService.GetAllStandartUsers()).Count;
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
            Product product = new Product();

            if (ModelState.IsValid)
            {
                if (productVM.ImageFile != null && productVM.ImageFile.Length > 0)
                {
                    if (!productVM.ImageFile.ContentType.StartsWith("image"))
                    {
                        ModelState.AddModelError("ImageFile", "The selected file is not an image file.");
                        return View(productVM);
                    }

                    string relativePath = "img/";
                    string absolutePath = Path.Combine(webHostEnvironment.WebRootPath, relativePath);
                    Directory.CreateDirectory(absolutePath);

                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + productVM.ImageFile.FileName;

                    string filePath = Path.Combine(absolutePath, uniqueFileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        productVM.ImageFile.CopyTo(stream);
                    }

                    product.ImagePath = Path.Combine(relativePath, uniqueFileName);
                }
            }

            product.Name = productVM.Name;
            product.Price = productVM.Price;
            product.CategoryId = productVM.CategoryId;
            adminService.AddProduct(product);
            return RedirectToAction("Products");
            
        }
        public IActionResult UpdateProduct(int id)
        {
            // Urun update ekrani
            // Urune ait bilgilerin geldigi ve degisikligin yapilacagi form
            // Urune ait fotografin  goruntulendigi + degistirilebildigi alan
            // Guncelle butonu

            List<Category> categories = adminService.GetAllCategories().ToList();

            Product product = adminService.GetProductById(id);
            UpdateProductVM productVM = new UpdateProductVM();  
            productVM.Name = product.Name;
            productVM.Price = product.Price;
            productVM.CategoryId = product.CategoryId;  
            productVM.Categories = new SelectList(categories, "Id", "Name");

            return View(productVM);
        }

        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductVM productVM)
        {
            // Servisten metot cagirip databaseden gelen urun guncellenip tekrar databaseye gonderilecek.
            Product product = adminService.GetProductById(productVM.Id);
            product.Name = productVM.Name;
            product.Price = productVM.Price;
            product.CategoryId = productVM.CategoryId;
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
        public IActionResult CreateCategory(CreateCategoryVM categoryVM)
        {
            // Servisten metot cagirip kategori databaseye eklenecek. 
            Category category = new Category();
            category.Name = categoryVM.Name;
            adminService.AddCategory(category);

            return RedirectToAction("Categories");
        }
        public IActionResult UpdateCategory(int id)
        {
            // Kategori update ekrani
            // Kategoriye ait bilgilerin geldigi ve degisikligin yapilacagi form
            // Guncelle butonu

            Category category = adminService.GetCategoryById(id);
            UpdateCategoryVM updateCategoryVM = new UpdateCategoryVM();
            updateCategoryVM.Name = category.Name;
            return View(updateCategoryVM);
        }
        [HttpPost]
        public IActionResult UpdateCategory(UpdateCategoryVM categoryVM)
        {
            // Servisten metot cagirip databaseden gelen kategori guncellenip tekrar databaseye gonderilecek.

            Category category = adminService.GetCategoryById(categoryVM.Id);
            category.Name = categoryVM.Name;
            adminService.UpdateCategory(category);

            return RedirectToAction("Categories");

        }
        public IActionResult DeleteCategory(int id)
        {
            // Servisten metot cagirip databaseden gelen product silinecek.

            Category category = adminService.GetCategoryById(id);
            adminService.DeleteCategory(category);

            return RedirectToAction("Categories");
        }
        public async Task<IActionResult> Users()
        {

            // Butun kullanicilarin listesi
            // Kullanicilarin durumu -- aktif/pasif e cekilebilecek
            // Kullanicinin kayit olusturma tarihi 
            // Her bir kullanicinin toplam siparis miktari + toplam yaptigi odeme 
            // Toplam kullanici sayisi

            IList<AppUser> userList = await adminService.GetAllStandartUsers();

            return View(mapper.Map<List<UserListVM>>(userList));
        }

        public async Task<IActionResult> UserChangeStatus(string email)
        {
            AppUser user = await adminService.GetUserByEmail(email);
            if (user.Status == Domain.Enums.UserStatus.Active)
                user.Status = Domain.Enums.UserStatus.Passive;
            else
                user.Status = Domain.Enums.UserStatus.Active;
            IdentityResult result = await adminService.UpdateUser(user);

            return RedirectToAction("Users");
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
