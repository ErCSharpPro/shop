using Microsoft.AspNetCore.Mvc;
using MyShop.Models;


namespace MyShop.Controllers;

public class StartController : Controller
{
    private Context _context = new Context();
    // GET
    public IActionResult Index(StartModel model)
    {

        model.proList = _context.GetMassiv();
        return View(model);
        
    }
}