using Microsoft.AspNetCore.Mvc;

namespace GCM.FinancialMarketNotifier.Admin.Controllers;

public class AboutController : Controller
{
    public IActionResult About()
    {
        return View();
    }
}
