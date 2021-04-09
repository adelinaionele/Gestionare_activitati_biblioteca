using BookWorms.DataAccess;
using BookWorms.Models.Admins;
using BookWorms.BusinessLogic.DataModel;
using BookWorms.BusinessLogic.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;


namespace BookWorms.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly AdminService adminsService;
        public AdminController(UserManager<IdentityUser> userManager, AdminService adminsService)
        {
            this.userManager = userManager;
            this.adminsService = adminsService;
        }

        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddBook([FromForm] AdminAddBookViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var userId = userManager.GetUserId(User);
                adminsService.AddBook(userId, model.Name, model.Description);

                return Redirect(Url.Action("Index", "Admin"));
            }
            catch(Exception)
            {
                return BadRequest("Invalid request received");
            }

        }


        
    }
}