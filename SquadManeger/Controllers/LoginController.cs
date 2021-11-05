using Microsoft.AspNetCore.Mvc;
using SquadManeger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquadManeger.Controllers
{
    public class LoginController : Controller
    {

        public IActionResult Index()
        {
            UserViewModel user = new UserViewModel();

            return View("index", user);
        }
        [HttpPost]
        public IActionResult Test(UserViewModel user)
        {
            user.Email = "Email enviado";

            return View("index",user);
        }
    }
}
