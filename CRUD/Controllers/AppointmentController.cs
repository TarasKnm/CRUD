using Microsoft.AspNetCore.Mvc;
using System;

namespace CRUD.Controllers
{
    public class AppointmentController : Controller
    {
        
        public IActionResult Index()
        {
           return View();
        }
        public IActionResult Details(string id)
        {
            return Ok("Your id: " + id);
            
        }
    }
}
