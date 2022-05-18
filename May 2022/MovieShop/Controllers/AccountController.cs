using Application_Core.Contracts.Services;
using Application_Core.Exceptions;
using Application_Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        // showing the empty page
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // when user clicks on Submit/register button
        // 
        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterModel model)
        {
            // save the info in User Table
            try
            {
                var user = await _accountService.RegisterUser(model);
            }
            catch(ConflictException)
            {
                throw;
                // logging the exceptions later to text/json files
            }
        
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginModel model)
        {
            //Model Binding, it looks at the incoming request from clinet/browser and look at the infor and if th
            //matches with the properties of the model it will get the values automatically
            try
            {
                var user = await _accountService.LoginUser(model.Email, model.Password);
                if(user != null)
                {
                    //redirect to home page
                    return LocalRedirect("~/");
                }
            }
            catch(Exception)
            {
                return View();
                throw;
            }
            return View();
        }

    }
}
