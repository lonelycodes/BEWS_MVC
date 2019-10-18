using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NickNames.Models;

namespace NickNames.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataBase db;

        public HomeController() {
            this.db = new DataBase();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNickName([FromBody]NewNickNameFormModel newNickNameFormModel)
        {
            // TODOWS
            // add new nickName for realName to db
            return Json("Error: Not Yet Implemented");
        }

        public IActionResult NickNameList(string realName)
        {
            // TODOWS
            // get nickNames from DB
            // add nickNames to ViewData
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
