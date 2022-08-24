using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelApplication.Models;

namespace TravelApplication.Controllers
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
        public async  Task<IActionResult> SignUp(UserRegisterViewModel userRegister)
        {
            AppUser appUser = new AppUser()
            {
                UserName = userRegister.UserName,
                Email = userRegister.EMail,
                PhoneNumber = userRegister.PhoneNumber,

            };
            if(userRegister.Password == userRegister.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser, userRegister.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }
                else
                {
                    foreach (var item in result.Errors)
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
    }
}
