using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WA_HamburgerProjesiMVC_100124.Models;

namespace WA_HamburgerProjesiMVC_100124.Controllers
{
	[Authorize(Roles = "Standart User")]
	public class AccountController : Controller
	{
		private readonly UserManager<AppUser> userManager;
		private readonly SignInManager<AppUser> signInManager;
		private readonly RoleManager<IdentityRole> roleManager;

		public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
			this.userManager = userManager;
			this.signInManager = signInManager;
			this.roleManager = roleManager;
		}

		[AllowAnonymous]
		public IActionResult Login(string returnUrl)
		{
			LoginVM loginVM = new LoginVM();
			loginVM.ReturnUrl = returnUrl;
			return View(loginVM);
		}

		[AllowAnonymous]
		[HttpPost]
		public async Task<IActionResult> Login(LoginVM login)
		{
            if (ModelState.IsValid)
            {
				AppUser appuser = await userManager.FindByNameAsync(login.UserName);
				if (appuser != null)
				{
					await signInManager.SignOutAsync();
					Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(appuser, login.Password, false, false);
					if (result.Succeeded)
					{
						return RedirectToAction("Index");
					}
				}

				ModelState.AddModelError(nameof(login.UserName), "Login failed : username or password is wrong.");
            }

			return View(login);
        }

		public async Task<IActionResult> Logout()
		{
			await signInManager.SignOutAsync();
			return RedirectToAction("Index");
		}

		public IActionResult AccessDenied()
		{
			return View();
		}

		[AllowAnonymous]
		public IActionResult Create()
		{
			
			
			

			return View();
		}

		[AllowAnonymous]
		[HttpPost]
		public async Task<IActionResult> Create(UserSignUpVM user)
		{
			if (user.Password != user.RepeatPassword)
			{
				ModelState.AddModelError(nameof(user.Password), "Sign Up Failed : Paswords does not match.");
			}

			if (ModelState.IsValid)
			{
				AppUser appUser = new AppUser()
				{
					UserName = user.UserName,
					Email = user.Email,
					FirstName = user.FirstName,
					LastName = user.LastName,

				};


				IdentityResult result = await userManager.CreateAsync(appUser, user.Password);

				if (result.Succeeded)
				{
					string roleName = "Standart User";

					result = await userManager.AddToRoleAsync(appUser, roleName);

					if (!result.Succeeded)
					{
						Errors(result);
					}

					return RedirectToAction("Index");
				}

				else
				{
					foreach (IdentityError item in result.Errors)
					{
						ModelState.AddModelError("Create User", $"{item.Code} - {item.Description}");
					}
				}
			}

			
			return View(user);
		}

		public async Task<IActionResult> Index()
		{
			AppUser user = await userManager.GetUserAsync(HttpContext.User);
			string message = "Hello" + " " + user.UserName;
			return View((object)message);
		}

		private void Errors(IdentityResult result)
		{
			foreach (IdentityError item in result.Errors)
			{
				ModelState.AddModelError("UpdateUser", $"{item.Code} - {item.Description}");
			}
		}
	}
}
