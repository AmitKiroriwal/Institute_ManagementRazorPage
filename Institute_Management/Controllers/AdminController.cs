using Institute_Management.Interfaces;
using Institute_Management.Models;
using Microsoft.AspNetCore.Mvc;

namespace Institute_Management.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IApplicationUsers applicationUserRepo;
        public AdminController(ILogger<HomeController> logger, IApplicationUsers applicationUserRepo)
        {
            _logger = logger;
            this.applicationUserRepo = applicationUserRepo;

        }

        public IActionResult Index()
        {
            return View();
        }
        
        public async Task<IActionResult> GetAllUsers()
        {
            var model = await applicationUserRepo.GetApplicationUsers();
            _logger.LogInformation("All User Fetched Successfully");
            return View(model);
        }

        [HttpGet]
        [ActionName("Edit")]
        public async Task<IActionResult> EditUser(string id)
        {
            ApplicationUser applicationUser = await applicationUserRepo.GetApplicationUser(id);
            if (applicationUser != null)
            {
                return View(applicationUser);
            }
            return View();
        }
        [HttpPost]
        [ActionName("Edit")]
        public async Task<IActionResult> EditUser(ApplicationUser applicationUser)
        {
            if (applicationUser != null)
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
    }
}
