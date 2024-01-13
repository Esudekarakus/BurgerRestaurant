using BLL.Services;
using DAL.Context;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WA_HamburgerProjesiMVC_100124.Models;

namespace WA_HamburgerProjesiMVC_100124.Controllers
{
	public class AdminController : Controller
	{
        private readonly AdminService adminService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public AdminController(AdminService adminService, IWebHostEnvironment webHostEnvironment)
        {
            this.adminService = adminService;
            this.webHostEnvironment = webHostEnvironment;
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
            
            MenuCreateVM menuCreateVM = new MenuCreateVM();

            menuCreateVM.Burgers = adminService.GetAllBurgers().ToList();
            menuCreateVM.Desserts = adminService.GetAllDesserts().ToList();
            menuCreateVM.Snacks = adminService.GetAllSnacks().ToList();
            menuCreateVM.Beverages = adminService.GetAllBeverages().ToList();
            menuCreateVM.Condiments = adminService.GetAllCondiments().ToList();

            return View(menuCreateVM);
        }
        [HttpPost]
        public IActionResult CreateMenu(MenuCreateVM model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null && model.ImageFile.Length > 0)
                {
                    if (!model.ImageFile.ContentType.StartsWith("image"))
                    {
                        ModelState.AddModelError("ImageFile", "The selected file is not an image file.");
                        return View(model);
                    }

                    string relativePath = "img/";
                    string absolutePath = Path.Combine(webHostEnvironment.WebRootPath, relativePath);
                    Directory.CreateDirectory(absolutePath);

                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageFile.FileName;

                    string filePath = Path.Combine(absolutePath, uniqueFileName);

                    using(var stream = new FileStream(filePath, FileMode.Create))
                    {
                        model.ImageFile.CopyTo(stream);
                    }

                    model.ImagePath = Path.Combine(relativePath, uniqueFileName);
                }

                Menu menu = new Menu()
                {
                    Name = model.Name,
                    Description = model.Description,
                    ImagePath = model.ImagePath,
                    //Size = model.Size == "Small" ? Domain.Enums.Size.Small : model.Size == "Medium" ? Domain.Enums.Size.Medium : Domain.Enums.Size.Large // user menü ekleme ekranına taşınacak
                     
                };

                List<List<int>> modelProducts = new List<List<int>>();

                modelProducts.Add(model.BurgerIds.ToList());
                modelProducts.Add(model.BeverageIds.ToList());
                modelProducts.Add(model.CondimentIds.ToList());
                modelProducts.Add(model.SnackIds.ToList());
                modelProducts.Add(model.DessertIds.ToList());

                List<Product> menuProducts = new List<Product>();

                foreach (var list in  modelProducts)
                {
                    foreach (int item in list)
                    {
                        Product product = adminService.GetProductById(item);

                        if (product != null)
                        {
                            menuProducts.Add(product);
                        }
                    }
                }

                menu.Products = menuProducts;

                double totalPrice = 0;

                foreach (var item in menu.Products)
                {
                    totalPrice += item.Price;
                }

                menu.Price = totalPrice;

                // Servisten metot cagirip menu databaseye eklenecek. 

                adminService.AddMenu(menu);

                return RedirectToAction("Menus");
            }




            return View(model);
        }
        public IActionResult UpdateMenu(int id)
        {
            // Menu update ekrani
            // Menuye ait bilgilerin geldigi ve degisikligin yapilacagi form
            // Menuye ait fotografin  goruntulendigi + degistirilebildigi alan
            // Guncelle butonu

            Menu menu = adminService.GetMenuByIdIncludeProducts(id);

            MenuCreateVM model = new MenuCreateVM()
            {
                Id = menu.Id,
                Name = menu.Name,
                Description = menu.Description,
                ImagePath = menu.ImagePath,
                CurrentProducts = menu.Products
            };

            model.Burgers = adminService.GetAllBurgers().ToList();
            model.Desserts = adminService.GetAllDesserts().ToList();
            model.Snacks = adminService.GetAllSnacks().ToList();
            model.Beverages = adminService.GetAllBeverages().ToList();
            model.Condiments = adminService.GetAllCondiments().ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateMenu(MenuCreateVM model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null && model.ImageFile.Length > 0)
                {
                    if (!model.ImageFile.ContentType.StartsWith("image"))
                    {
                        ModelState.AddModelError("ImageFile", "The selected file is not an image file.");
                        return View(model);
                    }

                    string relativePath = "img/";
                    string absolutePath = Path.Combine(webHostEnvironment.WebRootPath, relativePath);
                    Directory.CreateDirectory(absolutePath);

                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageFile.FileName;

                    string filePath = Path.Combine(absolutePath, uniqueFileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        model.ImageFile.CopyTo(stream);
                    }

                    model.ImagePath = Path.Combine(relativePath, uniqueFileName);
                }


                Menu menu = adminService.GetMenuByIdIncludeProducts((int)model.Id);

                menu.Name = model.Name;
                menu.Description = model.Description;
                menu.ImagePath = model.ImagePath;
                

                List<Product> menuCurrentProducts = menu.Products.ToList();

                foreach (int id in model.DeleteIds ?? new List<int>() { })
                {
                    Product product = menu.Products.FirstOrDefault(p => p.Id == id);
                    if (product != null)
                    {
                        menuCurrentProducts.Remove(product);
                    }
                }

                menu.Products = menuCurrentProducts;

                List<List<int>> modelProducts = new List<List<int>>();

                modelProducts.Add(model.BurgerIds.ToList());
                modelProducts.Add(model.BeverageIds.ToList());
                modelProducts.Add(model.CondimentIds.ToList());
                modelProducts.Add(model.SnackIds.ToList());
                modelProducts.Add(model.DessertIds.ToList());
                

                List<Product> menuProducts = menuCurrentProducts;

                foreach (var list in modelProducts)
                {
                    foreach (int item in list)
                    {
                        Product product = adminService.GetProductById(item);

                        if (product != null)
                        {
                            menuProducts.Add(product);
                        }
                    }
                }

                menu.Products = menuProducts;

                double totalPrice = 0;

                foreach (var item in menu.Products)
                {
                    totalPrice += item.Price;
                }

                menu.Price = totalPrice;

                 

                adminService.UpdateMenu(menu);

                return RedirectToAction("Menus");
            }

            // Servisten metot cagirip databaseden gelen menu guncellenip tekrar databaseye gonderilecek.

            

            return View(model);
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

            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            // Servisten metot cagirip product databaseye eklenecek. 

            adminService.AddProduct(product);

            return View();
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

            adminService.UpdateProduct(product);

            return View();
        }
        public IActionResult DeleteProduct(int id)
        {
            // Servisten metot cagirip databaseden gelen product silinecek.

            Product product = adminService.GetProductById(id);
            adminService.DeleteProduct(product);

            return View();
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
