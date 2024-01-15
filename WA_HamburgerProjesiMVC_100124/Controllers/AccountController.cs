﻿using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WA_HamburgerProjesiMVC_100124.Models;

namespace WA_HamburgerProjesiMVC_100124.Controllers
{
	[Authorize]
	public class AccountController : Controller
	{
		private readonly UserManager<AppUser> userManager;
		private readonly SignInManager<AppUser> signInManager;
		private readonly RoleManager<IdentityRole> roleManager;
        private readonly PasswordHasher<AppUser> passwordHasher;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager, PasswordHasher<AppUser> passwordHasher)
        {
			this.userManager = userManager;
			this.signInManager = signInManager;
			this.roleManager = roleManager;
            this.passwordHasher = passwordHasher;
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
						bool isUser = await userManager.IsInRoleAsync(appuser, "Standard User");
						bool isAdmin = await userManager.IsInRoleAsync(appuser, "admin");

						if (isUser)
						{
							return RedirectToAction("Index", "Home");
						}

						if (isAdmin)
						{
                            return RedirectToAction("Dashboard", "Admin");
                        }

						
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
					string roleName = "Standard User";

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

		public async Task<IActionResult> Update(string id)
		{
			AppUser user = await userManager.FindByIdAsync(id);

            if (user != null)
            {
                return View(user);
            }
			else
			{
				return RedirectToAction("Index");
			}
        }

		[HttpPost]
		public async Task<IActionResult> Update(string id, string userName, string email, string password)
		{
			AppUser user = await userManager.FindByIdAsync(id);
			if (user != null)
			{
				if (!string.IsNullOrEmpty(userName))
				{
					user.UserName = userName;
				}
				else
				{
					ModelState.AddModelError("UpdateUser", "Username cannot be empty.");
				}

				if (!string.IsNullOrEmpty(email)) 
				{
					user.Email = email;
				}
				else
				{
                    ModelState.AddModelError("UpdateUser", "Email cannot be empty");
                }

				if (!string.IsNullOrEmpty (password))
				{
					user.PasswordHash = passwordHasher.HashPassword(user, password);
				}
				else
				{
					ModelState.AddModelError("UpdateUser", "Password cannot be empty");
				}

				if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password)) 
				{
					IdentityResult result = await userManager.UpdateAsync(user);
					if (result.Succeeded)
					{
						return RedirectToAction("Index");
					}
					else
					{
						Errors(result);

					}
				}
			}
			else
			{
				ModelState.AddModelError("UpdateUser", "User Not Found");
			}

			return View(user);
		}
		
		public async Task<IActionResult> Index()
		{
			AppUser user = await userManager.GetUserAsync(HttpContext.User);
			
			return View(user);
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
