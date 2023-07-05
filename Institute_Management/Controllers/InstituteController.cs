using Microsoft.AspNetCore.Mvc;

namespace Institute_Management.Controllers
{
    public class InstituteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
