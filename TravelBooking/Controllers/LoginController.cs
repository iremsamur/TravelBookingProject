using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TravelBooking.Models;

namespace TravelBooking.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public LoginController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel model)
        {
            AppUser appUser = new AppUser()
            {
                Name = model.Name,
                Surname = model.Surname,
                UserName = model.Username,
                Email = model.Mail


            };
            //şifre şifre tekrar uyumu
            if (model.ConfirmPassword == model.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser,model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
                
            }
            return View();
        }
        
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        /*
        [HttpPost]
        public IActionResult SignIn()
        {
            return View();
        }
        */

    }
}
