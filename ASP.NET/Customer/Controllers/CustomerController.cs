namespace Project.Controller;

using Microsoft.AspNetCore.Mvc;

public class CustomerController : Controller
{
    public IActionResult Show()
    {
        return View();
    }
}
