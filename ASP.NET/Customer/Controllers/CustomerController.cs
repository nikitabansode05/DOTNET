namespace Project.Controller;

using Microsoft.AspNetCore.Mvc;
using Model;
public class CustomerController : Controller
{
    public IActionResult Show()
    {
        return View();
    }

    public IActionResult AboutUs()
    {
        return View();
    }

    public IActionResult Details()
    {
        var customer=new Customer{FirstName="Nikita", LastName="Bansode"};
        return View(customer);
    }
}
