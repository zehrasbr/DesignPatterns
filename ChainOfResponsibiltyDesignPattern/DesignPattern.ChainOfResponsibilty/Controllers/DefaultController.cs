using DesignPattern.ChainOfResponsibilty.ChainOfResponsibility;
using DesignPattern.ChainOfResponsibilty.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.ChainOfResponsibilty.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel model)
        {
            Employee treasurer = new Treasurer();
            Employee managerAssistant = new ManagerAssistant();
            Employee manager = new Manager();
            Employee areaDirector = new AreaDirector();
            //treasurerin sonraki onaylayıcısı managerAssistant oluyor
            treasurer.SetNextApprover(managerAssistant);
            //managerAssistantın sonraki onaylayıcısı manager oluyor
            managerAssistant.SetNextApprover(manager);
            //managerin sonraki onaylayıcısı areaDirector oluyor
            manager.SetNextApprover(areaDirector);
            //modelden gelen isteği başlat
            treasurer.ProcessRequest(model);
            return View();
        }
    }
}
