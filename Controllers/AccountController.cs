using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShopUKW2025.Models.Users;

namespace ShopUKW2025.Controllers
{
    public class AccountController : Controller
    {
        UserManager<AppUser> _userManager;

        SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        public async Task<IActionResult> Login()
        {
            var result = await _signInManager.PasswordSignInAsync("TestUser", "Test", false, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
                
            }
            else
            {
                ViewBag.Result = $"Nie udało się({result})";
            }
            return View();
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        public async Task<IActionResult> Register()
        {
            var user = await _userManager.FindByNameAsync(model.UserName);

            if (user == null)
            {
                user = new AppUser()
                { UserName = model.UserName,
                  Email = model.Email,
                  FirstName = model.FirstName,
                  LastName = model.LastName,
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if(result.Succeeded)
                {
                    ViewBag.Result = "Zarejestrowano użytkownika";

                    await SignInManager.SignInAsync(user, false);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                                       ViewBag.Result = "Nie udało się zarejestrować użytkownika";

                }
            }

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
