using Microsoft.AspNetCore.Mvc;

namespace GCM.FinancialMarketNotifier.Admin.Controllers;

public class SocialController : Controller
{
    public IActionResult Social()
    {
        return View();
    }
}
