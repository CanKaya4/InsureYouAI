using Microsoft.AspNetCore.Mvc;

namespace InsureYouAI.Controllers
{
    public class AdminLayout : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
