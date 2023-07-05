using Microsoft.AspNetCore.Mvc;

namespace Institute_Management.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
