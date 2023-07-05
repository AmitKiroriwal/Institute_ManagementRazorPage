using Institute_Management.Data;
using Institute_Management.Interfaces;
using Institute_Management.Models;
using Institute_Management.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Institute_Management.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        private readonly IApplicationUsers applicationUserRepo;
        public HomeController(ILogger<HomeController> logger,IApplicationUsers applicationUserRepo)
        {
            _logger = logger;
            this.applicationUserRepo=applicationUserRepo;
            
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Dashboard(string userId, string userName)
        {
            var model= await applicationUserRepo.GetApplicationUser(userId);
            if (model != null)
            {
                return View(model);
            }
            return View();
        }
        public async Task<IActionResult> GetAllUsers()
        {
            var model = await applicationUserRepo.GetApplicationUsers();
            return View(model);
        }

        [HttpGet]
        [ActionName("Edit")]
        public async Task<IActionResult> EditUser(string id)
        {
            ApplicationUser applicationUser = await applicationUserRepo.GetApplicationUser(id);
            if(applicationUser != null)
            {
                return View(applicationUser);
            }
            return View();
        }
        [HttpPost]
        [ActionName("Edit")]
        public async Task<IActionResult>EditUser(ApplicationUser applicationUser)
        {
            if(applicationUser != null)
            {
               await applicationUserRepo.UpdateApplicationUser(applicationUser);
                return RedirectToAction("GetAllUsers");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            await applicationUserRepo.DeleteApplicationUser(id);
            return RedirectToAction("GetAllUsers");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}