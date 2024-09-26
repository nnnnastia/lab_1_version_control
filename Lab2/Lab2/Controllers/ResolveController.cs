using Microsoft.AspNetCore.Mvc;

namespace YourAppNamespace.Controllers
{
    public class ResolveController : Controller
    {
        // Дія Show, яка повертає подання
        public IActionResult Show()
        {
            ViewData["Message"] = "Це нове представлення, створене в ResolveController.";
            return View();
        }
    }
}