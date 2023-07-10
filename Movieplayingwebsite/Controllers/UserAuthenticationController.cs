using Microsoft.AspNetCore.Mvc;
using Movieplayingwebsite.Models.DTO;
using Movieplayingwebsite.Repositories.Abstract;

namespace Movieplayingwebsite.Controllers
{
    public class UserAuthenticationController : Controller
    {
        private IUserAuthenticationService authService; 
        public UserAuthenticationController(IUserAuthenticationService authService)
        {
            this.authService = authService;
        }
        /* here i am going to create admins 
        and then i am going to comment this methid because i need
        don't need anymore */
        /* public async Task<IActionResult> Register()
          {
              var model = new RegistrationModel
              {
                  Email = "admin@gmail.com",
                  Username = "admin",
                  Name = "Fiza",
                  Password = "Admin@123",
                  PasswordConfirm = "Admin@123",
                  Role = "Admin"
              };

              var result = await authService.RegisterAsync(model);
              return Ok(result.Message);*/

        /* var model = new RegistrationModel
         {
             Email = "admin1@gmail.com",
             Username = "admin1",
             Name = "Farzana",
             Password = "Admin1@123",
             PasswordConfirm = "Admin1@123",
             Role = "Admin"
         };

         var result = await authService.RegisterAsync(model);
         return Ok(result.Message);

        var model = new RegistrationModel
         {
             Email = "admin2@gmail.com",
             Username = "admin2",
             Name = "Rahman",
             Password = "Admin2@123",
             PasswordConfirm = "Admin2@123",
             Role = "Admin"
         };

         var result = await authService.RegisterAsync(model);
         return Ok(result.Message);
     }*/


        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = await authService.LoginAsync(model);
            if(result.StatusCode == 1)
            {
               
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["msg"] = "Couldn't logged in...";
                return RedirectToAction(nameof(Login));
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await authService.LogoutAsync();
            return RedirectToAction(nameof(Login));
        }


    }
}
