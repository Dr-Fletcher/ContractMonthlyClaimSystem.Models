using Microsoft.AspNetCore.Mvc;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult ReviewClaims()
        {
            return View();
        }
    }
}
