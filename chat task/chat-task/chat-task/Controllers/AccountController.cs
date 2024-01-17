using chat_task;
using chat_task.Models;
using chat_task.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
 

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVm register)
        {
            //if (!ModelState.IsValid) return View();


            AppUser user = new AppUser
            {
                FullName = register.FullName,
                UserName = register.UserName,

            };

            IdentityResult result = await _userManager.CreateAsync(user, register.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", $"{error.Description}");
                }
                return View();
            }
            await _signInManager.SignInAsync(user, true);
            return RedirectToAction("Index", "Home");
        }




        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {


            if (login.UserName == null)
            {
                ModelState.AddModelError("", "name or pasword incorrect");
                return View();
            }
            if (login.Password == null)
            {
                ModelState.AddModelError("", "name or pasword incorrect");
                return View();
            }
            if (!ModelState.IsValid) return View();
            AppUser user = await _userManager.FindByNameAsync(login.UserName);

            if (user == null)
            {
                ModelState.AddModelError("", "UserName or Password incorrect");
                return View();
            }
           

            Microsoft.AspNetCore.Identity.SignInResult Result = await _signInManager.PasswordSignInAsync(user.UserName, login.Password, true, false);

            if (!Result.Succeeded)
            {
                if (Result.IsLockedOut)
                {
                    ModelState.AddModelError("", "your account blocked 5 minute");
                    return View();
                }
                ModelState.AddModelError("", "UserName or Password Incorrect");
                return View();
            }

            return RedirectToAction("Index", "Home");


        }

        public IActionResult Show()
        {
            return Content(User.Identity.Name);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}