using Microsoft.AspNetCore.Mvc;

namespace AzureAd_Auth.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
        
    public IActionResult ConfidentialData() 
    {
        return View();    
    }
}