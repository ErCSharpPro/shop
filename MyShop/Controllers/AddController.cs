using Microsoft.AspNetCore.Mvc;
using MyShop.Models;

namespace MyShop.Controllers;

public class AddController : Controller
{
    
    private Context _context= new Context();
    
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Submit(AddModel model)
    {
        List<string> _list =new List<string>();
        _list.Add(model.Name);
        _list.Add(model.Category);
        _list.Add(model.Cast);
        _context.Update(_list);
        return Redirect("/Start/");
    }
}