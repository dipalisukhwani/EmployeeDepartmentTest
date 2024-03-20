using Microsoft.AspNetCore.Mvc;

namespace EmployeeLoginAPP.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
