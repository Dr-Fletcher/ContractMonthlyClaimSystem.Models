using Microsoft.AspNetCore.Mvc;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class CoordinatorController : Controller
    {
        public IActionResult ApproveClaims()
        {
            return View();
        }
    }
}
